using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Destiny.Client
{
    public class ModelFactory
    {
        public static T Deserialize<T>(string jsonString)
        {
            var result = JsonConvert.DeserializeObject<T>(jsonString);
            return result;
        }
    }
}
