using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class SectorController : Controller
    {
       

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            
            return Ok("Hello world");
        }
    }
}
