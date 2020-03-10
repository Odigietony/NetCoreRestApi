using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspRestApiWithJWT.Controllers
{
    [Route("api/string_info")]
    [ApiController]
    public class GetStringInfoController : ControllerBase
    {
        [HttpGet(Name = "StringInfo")]
        public string StringInfo()
        {
            return "Welcome from string info";
        }
    }
}