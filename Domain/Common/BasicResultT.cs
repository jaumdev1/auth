using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class BasicResult<TValue>(TValue? value, bool isSucess, Error error)
      : BasicResult(isSucess, error)
    {
        public TValue Value { get; set; } = value!;

        public static implicit operator BasicResult<TValue>(TValue? value)
        {
            return Create(value);
        }
    }
}
