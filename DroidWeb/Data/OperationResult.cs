using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DroidWeb.Data
{
    public class OperationResult
    {
        public DateTime Requested { get; set; }
        public DateTime? Finished { get; set; }
        public OperationResultType Result { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
    }
}
