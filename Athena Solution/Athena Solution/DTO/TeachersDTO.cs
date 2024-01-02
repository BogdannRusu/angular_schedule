using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena_Solution.DTO
{
    public class TeachersDTO
    {
        public int id_prof { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string patronimic { get; set; }
        public DateTime data_activarii { get; set; }
        public DateTime data_end_activarii { get; set; }
        public bool is_active { get; set; }
        public string profesie { get; set; }
    }
}
