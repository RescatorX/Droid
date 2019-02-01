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
        Task<List<Module>> GetModules(bool refresh = false);
        Task<OperationResult> NotifyModule(Module module, string message);
        Task<OperationResult> GetModuleStatus(Module module);
    }
}
