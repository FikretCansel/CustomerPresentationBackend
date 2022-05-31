using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsProductController : Controller
    {

        private IUsProductService _usProductService;


        public UsProductController(IUsProductService usProductService)
        {
            _usProductService = usProductService;
        }

        [HttpPost("getAll")]
        public IActionResult GetAll()
        {
            var result = _usProductService.GetAll();
            return Ok(result);
        }

        [HttpPost("getCustomUsProducts")]
        public IActionResult GetCustomUsProducts(int customerId)
        {
            var result = _usProductService.GetAllCustomeProducts(customerId);
            return Ok(result);
        }


    }
}
