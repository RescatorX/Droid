using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using DroidWeb.Data;
using DroidWeb.Data.Entities;
using DroidWeb.Services.Interfaces;
using DroidWeb.Services.Processors;

namespace DroidWeb.Services
{
    public class HardwareService : ScopedProcessor, IHardwareService
    {
        protected ILogger<HardwareService> logger;
        public uint Ticks { get; set; }

        public HardwareService(IServiceScopeFactory serviceScopeFactory)
            : base(serviceScopeFactory)
        {
            this.Ticks = 100;
        }

        public override Task ProcessInScope(IServiceProvider serviceProvider)
        {
            this.logger = serviceProvider.GetRequiredService<ILogger<HardwareService>>();
            if (this.logger != null)
            {
                this.logger.LogDebug($"HardwareService.ProcessInScope: HardwareService processing starts here.");
            }
            else
            {
                Console.WriteLine($"HardwareService.ProcessInScope: HardwareService processing starts here. Warning: No logger found.");
            }

            this.Ticks++;

            if (this.dbContext != null)
            {
                List<IdentityUser> users = dbContext.Users.ToList();
            }

            return Task.CompletedTask;
        }

        public async Task<List<Module>> GetModules()
        {
            return await Task.Run(() =>
            {
                return new List<Module>();
            });
        }

        public async Task<OperationResult> NotifyModule(Module module, string message)
        {
            return await Task.Run(() =>
            { 
                return new OperationResult()
                {
                    Requested = DateTime.Now,
                    Finished = DateTime.Now,
                    Request = string.Empty,
                    Response = string.Empty,
                    Result = OperationResultType.Success
                };
            });
        }

        public async Task<OperationResult> GetModuleStatus(Module module)
        {
            return await Task.Run(() =>
            {
                return new OperationResult()
                {
                    Requested = DateTime.Now,
                    Finished = DateTime.Now,
                    Request = string.Empty,
                    Response = string.Empty,
                    Result = OperationResultType.Success
                };
            });
        }
    }
}
