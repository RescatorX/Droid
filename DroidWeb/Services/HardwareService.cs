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
using DroidWeb.Business.Providers.Hardware;

namespace DroidWeb.Services
{
    public class HardwareService : ScopedProcessor, IHardwareService
    {
        private ILogger<HardwareService> Logger;
        private List<Module> Modules;

        public HardwareService(IServiceScopeFactory serviceScopeFactory)
            : base(serviceScopeFactory)
        {
            this.LoopDelay = 2000;
        }

        public override Task ProcessInScope(IServiceProvider serviceProvider)
        {
            this.Logger = serviceProvider.GetRequiredService<ILogger<HardwareService>>();
            if (this.Logger != null)
            {
                this.Logger.LogDebug($"HardwareService.ProcessInScope: HardwareService processing starts here.");
            }
            else
            {
                Console.WriteLine($"HardwareService.ProcessInScope: HardwareService processing starts here. Warning: No logger found.");
            }

            return Task.CompletedTask;
        }

        public async Task<List<Module>> GetModules(bool refresh = false)
        {
            return await Task.Run(() =>
            {
                if (refresh)
                {
                    ObtainModules();
                }

                return this.Modules;
            });
        }

        public async Task<OperationResult> NotifyModule(Module module, string message)
        {
            return await Task.Run(() =>
            {
                return new OperationResult(OperationResultType.Success, string.Empty, string.Empty, DateTime.Now, DateTime.Now);
            });
        }

        public async Task<OperationResult> GetModuleStatus(Module module)
        {
            return await Task.Run(() =>
            {
                return new OperationResult(OperationResultType.Success, string.Empty, string.Empty, DateTime.Now, DateTime.Now);
            });
        }

        private void ObtainModules()
        {
            this.Modules = new List<Module>();

            CommunicationProvider<IUARTCommunication> uartCommProvider = new CommunicationProvider<IUARTCommunication>();
            this.Modules.AddRange(uartCommProvider.GetModules());
        }
    }
}
