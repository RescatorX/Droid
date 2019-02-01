using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DroidWeb.Business.Providers.Hardware.Parameters;
using DroidWeb.Data.Entities;

namespace DroidWeb.Business.Providers.Hardware
{
    public class CommunicationProvider<T> where T : ICommunication
    {
        private T Communication { get; set; }

        public CommunicationProvider()
        {
        }

        public IEnumerable<Module> GetModules()
        {
            T communication = Activator.CreateInstance<T>();
            IParameters commmParams = communication.Parameters;

            return new List<Module>();
        }
    }
}
