using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using DroidWeb.Data;
using DroidWeb.Data.Entities;
using DroidWeb.Services.Interfaces;
using DroidWeb.Services.Processors;

namespace DroidWeb.Services
{
    public class HardwareService : ScopedProcessor, IHardwareService
    {
        public uint Ticks { get; set; }

        public HardwareService(IServiceScopeFactory serviceScopeFactory)
            : base(serviceScopeFactory)
        {
            this.Ticks = 100;
        }

        public override Task ProcessInScope(IServiceProvider serviceProvider)
        {
            Console.WriteLine("HWService processing starts here");

            this.Ticks++;

            return Task.CompletedTask;
        }

        public async Task<List<HWModule>> GetModules()
        {
            return await Task.Run(() =>
            {
                return new List<HWModule>();
            });
        }

        public async Task<OperationResult> NotifyModule(HWModule module, string message)
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

        public async Task<OperationResult> GetModuleStatus(HWModule module)
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
