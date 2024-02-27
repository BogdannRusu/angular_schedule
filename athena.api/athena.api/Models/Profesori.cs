using System.ComponentModel.DataAnnotations;

namespace athena.api.Models
{
    public class Profesori
    {
        // Definirea cheii primare
        [Key]
        public int id_prof { get; set; }
        public string? Nume { get; set; }
        public string? Prenume { get; set; }
        public string? Patronimic { get; set; }
        public DateTime? data_activarii { get; set; }
        public DateTime? end_data_activarii { get; set; }
        public bool? is_active { get; set; }
        public string? Functia { get; set; }

        
    }

}
