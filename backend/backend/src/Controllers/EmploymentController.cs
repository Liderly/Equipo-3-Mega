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

        public EmployeeController(IEmploymentService employmentService)
        {
            _employmentService = employmentService;
        }
        /// <summary>
        /// Obtiene la lista de todos los técnicos y empleados, con opciones de paginación.
        /// </summary>
        /// <param name="props">Parámetros de paginación que incluyen el número de página y el tamaño de página.</param>
        /// <returns>Una lista paginada de objetos EmploymentDto.</returns>

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmploymentDto>>> GetEmployments([FromQuery] PaginateProps props)
        {
            var employments = await _employmentService.GetAllEmployments(props);
            return Ok(employments);
        }
        /// <summary>
        /// Obtiene un empleo por su ID.
        /// </summary>
        /// <param name="id">ID del empleo a obtener.</param>
        /// <returns>El empleo con el ID especificado.</returns>
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
        /// Actualiza un empleo existente.
        /// </summary>
        /// <param name="id">ID del empleo a actualizar.</param>
        /// <param name="employment">Datos actualizados del empleo.</param>
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
        /// Crea un nuevo empleo.
        /// </summary>
        /// <param name="employment">Datos del empleo a crear.</param>
        /// <returns>El empleo recién creado.</returns>
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