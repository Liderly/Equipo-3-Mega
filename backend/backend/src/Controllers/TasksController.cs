using Backend.DTO;
using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.src.DTO;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        /// <summary>
        /// Obtiene las tareas asignadas a un t�cnico utilizando su n�mero de empleado.
        /// </summary>
        /// <param name="NumEmp">N�mero de empleado �nico del t�cnico.</param>
        /// <returns>
        /// Un objeto <see cref="TecTasks"/> que contiene la informaci�n del t�cnico y sus tareas asignadas.
        /// Devuelve un c�digo de estado 200 OK si la operaci�n es exitosa.
        /// Devuelve un c�digo de estado 404 NotFound si no se encuentra el t�cnico.
        /// Devuelve un c�digo de estado 400 BadRequest si ocurre un error inesperado.
        /// </returns>
        /// <response code="200">Devuelve las tareas del t�cnico.</response>
        /// <response code="404">Si el t�cnico no se encuentra.</response>
        /// <response code="400">Si ocurre un error inesperado.</response>
        [HttpGet("{NumEmp}")]
        public async Task<ActionResult<TecTasks>> Get(int NumEmp)
        {
            try
            {
                var result = await _taskService.GetTasksByNumEmp(NumEmp);
                return Ok(result);  // Devuelve el resultado con un c�digo 200 OK
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });  
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message }); 
            }
        }
        /// <summary>
        /// Crea una nueva tarea.
        /// </summary>
        /// <param name="createTaskDto">Datos de la tarea que se va a crear.</param>
        /// <returns>Un objeto <see cref="TaskResponseDto"/> con los detalles de la tarea creada y un mensaje de �xito o error.</returns>
        /// <response code="200">Tarea creada exitosamente.</response>
        /// <response code="400">Si ocurre un error al crear la tarea.</response>
        [HttpPost]
        public async Task<ActionResult<TaskResponseDto>> CreateTask([FromBody] CreateTaskDto createTaskDto)
        {
            try
            {
                var result = await _taskService.CreateTask(createTaskDto);
                var response = new TaskParseResponseDto
                {
                    task = result,
                    Message = "Tarea creada exitosamente",
                    Status = "Exitoso"
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new TaskParseResponseDto
                {
                    Message = $"Error al crear la tarea: {ex.Message}",
                    Status = "Error"
                });
            }
        }
        /// <summary>
        /// Actualiza una tarea existente.
        /// </summary>
        /// <param name="id">El ID de la tarea a actualizar.</param>
        /// <param name="updateTaskDto">Datos actualizados de la tarea.</param>
        /// <returns>Un objeto <see cref="TaskResponseDto"/> con los detalles de la tarea actualizada y un mensaje de �xito o error.</returns>
        /// <response code="200">Tarea actualizada exitosamente.</response>
        /// <response code="400">Si ocurre un error al actualizar la tarea.</response>
        /// <response code="404">Si no se encuentra la tarea con el ID proporcionado.</response>
        [HttpPut("{id}")]
        public async Task<ActionResult<TaskResponseDto>> UpdateTask(int id, [FromBody] UpdateTaskDto updateTaskDto)
        {
            try
            {
                var result = await _taskService.UpdateTask(id, updateTaskDto);
                if (result == null)
                {
                    return NotFound(new TaskParseResponseDto
                    {
                        Message = $"No se encontr� la tarea con ID {id}",
                        Status = "No encontrado"
                    });
                }
                var response = new TaskParseResponseDto
                {
                    task = result,
                    Message = "Tarea actualizada exitosamente",
                    Status = "Exitoso"
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new TaskResponseDto
                {
                    Message = $"Error al actualizar la tarea: {ex.Message}",
                    Status = "Error"
                });
            }
        }
        /// <summary>
        /// Elimina una tarea por su ID.
        /// </summary>
        /// <param name="id">El ID de la tarea a eliminar.</param>
        /// <returns>Un objeto <see cref="TaskResponseDto"/> con los detalles de la tarea eliminada y un mensaje de �xito o error.</returns>
        /// <response code="200">Tarea eliminada exitosamente.</response>
        /// <response code="400">Si ocurre un error al eliminar la tarea.</response>
        /// <response code="404">Si no se encuentra la tarea con el ID proporcionado.</response>
        [HttpDelete("{id}")]
        public async Task<ActionResult<TaskResponseDto>> DeleteTask(int id)
        {
            try
            {
                var result = await _taskService.DeleteTask(id);
                if (result == null)
                {
                    return NotFound(new TaskResponseDto
                    {
                        Message = $"No se encontr� la tarea con ID {id}",
                        Status = "No encontrado"
                    });
                }
                var response = new TaskResponseDto
                {
                    Task = result,
                    Message = "Tarea eliminada exitosamente",
                    Status = "Exitoso"
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new TaskResponseDto
                {
                    Message = $"Error al eliminar la tarea: {ex.Message}",
                    Status = "Error"
                });
            }
        }
    }

    public class TaskResponseDto
    {
        public Assignment Task { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
    }
    public class TaskParseResponseDto {
        public AssignmentDto task { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
    }
    
        
    
}