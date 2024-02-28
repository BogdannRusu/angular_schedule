
using System.ComponentModel.DataAnnotations;

namespace athena.api.Models
{
    public class Grupe
    {
        [Key]
        public int id_grupa { get; set; }
        public string nume_grupa { get; set; } = null!;
        public Boolean is_active { get; set; }
        public int anul { get; set; }
        public int id_link { get; set; }

    }
}
