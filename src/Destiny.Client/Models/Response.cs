using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Destiny.Client.Models
{
    public class Response<T>
    {
        public T data { get; set; }
    }
}
