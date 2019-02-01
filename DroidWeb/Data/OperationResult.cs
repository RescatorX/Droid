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

        public OperationResult()
        {
            this.Result = OperationResultType.Unknown;
            this.Request = null;
            this.Response = null;
            this.Requested = DateTime.Now;
            this.Finished = null;
        }

        public OperationResult(OperationResultType result)
            : this()
        {
            this.Result = result;
        }

        public OperationResult(OperationResultType result, string request, string response, DateTime requested, DateTime? finished)
            : this(result)
        {
            this.Request = request;
            this.Response = response;
            this.Requested = requested;
            this.Finished = finished;
        }
    }
}
