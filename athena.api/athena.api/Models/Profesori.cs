
namespace athena.api.Models
{
    public class Profesori
    {
        public int IdProf { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Patronimic { get; set; }
        public DateTime DataActivarii { get; set; }
        public DateTime DataIncheierii { get; set; }
        public Boolean isActive { get; set; }
        public string Functia { get; set; }


    }
}
