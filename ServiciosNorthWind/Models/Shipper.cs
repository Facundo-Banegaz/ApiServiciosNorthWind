using System.ComponentModel.DataAnnotations;

namespace ServiciosNorthWind.Models
{
    public class Shipper
    {
        [Key]
        public int ShipperID { get; set; }

        [Required(ErrorMessage ="El Nombre es obligatorio!!")]
        [StringLength(40, ErrorMessage ="Solo permite hasta 40 caracteres!!")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "El Telefono es obligatorio!!")]
        [StringLength(24, ErrorMessage = "Solo permite hasta 24 caracteres!!")]
        public string Phone { get; set; }
    }
}
