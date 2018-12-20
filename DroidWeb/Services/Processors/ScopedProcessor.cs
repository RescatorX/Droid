using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using DroidWeb.Data;

namespace DroidWeb.Services.Processors
{
    public abstract class ScopedProcessor : BackgroundService
    {
        private readonly IServiceScopeFactory serviceScopeFactory;
        protected ApplicationDbContext dbContext;

        public ScopedProcessor(IServiceScopeFactory serviceScopeFactory)
            : base()
        {
            this.serviceScopeFactory = serviceScopeFactory;
        }

        protected override async Task Process()
        {
            using (var scope = serviceScopeFactory.CreateScope())
            {
                this.dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                await ProcessInScope(scope.ServiceProvider);
            }
        }

        public abstract Task ProcessInScope(IServiceProvider serviceProvider);
    }
}
