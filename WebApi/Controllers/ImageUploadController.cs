using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ImageUploadController : Controller
    {
        IUsProductImageService _ImageService;
        public ImageUploadController(IUsProductImageService ImageService)
        {
            _ImageService = ImageService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _ImageService.GetAll();
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] UsProductImage usProduct)
        {
            var result = _ImageService.Add(file, usProduct);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(UsProductImage carImage)
        {
            var result = _ImageService.Delete(carImage);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm] UsProductImage usProductImage)
        {
            var result = _ImageService.Update(file, usProductImage);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getAllByUsProductId")]
        public IActionResult GetAllByUsProductId(int usProductId)
        {
            var result = _ImageService.GetAllByUsProductId(usProductId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
