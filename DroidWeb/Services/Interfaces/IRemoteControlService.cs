using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DroidWeb.Data;
using DroidWeb.Data.Entities;

namespace DroidWeb.Services.Interfaces
{
    public interface IRemoteControlService
    {
        OperationResult StartUp();
        OperationResult ShutDown();

        OperationResult FreezeAll();
        OperationResult FreezeModule(Module module);

        OperationResult GetRemoteControlsStatus();
    }
}
