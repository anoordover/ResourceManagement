using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Logging;
using Noordover.ResourceManagement.Domain;
using Xunit;

namespace Test.Scheduling.ScheduleManager.GivenSimpleRecurringSchedule
{
    public class WhenExpandingSchedule
    {
        private readonly ILoggerFactory _LoggerFactory;
        private Schedule _MySchedule = new Schedule {
            RecurringSchedules = new List<RecurringSchedule> {
                new RecurringSchedule {
                    MinStartDateTime = new DateTime(2019, 5, 1),
                    MaxEndDateTime = new DateTime(2019, 5, 31),
                    CronPattern = "0 15 * * 1",
                    Duration = TimeSpan.FromHours(1)
                }
            }
        };

        public WhenExpandingSchedule()
        {
				
            _LoggerFactory = LoggerFactory.Create(config => {
                config.SetMinimumLevel(LogLevel.Trace)
                    .AddConsole();
            });

        }

        [Fact]
        public void ShouldExpandWithinDelimitedDatesOnly()
        {

            // arrange

            // act
            var sut = new Noordover.ResourceManagement.Scheduling.ScheduleManager();
            var results = sut.ExpandSchedule(_MySchedule, new DateTime(2019, 1, 1), new DateTime(2019, 12, 31));

            // assert
            Assert.Equal(4, results.Count());
            Assert.Equal(15, results.First().StartDateTime.Hour);

        }

        [Fact]
        public void ShouldExpandWithinRequestedDatesOnly()
        {

            // arrange

            // act
            var sut = new Noordover.ResourceManagement.Scheduling.ScheduleManager();
            var results = sut.ExpandSchedule(_MySchedule, new DateTime(2019, 5, 1), new DateTime(2019, 5, 15), _LoggerFactory.CreateLogger("test"));

            // assert
            Assert.Equal(2, results.Count());
            Assert.Equal(15, results.First().StartDateTime.Hour);

        }

    }
}