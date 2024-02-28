
using System.ComponentModel.DataAnnotations;

namespace athena.api.Models
{
    public class Cabinete
    {
        [Key]
        public int id_cabinet { get; set; }
        public int nr_cabinet { get; set; }
        public bool? is_active { get; set; }
    }
}
