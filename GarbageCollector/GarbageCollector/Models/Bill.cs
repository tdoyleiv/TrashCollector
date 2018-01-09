using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarbageCollector.Models
{
    public class Bill
    {
        [Key]
        public int ID { get ; set; }
        public int Amount { get ; set; }
        public string PaymentMethod { get; set; }
    }
}