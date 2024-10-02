using backend.src.DTO;
using backend.src.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmploymentService _employmentService;
        private readonly ICacheService _cacheService;

        public EmployeeController(IEmploymentService employmentService, ICacheService cacheService)
        {
            _employmentService = employmentService;
            _cacheService = cacheService;
        }
        /// <summary>
        /// Obtiene la lista de todos los técnicos y empleados, con opciones de paginación.
        /// </summary>
        /// <param name="props">Parámetros de paginación que incluyen el número de página y el tamaño de página.</param>
        /// <returns>Una lista paginada de objetos EmploymentDto.</returns>

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmploymentDto>>> GetEmployments([FromQuery] PaginateProps props)
        {
            string cacheKey = $"Employments_page_{props.PageNumber}";
            IEnumerable<EmploymentDto> emp = await _cacheService.GetCache<IEnumerable<EmploymentDto>>(cacheKey);
            if (emp == null)
            {
                var employments = await _employmentService.GetAllEmployments(props);
            
            if (employments != null && employments.Any())
            {
                await _cacheService.SetCache<IEnumerable<EmploymentDto>>(employments, cacheKey);
            }
            return Ok(employments);
        }

             return Ok(emp);
    }
    /// <summary>
    /// Obtiene un empleado por su ID.
    /// </summary>
    /// <param name="id">ID del empleado a obtener.</param>
    /// <returns>El empleado con el ID especificado.</returns>
    [HttpGet("{id}")]
        public async Task<ActionResult<EmploymentDto>> GetEmployment(int id)
        {
            var employment = await _employmentService.GetEmploymentById(id);

            if (employment == null)
            {
                return NotFound();
            }

            return employment;
        }
        /// <summary>
        /// Actualiza un empleado existente.
        /// </summary>
        /// <param name="id">ID del empleado a actualizar.</param>
        /// <param name="employment">Datos actualizados del empleado.</param>
        /// <returns>Una respuesta HTTP que indica el resultado de la operación.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployment(int id, UpdateEmploymentDto employment)
        {
            if (id.ToString().Equals(""))
            {
                return BadRequest();
            }

            try
            {
                await _employmentService.UpdateEmployment(id, employment);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_employmentService.EmploymentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(new { Message = "Empleado actualizado con exito" });
        }
        /// <summary>
        /// Crea un nuevo empleado.
        /// </summary>
        /// <param name="employment">Datos del emplado a crear.</param>
        /// <returns>El empleado recién creado.</returns>
        [HttpPost]
        public async Task<ActionResult<EmploymentDto>> PostEmployment(CreateEmploymentDto employment)
        {
            var createdEmployment = await _employmentService.CreateEmployment(employment);
            return CreatedAtAction(nameof(GetEmployment), new { id = createdEmployment.Id }, new
            {
                Employment = createdEmployment,
                Message = "Empleado creado exitosamente"
            });
        }
        /// <summary>
        /// Elimina un empleo por su ID.
        /// </summary>
        /// <param name="id">ID del empleo a eliminar.</param>
        /// <returns>Una respuesta HTTP que indica el resultado de la operación.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployment(int id)
        {
            var employment = await _employmentService.GetEmploymentById(id);
            if (employment == null)
            {
                return NotFound();
            }
            await _employmentService.DeleteEmployment(id);
            return Ok(new { Message = "Empleado eliminado con exito" });
        }
    }
}