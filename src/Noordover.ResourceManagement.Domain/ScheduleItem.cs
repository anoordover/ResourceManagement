using System;

namespace Noordover.ResourceManagement.Domain
{
    public class ScheduleItem
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public ScheduleStatus Status { get; set; }
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public TimeSpan Duration => EndDateTime.Subtract(StartDateTime);
    }
}