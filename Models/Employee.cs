using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Garbarje.Models
{
    public class Employee 
   { [Key]
        public int EId { get; set; }
        public string EmployeeFirstName { get; set; }
         public string EmployeeLastName { get; set; }
        public int EmployeeZipcode { get; set; }

        
    
        [ForeignKey("IdentityUser")]
    public string IdentityUserId { get; set; }
    public IdentityUser IdentityUser { get; set; }

    }


    
}
