#nullable disable warnings
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SecondaryWeapon
    {
        [Key]
        public int id_secondaryWeapon { get; set; }
        public string secondaryWeapon_name { get; set; }
        public bool crafted { get; set; }
    }
}
