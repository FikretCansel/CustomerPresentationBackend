using Business.Abstract;
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
        public ISectorService _sectorService;

        public SectorController(ISectorService sectorService)
        {
            _sectorService = sectorService;
        }


        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            
            return Ok(_sectorService.GetAll());
        }
    }
}
