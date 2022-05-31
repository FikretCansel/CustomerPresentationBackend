using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagController : Controller
    {
        public ITagService _tagService; 
        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet("getAllSectors")]
        public IActionResult GetAllSectors()
        {
            
            return Ok(_tagService.GetAllSectors());
        }

        [HttpGet("getAllProductTagsByProductId")]
        public IActionResult GetAllSectors(int productId)
        {

            return Ok(_tagService.GetAllProductTagsByProductId(productId));
        }
        //[HttpPost("getAllTypeOfNeed")]
        //public IActionResult GetAllTypeOfNeed()
        //{

        //    return Ok(result);
        //}
        //[HttpPost("getAllCustomerType")]
        //public IActionResult getAllCustomerType()
        //{

        //    return Ok(result);
        //}


    }
}
