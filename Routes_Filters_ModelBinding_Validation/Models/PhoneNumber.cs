using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routes_Filters_ModelBinding_Validation.Models
{
    public class PhoneNumber
    {
        public class Phone
        {
            public string Type { get; set; }
            public string PhoneNumber { get; set; }
            public bool IsEvening { get; set; }
        }
    }
}
