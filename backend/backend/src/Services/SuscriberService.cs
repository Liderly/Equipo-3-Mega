using backend.src.DTO;
using backend.src.Services;
using Backend.Context;
using Backend.Services;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class SuscriberService : ISuscriberService
    {
        private readonly ContextDB _context;


        public SuscriberService(ContextDB context)
        {
            _context = context;
        }

        public async Task<SubscriberResponse> GetSubscribers(PaginateProps props)
        {
            int skip = (props.PageNumber - 1) * props.PageSize;
            var suscriberInfo = await _context.Subscriptors
                .Include(x => x.Assignments)
                    .ThenInclude(x => x.ServiceCatalog)
                .Skip(skip)
                .Take(props.PageSize)
                .ToListAsync();
            return new SubscriberResponse
            {
                subscribers = suscriberInfo.Select(x => new SuscribersInfoDto
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
                }).ToList(),
                Elements = await _context.Subscriptors.CountAsync()
            };
               
        }
        public async Task<SuscribersInfoDto> GetSuscriberById(int id)
        {
            var suscriber = await _context.Subscriptors
                .Include(x => x.Assignments)
                    .ThenInclude(x => x.ServiceCatalog)
                .FirstOrDefaultAsync(x => x.id == id);
            return new SuscribersInfoDto
            {
                id = suscriber.id,
                name = suscriber.name,
                lasst_name = suscriber.last_name,
                post_Code = suscriber.post_Code,
                street = suscriber.street,
                zone_sub = suscriber.zone_sub,
                assigments = suscriber.Assignments.Select(a => new AssigmentsDetails
                {
                    assignment_date = DateTime.Now.ToString(),
                    assignment_status = a.status_assigment,
                    assignment_type = a.ServiceCatalog?.service_name ?? "Unknown"
                }).ToList()
            };
        }

    }
}