using backend.Models;
using backend.src.DTO;
using backend.src.Utils;
using Backend.Context;
using Microsoft.EntityFrameworkCore;
using static backend.src.DTO.BonusReport;

namespace backend.src.Services
{
    public class BonusReportService : IBonusReportService
    {
        private readonly ContextDB _context;
        private readonly ICacheService _cacheService;
        private readonly BonusCalculator _bonusCalculator;
        private DateTime currentWeekMonday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
        private DateTime currentWeekSaturday = DateTime.Today.AddDays(20);
        public BonusReportService(ContextDB context, ICacheService cacheService) {
            _context = context;
            _bonusCalculator = new BonusCalculator(context);
            _cacheService = cacheService;
        }
       
        public async Task<BonusReport> GetBonusReport(PaginateProps props, int NumTec)
        {
            var report = new BonusReport();
            var query = _context.Technicians.AsQueryable();
            // Aplicar filtros si se proporcionan
            if (NumTec > 0)
            {
                string numTecString = NumTec.ToString();
                query = query.Where(t => EF.Functions.Like(t.employee_number.ToString(), numTecString + "%"));
            }
            var technicianData = await query
            .OrderBy(x => EF.Property<object>(x, props.SortBy ?? "id"))
            .Skip(props.PageSize * (props.PageNumber - 1))
            .Take(props.PageSize)
            .Include(t => t.Quadrille)
            .Include(t => t.Assignments.Where(a =>
                a.Assigment_date >= currentWeekMonday &&
                a.Assigment_date <= currentWeekSaturday))
                    .ThenInclude(a => a.Subscriptor)
            .Include(t => t.Assignments.Where(a =>
                a.Assigment_date >= currentWeekMonday &&
                a.Assigment_date <= currentWeekSaturday))
                    .ThenInclude(a => a.JobsCatalog)
        .ToListAsync();

            List<TechInfo> ParsedTech = technicianData.Select(item => ParseTechInfo(item)).ToList();

            report.technitians = ParsedTech;
            report.Total_Technicians = await _context.Technicians.CountAsync();
            return report;
        }


        public async Task<TechInfo> GetBonusReportById(int techNumber)
        {
            Technician tech = await _context.Technicians
            .Where(t => t.employee_number == techNumber)
            .Include(t => t.Quadrille)
            .Include(t => t.Assignments.Where(a =>
                a.Assigment_date >= currentWeekMonday &&
                a.Assigment_date <= currentWeekSaturday))
                    .ThenInclude(a => a.Subscriptor)
            .Include(t => t.Assignments.Where(a =>
                a.Assigment_date >= currentWeekMonday &&
                a.Assigment_date <= currentWeekSaturday))
                    .ThenInclude(a => a.JobsCatalog)
            .FirstAsync();
            return ParseTechInfo(tech);
        }

        public async Task<BonusReport> GetFullReport()
        {
            var report = new BonusReport();
            var technicianData = await _context.Technicians
            .Include(t => t.Quadrille)
            .Include(t => t.Assignments.Where(a =>
                a.Assigment_date >= currentWeekMonday &&
                a.Assigment_date <= currentWeekSaturday))
                    .ThenInclude(a => a.Subscriptor)
            .Include(t => t.Assignments.Where(a =>
                a.Assigment_date >= currentWeekMonday &&
                a.Assigment_date <= currentWeekSaturday))
                    .ThenInclude(a => a.JobsCatalog)
            .ToListAsync();

            List<TechInfo> ParsedTech = technicianData.Select(item => ParseTechInfo(item)).ToList();

            report.technitians = ParsedTech;
            report.Total_Technicians = await _context.Technicians.CountAsync();
            return report;
        }
        private TechInfo ParseTechInfo(Technician tech)
        {
            int TotalPoints = tech.Assignments.Sum(x =>
                x.status_assigment == "Completado" ? x.JobsCatalog.points : 0);
            return new TechInfo
            {
                crew = tech.Quadrille.quadrille_number,
                name = $"{tech.name} {tech.last_name}",
                NumTech = tech.employee_number,
                TotalBonus= _bonusCalculator.CalculateBonus(TotalPoints),
                TotalPoints = TotalPoints,
                tasks = tech.Assignments.Select(a => new Tasks
                {
                    assigmentId = a.id,
                    assigned_date = a.Assigment_date.ToString("yyyy-MM-dd"),
                    client_address = $"{a.Subscriptor?.street} {a.Subscriptor?.street_number} {a.Subscriptor?.zone}",
                    Client_name = a.Subscriptor?.name ?? "",
                    description = a.JobsCatalog?.name ?? "",
                    points = a.status_assigment=="Completado"?a.JobsCatalog.points:0,
                    status = a.status_assigment
                }).ToList()
            };
        }
    }
}
