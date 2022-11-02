using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto_24bm.Models
{
    public class Usuario
    {
        [Key]
        public int PkUsuario { get; set; }
        public string Name { get; set; }
        public string user { get; set; }
        public string Password { get; set; }

        [ForeignKey("Roles")]
        public int FkRol { get; set; }
        public Roles Roles { get; set; }
    }
}
