using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena_Solution.DTO
{
    public  class UsersDTO
    {
        public int user_id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool? is_active { get; set; }
    }
}
