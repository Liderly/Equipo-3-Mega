using Microsoft.AspNetCore.Mvc;
using backend.src.DTO;
using backend.src.Services;

namespace Backend.Controllers
{
    /// <summary>
    /// Controlador para gestionar la informaci�n de los suscriptores.
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
        /// Par�metros de consulta para la paginaci�n y filtrado de la lista de suscriptores. Los par�metros esperados son:
        /// - pageNumber: N�mero de la p�gina a consultar (debe ser mayor a 0).
        /// - pageSize: Cantidad de elementos por p�gina (debe ser mayor a 0).
        /// - sortBy (opcional): Campo por el cual ordenar los resultados.
        /// - SortDirection (opcional): Direcci�n de ordenamiento (asc o desc).
        /// </param>
        /// <returns>Un objeto SubscriberResponse que contiene una lista de suscriptores y la informaci�n de paginaci�n.</returns>
        /// <remarks>
        /// Ejemplo de solicitud:
        /// 
        ///     GET /api/suscribers?pageNumber=1&amp;pageSize=10&amp;sortBy=name&amp;SortDirection=asc
        /// 
        /// Esta solicitud devuelve la primera p�gina con 10 suscriptores, ordenados por nombre de forma ascendente.
        /// </remarks>
        [HttpGet]
        public async Task<ActionResult<SubscriberResponse>> GetSubscribersList([FromQuery] PaginateProps props)
        {
            var suscribers = await _SubscriberService.GetSubscribers(props);
            return Ok(suscribers);
        }

        /// <summary>
        /// Obtiene la informaci�n detallada de un suscriptor espec�fico.
        /// </summary>
        /// <param name="id">Identificador del suscriptor.</param>
        /// <returns>Informaci�n detallada del suscriptor.</returns>
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
