using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloEmpty.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloEmpty.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public List<HelloMessage> Get()
        {
            List<HelloMessage> messages = new List<HelloMessage>();
            messages.Add(new HelloMessage() { Message = "Hello Web api1" });
            messages.Add(new HelloMessage() { Message = "Hello Web api2" });
            messages.Add(new HelloMessage() { Message = "Hello Web api3" });

            return messages;
        }
    }
}
