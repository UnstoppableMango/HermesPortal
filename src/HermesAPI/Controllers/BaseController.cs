using Destiny.Client;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HermesAPI.Controllers
{
    public class BaseController : Controller
    {
        protected readonly DestinyClient _destinyClient;

        public BaseController()
        {
            _destinyClient = new DestinyClient(new DestinyClientConfiguration { apiKey = "3b67f3ff34eb4138a4b41149b8c8227f" });
        }
    }
}
