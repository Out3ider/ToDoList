using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Apis
{
    public class TestController : ApiController
    {
        [HttpGet]
        [HttpPost]
        public string Get()
        {
            return "Test";
        }
        [HttpGet]
        [HttpPost]
        public KeyValuePair<string,string> Test()
        {
            return new KeyValuePair<string, string>("aaa", "bbb");
        }
    }
}
