using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DroidWeb.Data.Entities;

namespace DroidWeb.Services.Interfaces
{
    public interface IPositionService
    {
        Task<List<Position>> AcquirePosition();
    }
}
