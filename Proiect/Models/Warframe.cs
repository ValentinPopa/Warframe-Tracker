#nullable disable warnings
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Warframe
    {
        [Key]
        public int id_warframe { get; set; }
        public string warframe_name { get; set; }
        public bool crafted { get; set; }

    }
}
