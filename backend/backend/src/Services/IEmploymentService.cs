using backend.src.DTO;

namespace backend.src.Services
{
    public interface IEmploymentService
    {
        Task<EmploymentDto> CreateEmployment(CreateEmploymentDto employmentDTO);
        Task<IEnumerable<EmploymentDto>> GetAllEmployments(PaginateProps props);
        Task<EmploymentDto> GetEmploymentById(int id);
        Task UpdateEmployment(int id, UpdateEmploymentDto employmentDTO);
        Task DeleteEmployment(int id);
        bool EmploymentExists(int id);
    }
}
