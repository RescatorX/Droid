using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using DroidWeb.Data.Entities;
using DroidWeb.Data.Enums;
using DroidWeb.Services.Interfaces;
using DroidWeb.Services.Processors;

namespace DroidWeb.Services
{
    public class PositionService : ScopedProcessor, IPositionService
    {
        public PositionService(IServiceScopeFactory serviceScopeFactory)
            : base(serviceScopeFactory)
        {
        }

        public override Task ProcessInScope(IServiceProvider serviceProvider)
        {
            Console.WriteLine("PositionService processing starts here");
            return Task.CompletedTask;
        }

        public async Task<List<Position>> AcquirePosition()
        {
            return await Task.Run(() =>
            {
                return new List<Position>()
                {
                    new Position(new HWModule("Module1", "ModuleType1", "Nova Robotics"), PositionProviderType.GPS, true, 16.206, 50.101, 0.154, 5.1, 4.2),
                    new Position(new HWModule("Module2", "ModuleType2", "Nova Robotics"), PositionProviderType.GSM, true, 16.252, 50.153, 0.105, 6.3),
                    new Position(new HWModule("Module3", "ModuleType3", "Nova Robotics"), PositionProviderType.Glonass, false, 16.225, 50.115, 0.010, 2.1),
                };
            });
        }
    }
}
