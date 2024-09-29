using backend.Models;
using backend.src.DTO;
using Backend.Context;
using Backend.DTO;
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

        public async Task<AssignmentDto> CreateTask(CreateTaskDto task)
        {
            var newAssignment = new Assignment
            {
                service_id = task.service_id,
                technician_id = task.technician_id,
                subscriber_id = task.subscriber_id
            };

            _context.Assignments.Add(newAssignment);
            await _context.SaveChangesAsync();

            var createdAssignment = await _context.Assignments
    .Include(x => x.Technician)
        .ThenInclude(x => x.Quadrille)
    .Include(x => x.Subscriptor)
    .Include(x => x.JobsCatalog)
    .Select(a => new AssignmentDto
    {
        Id = a.id,
        Technician = new TechnicianDto
        {
            Name = a.Technician.name,
            LastName = a.Technician.last_name,
            QuadrilleNumber = a.Technician.Quadrille.quadrille_number
        },
        Subscriptor = new SubscriptorDto
        {
            LastName = a.Subscriptor.last_name,
            Name = a.Subscriptor.name,
            Street = a.Subscriptor.street,
            Number = a.Subscriptor.number,
            PostCode = a.Subscriptor.post_code,
            Zone = a.Subscriptor.zone
        },
        JobsCatalog = new JobsCatalogDto
        {
            Id = a.JobsCatalog.id,
            Name = a.JobsCatalog.name,
            Description = a.JobsCatalog.description
        }
    })
    .FirstOrDefaultAsync(x => x.Id == newAssignment.id);
            if (createdAssignment == null)
            {
                throw new Exception("No se pudo crear la tarea. Por favor, inténtelo de nuevo.");
            }

            return createdAssignment;
        }

        public async Task<Assignment> DeleteTask(int id)
        {
            var task = await _context.Assignments
                 .Include(x => x.Technician)
                    .ThenInclude(x=>x.Quadrille)
                 .Include(x => x.Subscriptor)
                 .Include(x => x.JobsCatalog)
                 .FirstOrDefaultAsync(x => x.id == id);

            if (task == null)
            {
                throw new Exception($"No se encontró ninguna tarea con el ID {id}.");
            }

            _context.Assignments.Remove(task);
            await _context.SaveChangesAsync();

            return task;
        }

        public async Task<AssignmentDto> UpdateTask(int id, UpdateTaskDto taskDto)
        {
            var task = await _context.Assignments.FindAsync(id);
            if (task == null)
            {
                throw new Exception($"No se encontró ninguna tarea con el ID {id}.");
            }
            if (taskDto.service_id > 0)
                task.service_id = taskDto.service_id;
            if (taskDto.technician_id > 0)
                task.technician_id = taskDto.technician_id;
            if (taskDto.subscriber_id > 0)
                task.subscriber_id = taskDto.subscriber_id;
            if (!string.IsNullOrEmpty(taskDto.status))
                task.status_assigment = taskDto.status;
            //En caso de que se marque como completada en automatico se asigna una fecha de finalizacion
            if (task.status_assigment == "Completado")
            {
                task.Finish_date = DateTime.Now;
            }
            await _context.SaveChangesAsync();
            var updatedTask = await _context.Assignments
                .Include(x => x.Technician)
                    .ThenInclude(x=>x.Quadrille)
                .Include(x => x.Subscriptor)
                .Include(x => x.JobsCatalog)
                .Select(a => new AssignmentDto
                {
                    Id = a.id,
                    Technician = new TechnicianDto
                    {
                        Name = a.Technician.name,
                        LastName = a.Technician.last_name,
                        QuadrilleNumber = a.Technician.Quadrille.quadrille_number
                    },
                    Subscriptor = new SubscriptorDto
                    {
                        LastName = a.Subscriptor.last_name,
                        Name = a.Subscriptor.name,
                        Street = a.Subscriptor.street,
                        Number = a.Subscriptor.number,
                        PostCode = a.Subscriptor.post_code,
                        Zone = a.Subscriptor.zone
                    },
                    JobsCatalog = new JobsCatalogDto
                    {
                        Id = a.JobsCatalog.id,
                        Name = a.JobsCatalog.name,
                        Description = a.JobsCatalog.description
                    }
                })
             .FirstOrDefaultAsync(x => x.Id == id);

            return updatedTask;
        }
    }
}