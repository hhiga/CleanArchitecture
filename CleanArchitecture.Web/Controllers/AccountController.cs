using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {        
        public AccountController()
        {

        }
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok("Ok");
        }
    }
}
