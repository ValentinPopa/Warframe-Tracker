#nullable disable warnings
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Relic
    {
        [Key]
        public int id_relic { get; set; }
        public String relic_name { get; set; }
        public String common_1 { get; set; }
        public String common_2 { get; set; }
        public String common_3 { get; set; }
        public String uncommon_1 { get; set; }
        public String uncommon_2 { get; set; }
        public String rare_1 { get; set; }
    }
}
