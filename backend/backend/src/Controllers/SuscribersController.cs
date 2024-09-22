using Microsoft.AspNetCore.Mvc;
using backend.src.DTO;
using backend.src.Services;

namespace Backend.Controllers
{
    /// <summary>
    /// Controlador para gestionar la información de los suscriptores.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SuscribersController : ControllerBase
    {
        private readonly ISuscriberService _SubscriberService;
        public SuscribersController(ISuscriberService sub_Service)
        {
            _SubscriberService = sub_Service;
        }
        /// <summary>
        /// Obtiene una lista paginada de suscriptores.
        /// </summary>
        /// <param name="props">
        /// Parámetros de consulta para la paginación y filtrado de la lista de suscriptores. Los parámetros esperados son:
        /// - pageNumber: Número de la página a consultar (debe ser mayor a 0).
        /// - pageSize: Cantidad de elementos por página (debe ser mayor a 0).
        /// - sortBy (opcional): Campo por el cual ordenar los resultados.
        /// - SortDirection (opcional): Dirección de ordenamiento (asc o desc).
        /// </param>
        /// <returns>Un objeto SubscriberResponse que contiene una lista de suscriptores y la información de paginación.</returns>
        /// <remarks>
        /// Ejemplo de solicitud:
        /// 
        ///     GET /api/suscribers?pageNumber=1&amp;pageSize=10&amp;sortBy=name&amp;SortDirection=asc
        /// 
        /// Esta solicitud devuelve la primera página con 10 suscriptores, ordenados por nombre de forma ascendente.
        /// </remarks>
        [HttpGet]
        public async Task<ActionResult<SubscriberResponse>> GetSubscribersList([FromQuery] PaginateProps props)
        {
            var suscribers = await _SubscriberService.GetSubscribers(props);
            return Ok(suscribers);
        }

        /// <summary>
        /// Obtiene la información detallada de un suscriptor específico.
        /// </summary>
        /// <param name="id">Identificador del suscriptor.</param>
        /// <returns>Información detallada del suscriptor.</returns>
        /// <remarks>
        /// Ejemplo de solicitud:
        ///
        ///     GET /api/suscribers/1
        ///
        /// </remarks>
        [HttpGet("{id}")]
        public async Task<ActionResult<SuscribersInfoDto>> GetSubscriber(int id)
        {
            var suscribers = await _SubscriberService.GetSuscriberById(id);
            if (suscribers == null)
            {
                return NotFound();
            }
            return Ok(suscribers);
        }
    }
}
