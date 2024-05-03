using System.ComponentModel.DataAnnotations;

namespace ServiciosNorthWind.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "El Nombre de la Categoria  es obligatorio!!")]
        [StringLength(15, ErrorMessage = "Solo permite hasta 15 caracteres!!")]
        public string CategoryName { get; set; }

        public string? Description { get; set; }

        public byte[]? Picture {  get; set; }
    }
}
