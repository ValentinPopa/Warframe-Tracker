#nullable disable warnings
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MeleeWeapon
    {
        [Key]
        public int id_meleeWeapon { get; set; }
        public string meleeWeapon_name { get; set; }
        public bool crafted { get; set; }
    }
}
