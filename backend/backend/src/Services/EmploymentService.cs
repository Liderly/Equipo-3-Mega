using backend.Models;
using backend.src.DTO;
using backend.src.Models;
using Backend.Context;
using Microsoft.EntityFrameworkCore;

namespace backend.src.Services
{
    public class EmploymentService : IEmploymentService
    {
        private readonly ContextDB _Context;

        public EmploymentService(ContextDB contextDB)
        {
            _Context= contextDB;
        }

        public async Task<EmploymentDto> CreateEmployment(CreateEmploymentDto employmentDTO)
        {
            Technician technician = new Technician
            {
                quadrille_id = employmentDTO.quadrille_id,
                name = employmentDTO.name,
                last_name = employmentDTO.last_name,
                phone = employmentDTO.phone,
                employee_number = employmentDTO.employee_number
            };
            User u = new User
            {
                num_emp = technician.employee_number,
                email = employmentDTO.email,
                password = employmentDTO.password,
                role = employmentDTO.role
            };
            _Context.Users.Add(u);
            _Context.Technicians.Add(technician);
            await _Context.SaveChangesAsync(true);
            var tech = await _Context.Technicians
            .Include(t => t.Quadrille)
            .FirstOrDefaultAsync(t => t.id == technician.id);
            EmploymentDto employment = new EmploymentDto
            {
                Id = technician.id,
                quadrille_id = technician.quadrille_id,
                Quadrille_Num = tech.Quadrille.quadrille_number,
                name = technician.name,
                last_name = technician.last_name,
                phone = technician.phone,
                employee_number = technician.employee_number
            };

            return employment;
        }

        public async Task DeleteEmployment(int id)
        {
            // Busca el técnico por ID de forma asíncrona
            var technician = await _Context.Technicians.FindAsync(id);

            // Verifica si el técnico existe
            if (technician == null)
            {
                throw new Exception($"Tecnico con id: {id}  no encontrado");
            }

            // Remueve el técnico
            _Context.Technicians.Remove(technician);

            // Guarda los cambios en la base de datos
            await _Context.SaveChangesAsync(true);
        }

        public async Task<IEnumerable<EmploymentDto>> GetAllEmployments(PaginateProps props)
        {
            var technicians = await _Context.Technicians
                .Skip((props.PageNumber-1)*props.PageSize)
                .Take(props.PageSize)
                .OrderBy(f=>f.id)
                .Include(t => t.Quadrille)
                .Select(t => new EmploymentDto
                {
                    Id = t.id,
                    quadrille_id = t.quadrille_id,
                    Quadrille_Num = t.Quadrille.quadrille_number,
                    name = t.name,
                    last_name = t.last_name,
                    phone = t.phone,
                    employee_number = t.employee_number
                }).ToListAsync();
            return technicians;
        }

        public async Task<EmploymentDto> GetEmploymentById(int id)
        {
            try
            {
                var technician = await _Context.Technicians
                    .Include(t => t.Quadrille)
                    .Where(t => t.id == id)
                    .Select(t => new EmploymentDto
                    {
                        Id = t.id,
                        Quadrille_Num = t.Quadrille.quadrille_number,
                        quadrille_id = t.quadrille_id,
                        name = t.name,
                        last_name = t.last_name,
                        phone = t.phone,
                        employee_number = t.employee_number
                    })
                    .FirstOrDefaultAsync();

                if (technician == null)
                {
                    throw new KeyNotFoundException($"Tecnico con Id {id} no encontrado.");
                }

                return technician;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public async Task UpdateEmployment(int id, UpdateEmploymentDto employmentDTO)
        {
            try 
            {
                var technician = await _Context.Technicians.FindAsync(id);
                if (technician == null)
                {
                    // Manejar el caso en que el técnico no se encuentre
                    throw new KeyNotFoundException($"Technician with Id {id} not found.");
                }
                // Actualizar los campos del técnico
                technician.quadrille_id = employmentDTO.quadrille_id;
                technician.name = employmentDTO.name;
                technician.last_name = employmentDTO.last_name;
                technician.phone = employmentDTO.phone;
                await _Context.SaveChangesAsync(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        public bool EmploymentExists(int id)
        {
            return _Context.Technicians.Any(e => e.id == id);
        }
    }
}