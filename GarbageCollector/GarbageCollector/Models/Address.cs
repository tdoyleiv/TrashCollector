using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarbageCollector.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string StreetNumber { get; set; }
        public string StreetAddress { get; set; }
        public string AddressTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
    }
}