using System.ComponentModel.DataAnnotations;

namespace backend.src.DTO
{
    public class PaginateProps
    {
        [Range(1, int.MaxValue, ErrorMessage = "El número de página debe ser mayor a 0.")]
        public int PageNumber { get; set; } = 1;

        [Range(1, 100, ErrorMessage = "El tamaño de página debe estar entre 1 y 100.")]
        public int PageSize { get; set; } = 10;

        [RegularExpression("id|name|lastname", ErrorMessage = "El campo 'SortBy' solo puede ser 'id', 'name' o 'lastname'.")]
        public string SortBy { get; set; } = "id";

    }
}
