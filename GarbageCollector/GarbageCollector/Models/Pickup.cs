using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarbageCollector.Models
{
    public class Pickup
    {
        public int ID { get; set; }
        public string Weekday { get; set; }
        public string SuspendUntil { get; set; }
    }
}