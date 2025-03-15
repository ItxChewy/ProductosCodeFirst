using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductosCodeFirst.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        public int Precio { get; set; }
        [Required]
        public int Stock { get; set; }
    }
}
