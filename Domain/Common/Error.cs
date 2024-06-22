using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class Error
    {
        public static readonly Error None = new(HttpStatusCode.Continue, string.Empty);

        public Error(HttpStatusCode httpStatusCode, string message)
        {
            StatusCode = (int)httpStatusCode;
            Message = message;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
