using Backend.DTO;
using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;
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
        // GET: api/items
        [HttpGet]
       public async Task<ActionResult<IEnumerable<Suscriber>>> GetItems([FromQuery]PaginateProps props)
{
    var suscribers = await _taskService.GetTasks(props);
    return Ok(suscribers);
}


        // GET: api/items/1
        [HttpGet("{id}")]
        public ActionResult<ITaskDto> GetItem(int id)
        {
            ITaskDto task = new TaskDto();
            return new TaskDto();
        }
    }
    
}
