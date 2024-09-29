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
        private readonly ICacheService _cacheService;


        public SuscriberService(ContextDB context, ICacheService cacheService)
        {
            _context = context;
            _cacheService = cacheService;
        }

        public async Task<SubscriberResponse> GetSubscribers(PaginateProps props)
        {
            int skip = (props.PageNumber - 1) * props.PageSize;
            string cacheKey = $"subscribers_{skip}_{props.PageSize}";
            var cacheValue = await _cacheService.GetCache<SubscriberResponse>(cacheKey);
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
            await _cacheService.SetCache(resp,cacheKey);
            return resp;
               
        }
        public async Task<SuscribersInfoDto> GetSuscriberById(int id)
        {
            var suscriber = await _context.Subscriptors
                .Include(x => x.Assignments)
                    .ThenInclude(x => x.JobsCatalog)
                .FirstOrDefaultAsync(x => x.id == id);
            return ParseSubInfo(suscriber);
        }
        private async Task<IEnumerable<Suscriber>> GetSubsListFromDB(int skip, PaginateProps props)
        {
            var query = _context.Subscriptors
                .Include(x => x.Assignments)
                    .ThenInclude(x => x.JobsCatalog)
                .Skip(skip)
                .Take(props.PageSize);
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
                post_Code = x.post_code,
                street = x.street,
                zone_sub = x.zone,
                assigments = x.Assignments.Select(a => new AssigmentsDetails
                {
                    assignment_date = DateTime.Now.ToString(),
                    assignment_status = a.status_assigment,
                    assignment_type = a.JobsCatalog?.name ?? "Unknown"
                }).ToList()
            };
            }
    }
}