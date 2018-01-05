using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TrashCollector.Models
{
    public class Address
    {
        public int ID { get; set; }
        public int StreetNumber { get; set; }
        public string StreetAddress { get; set; }
        public string AddressTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZIP { get; set; }
    }
    public class AddressDBContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
    }
}