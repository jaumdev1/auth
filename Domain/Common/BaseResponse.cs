using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Common
{
    public class BaseResponse<T>
    {
        public BaseResponse(T data)
        {
            Data = data;
        }

        public BaseResponse(Error error)
        {
            Data = default;
            Error = error;
        }

        public T? Data { get; set; }
        public Error Error { get; set; }
    }
}
