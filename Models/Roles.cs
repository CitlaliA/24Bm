using System.ComponentModel.DataAnnotations;

namespace proyecto_24bm.Models
{
    public class Roles
    {
        [Key]
        public int PkRol { get; set; }
        public string Name { get; set; }
    }
}
