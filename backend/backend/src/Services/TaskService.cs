using backend.src.DTO;
using Backend.Context;
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

        public async Task<IEnumerable<SuscribersInfoDto>> GetTasks(PaginateProps props)
        {
            int skip = (props.PageNumber - 1) * props.PageSize;
            var suscriberInfo = await _context.Subscriptors
                .Include(x => x.Assignments)
                    .ThenInclude(x => x.ServiceCatalog)
                .Skip(skip)     
                .Take(props.PageSize) 
                .ToListAsync();
            return suscriberInfo.Select(x => new SuscribersInfoDto
            {
                id = x.id,
                name = x.name,
                lasst_name = x.last_name,
                post_Code = x.post_Code,
                street = x.street,
                zone_sub = x.zone_sub,
                assigments = x.Assignments.Select(a => new AssigmentsDetails
                {
                    assignment_date = DateTime.Now.ToString(),
                    assignment_status = a.status_assigment,
                    assignment_type = a.ServiceCatalog?.service_name ?? "Unknown"
                }).ToList()
            }).ToList();
        }

    }
}