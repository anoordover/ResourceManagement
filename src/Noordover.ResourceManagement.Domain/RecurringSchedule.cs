using System;
using System.Collections.Generic;

namespace Noordover.ResourceManagement.Domain
{
    public class RecurringSchedule
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public ScheduleStatus Status { get; set; }
        public string CronPattern { get; set; }
        public DateTime MinStartDateTime { get; set; }
        public DateTime MaxEndDateTime { get; set; }
        public IList<(DateTime start, DateTime end)> ScheduleExceptions { get; set; }
    }
}