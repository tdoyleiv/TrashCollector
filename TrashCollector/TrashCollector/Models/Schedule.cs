using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Schedule
    {
        public int ID { get; set; }
        public bool isPickupMonday { get; set; }
        public bool isPickupTuesday { get; set; }
        public bool isPickupWednesday { get; set; }
        public bool isPickupThursday { get; set; }
        public bool isPickupFriday { get; set; }
        public bool isPickupSaturday { get; set; }
    }
    public class ScheduleDBContext : DbContext
    {
        public DbSet<Schedule> Schedules { get; set; }
    }
}