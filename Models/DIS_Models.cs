using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DIS_Models
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        public Address address { get; set; }
    }
    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
    }
}

