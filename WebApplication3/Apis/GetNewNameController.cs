using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Apis
{
    public class GetNewNameController : ApiController
    {
        
        
        public string GetName()
        {
            return "name=derek";
        }
    }
}
