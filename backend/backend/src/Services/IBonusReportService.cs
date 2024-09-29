using backend.src.DTO;

namespace backend.src.Services
{
    public interface IBonusReportService
    {
         Task<BonusReport> GetBonusReport(PaginateProps props,int search);
        Task<BonusReport.TechInfo> GetBonusReportById(int techNumber);
        //Task<BonusReport> GetFullReport();
    }
}
