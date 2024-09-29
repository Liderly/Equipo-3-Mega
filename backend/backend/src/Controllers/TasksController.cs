using Backend.DTO;
using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;
using backend.src.DTO;
using backend.Models;

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