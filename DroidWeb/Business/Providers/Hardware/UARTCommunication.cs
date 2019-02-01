using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DroidWeb.Business.Providers.Hardware.Parameters;
using DroidWeb.Data.Abilities;
using DroidWeb.Data.Enums;

namespace DroidWeb.Business.Providers.Hardware
{
    public class UARTCommunication : IUARTCommunication
    {
        public CommunicationType Type { get; set; }
        public CommunicationProviderType ProviderType { get; set; }
        public IParameters Parameters { get; set; }
    }
}
