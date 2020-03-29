using System;

namespace Noordover.ResourceManagement.Domain
{
    public class ScheduleException
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}