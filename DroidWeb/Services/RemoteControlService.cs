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
    public class RemoteControlService : ScopedProcessor, IRemoteControlService
    {
        private const int SERVICE_LOOP_MILLISECONDS = 5000; // 5 seconds delay

        public RemoteControlService(IServiceScopeFactory serviceScopeFactory)
            : base(serviceScopeFactory)
        {
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            do
            {
                await Process();

                await Task.Delay(SERVICE_LOOP_MILLISECONDS, stoppingToken);
            }
            while (!stoppingToken.IsCancellationRequested);
        }

        public override Task ProcessInScope(IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }

        public OperationResult FreezeAll()
        {
            return new OperationResult()
            {
                Requested = DateTime.Now,
                Finished = DateTime.Now,
                Request = string.Empty,
                Response = string.Empty,
                Result = OperationResultType.Success
            };
        }

        public OperationResult FreezeModule(Module module)
        {
            return new OperationResult()
            {
                Requested = DateTime.Now,
                Finished = DateTime.Now,
                Request = string.Empty,
                Response = string.Empty,
                Result = OperationResultType.Success
            };
        }

        public OperationResult GetRemoteControlsStatus()
        {
            return new OperationResult()
            {
                Requested = DateTime.Now,
                Finished = DateTime.Now,
                Request = string.Empty,
                Response = string.Empty,
                Result = OperationResultType.Success
            };
        }

        public OperationResult ShutDown()
        {
            return new OperationResult()
            {
                Requested = DateTime.Now,
                Finished = DateTime.Now,
                Request = string.Empty,
                Response = string.Empty,
                Result = OperationResultType.Success
            };
        }

        public OperationResult StartUp()
        {
            return new OperationResult()
            {
                Requested = DateTime.Now,
                Finished = DateTime.Now,
                Request = string.Empty,
                Response = string.Empty,
                Result = OperationResultType.Success
            };
        }
    }
}
