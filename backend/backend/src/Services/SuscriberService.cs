using backend.src.DTO;
using backend.src.Services;
using Backend.Context;
using Backend.Models;
using Backend.Services;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class SuscriberService : ISuscriberService
    {
        private readonly ContextDB _context;
        private readonly ICacheService cacheService;


        public SuscriberService(ContextDB context, ICacheService cacheService)
        {
            _context = context;
            this.cacheService = cacheService;
        }

        public async Task<SubscriberResponse> GetSubscribers(PaginateProps props)
        {
            int skip = (props.PageNumber - 1) * props.PageSize;
            string cacheKey = $"subscribers_{skip}_{props.PageSize}";
            var cacheValue = await cacheService.GetCache<SubscriberResponse>(cacheKey);
            if (cacheValue != null)
            {
                return cacheValue;
            }
            var suscriberInfo = await GetSubsListFromDB(skip,props);

            SubscriberResponse resp= new SubscriberResponse
            {
                subscribers = suscriberInfo.Select(
                    x => ParseSubInfo(x)
                ).ToList(),
                Elements = await _context.Subscriptors.CountAsync()
            };
            await cacheService.SetCache(resp,cacheKey);
            return resp;
               
        }
        public async Task<SuscribersInfoDto> GetSuscriberById(int id)
        {
            var suscriber = await _context.Subscriptors
                .Include(x => x.Assignments)
                    .ThenInclude(x => x.ServiceCatalog)
                .FirstOrDefaultAsync(x => x.id == id);
            return ParseSubInfo(suscriber);
        }
        private async Task<IEnumerable<Suscriber>> GetSubsListFromDB(int skip, PaginateProps props)
        {
            var query = _context.Subscriptors
                .Include(x => x.Assignments)
                    .ThenInclude(x => x.ServiceCatalog)
                .Skip(skip)
                .Take(props.PageSize);
            switch (props.SortBy.ToLower())
            {
                case "name":
                    query = props.SortDirection.ToLower() == "desc"
                        ? query.OrderByDescending(x => x.name)
                        : query.OrderBy(x => x.name);
                    break;
                case "date":
                    query = props.SortDirection.ToLower() == "desc"
                        ? query.OrderByDescending(x => x.last_name) 
                        : query.OrderBy(x => x.last_name);
                    break;
                case "id":
                default:
                    query = props.SortDirection.ToLower() == "desc"
                        ? query.OrderByDescending(x => x.id)
                        : query.OrderBy(x => x.id);
                    break;
            }
            var suscriberInfo = await query.ToListAsync();
            return suscriberInfo;
        }
        private SuscribersInfoDto ParseSubInfo(Suscriber x)
        {
            return new SuscribersInfoDto
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
            };
            }
    }
}