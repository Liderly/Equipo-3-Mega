using Microsoft.AspNetCore.Mvc;
using backend.src.DTO;
using backend.src.Services;
using backend.Models;

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
        public ReportController(IBonusReportService report_service)
        {
            _report_service = report_service;
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
            var report = await _report_service.GetBonusReport(props,NumTec);
            return Ok(report);
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
    }
}
