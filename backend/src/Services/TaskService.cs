using Backend.Context;
using Backend.Models;
using Backend.Services;
using Microsoft.EntityFrameworkCore;

namespace Services{
    public class TaskService : ITaskService
    {
        private readonly ContextDB _context;
        

        public TaskService(ContextDB context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Suscriber>> GetTasks()
        {
            return await _context.Suscriber.ToListAsync();
        }

    }
}