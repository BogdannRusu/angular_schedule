using Athena_Solution.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena_Solution.DTO
{
    public class GroupsDTO
    {
        public int id_grupa { get; set; }
        public string nume_grupa { get; set; }
        public bool? is_active {  get; set; }
        public int anul { get; set; }
        public int id_link { get; set; }
    }
}
