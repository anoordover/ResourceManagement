using System;
using System.Collections.Generic;

namespace Noordover.ResourceManagement.Domain
{
    public class Schedule
    {
        public int Id { get; set; }
        public IList<ScheduleItem> ScheduleItems { get; set; }
        public IList<RecurringSchedule> RecurringSchedules { get; set; }
        public IList<(DateTime start, DateTime end)> ScheduleExceptions { get; set; }
    }

    public class TimeSlot
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public ScheduleStatus Status { get; set; }
    }
}