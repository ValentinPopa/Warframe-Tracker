#nullable disable warnings
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class WarframePart
    {
        [Key]
        public int id_warframePart { get; set; }
        public String warframe_name { get; set; }
        public bool warframe_blueprint_owned { get; set; }
        public bool warframe_chassis_owned { get; set; }
        public bool warframe_neuroptics_owned { get; set; }
        public bool warframe_system_owned { get; set; }
        public bool warframe_blueprint_crafted { get; set; }
        public bool warframe_chassis_crafted { get; set; }
        public bool warframe_neuroptics_crafted { get; set; }
        public bool warframe_system_crafted { get; set; }
    }
}
