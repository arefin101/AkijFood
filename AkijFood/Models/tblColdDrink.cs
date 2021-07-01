using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AkijFood.Models
{
    public class tblColdDrink
    {
        [Key, Required]
        public int intColdDrinksId { get; set; }
        public string strColdDrinksName { get; set; }
        public float numQuantity { get; set; }
        public float numUnitPrice { get; set; }
    }
}
