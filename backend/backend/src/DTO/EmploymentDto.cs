using backend.Models;
using System.ComponentModel.DataAnnotations;

namespace backend.src.DTO
{
    public class CreateEmploymentDto
    {
        [Required(ErrorMessage = "El ID de cuadrilla es obligatorio")]
        public int quadrille_id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres")]
        public string name { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El apellido debe tener entre 2 y 100 caracteres")]
        public string last_name { get; set; }

        [Required(ErrorMessage = "El número de teléfono es obligatorio")]
        [Range(1000000000, 9999999999, ErrorMessage = "El número de teléfono debe tener 10 dígitos")]
        public long phone { get; set; }

        [Required(ErrorMessage = "El número de empleado es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de empleado debe ser un número positivo")]
        public int employee_number { get; set; }
    }

    public class UpdateEmploymentDto
    {
        [Required(ErrorMessage = "El ID de cuadrilla es obligatorio")]
        public int quadrille_id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres")]
        [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "El nombre solo puede contener letras y espacios")]
        public string name { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El apellido debe tener entre 2 y 100 caracteres")]
        [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "El nombre solo puede contener letras y espacios")]
        public string last_name { get; set; }

        [Required(ErrorMessage = "El número de teléfono es obligatorio")]
        [Range(1000000000, 9999999999, ErrorMessage = "El número de teléfono debe tener 10 dígitos")]
        public long phone { get; set; }
    }

    public class EmploymentDto : CreateEmploymentDto
    {
        [Required(ErrorMessage = "El ID es obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El número de cuadrilla es obligatorio")]
        public int Quadrille_Num { get; set; }
    }
}