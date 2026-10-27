using System.ComponentModel.DataAnnotations;

namespace TiendaOnlineEmanuel.API.Models
{
    public class Marca
    {
        [Key]
        public int IdMarca { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        // Propiedad de navegación
        //public ICollection<Producto>? Productos { get; set; }
    }
}
