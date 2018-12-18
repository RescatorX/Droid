using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DroidWeb.Data;
using DroidWeb.Data.Entities;

namespace DroidWeb.Services.Interfaces
{
    public interface IHardwareService
    {
        uint Ticks { get; set; }

        Task<List<HWModule>> GetModules();
        Task<OperationResult> NotifyModule(HWModule module, string message);
        Task<OperationResult> GetModuleStatus(HWModule module);
    }
}
