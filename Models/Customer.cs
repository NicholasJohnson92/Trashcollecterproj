using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Garbarje.Models
{
    public class Customer
    {[Key]
        public int CId { get; set; }
        public string CusFirstName { get; set; }
        public string CusLastName { get; set; }
        public string CusAddress { get; set; }
        public int CusZipcode { get; set; }
        public string PickupDay { get; set; }
        public bool HasRecycleBin { get; set; }
        public double AccountBalance { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

       /* public static readonly IEnumerable<List<string>> list = new IEnumerable<List<string>>() { "Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saturday", "Sunday" };
        */

    }
}
