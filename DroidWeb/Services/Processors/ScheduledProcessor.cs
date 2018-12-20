using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using NCrontab;

namespace DroidWeb.Services.Processors
{
    public abstract class ScheduledProcessor : ScopedProcessor
    {
        private CrontabSchedule schedule;
        private DateTime nextRun;

        protected abstract string Schedule { get; }

        public ScheduledProcessor(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {
            schedule = CrontabSchedule.Parse(Schedule);
            nextRun = schedule.GetNextOccurrence(DateTime.Now);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            do
            {
                var now = DateTime.Now;
                var nextrun = schedule.GetNextOccurrence(now);
                if (now > nextRun)
                {
                    await Process();
                    nextRun = schedule.GetNextOccurrence(DateTime.Now);
                }
                await Task.Delay(5000, stoppingToken); //5 seconds delay
            }
            while (!stoppingToken.IsCancellationRequested);
        }
    }
}
