using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DroidWeb.Business.Providers.Hardware.Parameters;
using DroidWeb.Data.Abilities;
using DroidWeb.Data.Enums;

namespace DroidWeb.Business.Providers.Hardware
{
    public interface ICommunication
    {
        CommunicationType Type { get; set; }
        CommunicationProviderType ProviderType { get; set; }
        IParameters Parameters { get; set; }
    }
}
