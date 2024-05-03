using System.ComponentModel.DataAnnotations;

namespace ServiciosNorthWind.Models
{
    public class Region
    {
        [Key]
        public int RegionID { get; set; }

        [Required(ErrorMessage = "La Descripcion de la Region es obligatorio!!")]
        [StringLength(50, ErrorMessage = "Solo permite hasta 50 caracteres!!")]
        public string RegionDescription { get; set; }

    }
}
