using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace TiendaOnlineEmanuel.API.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        public int Stock { get; set; }

        // Claves foráneas y relaciones
        public int IdCategoria { get; set; }
        public Categoria? Categoria { get; set; }

        public int IdMarca { get; set; }
        public Marca? Marca { get; set; }
    }
}
