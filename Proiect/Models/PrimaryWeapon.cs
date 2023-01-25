#nullable disable warnings
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PrimaryWeapon
    {
        internal string secondaryWeapon_name;

        [Key]
        public int id_primaryWeapon { get; set; }
        public string primaryWeapon_name { get; set; }
        public bool crafted { get; set; }
    }
}
