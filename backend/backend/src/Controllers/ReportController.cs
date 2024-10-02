using Microsoft.AspNetCore.Mvc;
using backend.src.DTO;
using backend.src.Services;
using backend.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Backend.Controllers
{
    /// <summary>
    /// Controlador para gestionar la información de los suscriptores.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IBonusReportService _report_service;
        private readonly ICacheService _cacheService;
        public ReportController(IBonusReportService report_service, ICacheService cacheService)
        {
            _report_service = report_service;
            _cacheService = cacheService;
        }
        /// <summary>
        /// Obtiene una lista paginada de la informacion para los bonos de la semana en curso Lunes-Sabado.
        /// </summary>
        /// <param name="props">
        /// Parámetros de consulta para la paginación y filtrado de la lista de suscriptores. Los parámetros esperados son:
        /// - pageNumber: Número de la página a consultar (debe ser mayor a 0).
        /// - pageSize: Cantidad de elementos por página (debe ser mayor a 0).
        /// - sortBy (opcional): Campo por el cual ordenar los resultados.
        /// </param>
        /// <param name="NumTec">Número de técnico a buscar.</param>
        /// <returns>Un objeto BonusReport que contiene una lista de tecnicos instaladores con sus instalacion correspondientes paginación.</returns>
        /// <remarks>
        /// Ejemplo de solicitud:
        /// 
        ///     GET /api/Report?pageNumber=1&amp;pageSize=10&amp;sortBy=name;
        /// 
        /// Esta solicitud devuelve la primera página con 10 tecnicos, ordenados por nombre.
        /// </remarks>
        [HttpGet]
        public async Task<ActionResult<BonusReport>> GetReportList([FromQuery] PaginateProps props, [FromQuery] int NumTec) 
        {
            if (NumTec>0)
            {
                var report = await _report_service.GetBonusReport(props, NumTec);
                return Ok(report);
            }
            var cacheKey = $"Report_page_{props.PageNumber}";
            var EmpReport = await _cacheService.GetCache<BonusReport>(cacheKey);
            if (EmpReport == null) 
            {
            var report = await _report_service.GetBonusReport(props,NumTec);
            await _cacheService.SetCache<BonusReport>(report, cacheKey);
                return Ok(report);
            }
                
            return Ok(EmpReport);
        }

        /// <summary>
        /// Obtiene toda la informacion de bonos de un tecnico.
        /// </summary>
        /// <param name="NumTec">Identificador del susc.</param>
        /// <returns>Detalles de bono de tecnico.</returns>
        /// <remarks>
        /// Ejemplo de solicitud:
        ///
        ///     GET /api/Report/1002
        ///
        /// </remarks>
        [HttpGet("{NumTec}")]
        public async Task<ActionResult<BonusReport.TechInfo>> GetReportByNumTec(int NumTec)
        {

            var techReport = await _report_service.GetBonusReportById(NumTec);
            if (techReport == null)
            {
                return NotFound();
            }
            return Ok(techReport);
        }

        /// <summary>
        /// Obtener un listado de los bonos de todos los tecnicos.
        /// </summary>
        /// <returns>Detalles de bono de tecnico.</returns>

        [HttpGet]
        [Route("All")]
        public async Task<ActionResult<BonusReport>> GetFullReport()
        {
            var cacheKey = $"Full_Report";
            var EmpReport = await _cacheService.GetCache<BonusReport>(cacheKey);
            if (EmpReport == null)
            {
                var report = await _report_service.GetFullReport();
                await _cacheService.SetCache<BonusReport>(report, cacheKey);
                return Ok(report);
            }
            return Ok(EmpReport);
        }
    }
}
