using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Garbarje.Models
{
    public class Client
    {[Key]
        public int CId { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientAddress { get; set; }
        public int ClientZipcode { get; set; }
        public bool HasRecycleBin { get; set; }
        public double AccountBalance { get; set; }


    }
}
