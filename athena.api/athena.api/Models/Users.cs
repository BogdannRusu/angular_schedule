
namespace athena.api.Models
{
    public class Users
    {
        public int user_id { get; set; }
        public string? name { get; set; }
        public string? password { get; set; }
        public string? email { get; set; }
        public Boolean isActive { get; set; }


    }
}
