using Backend.DTO;
using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
       public async Task<ActionResult<IEnumerable<Suscriber>>> GetItems()
{
    var suscribers = await _taskService.GetTasks();
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
