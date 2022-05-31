using Business.Abstract;
using Entities.Concreate;
using Entities.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerInfoController : Controller
    {
        public ICustomerInfoService _customerInfoService;

        public CustomerInfoController(ICustomerInfoService customerInfoService)
        {
            _customerInfoService = customerInfoService;
        }

        [HttpPost("save")]
        public IActionResult Save(CustomerInfoDto customerInfoDto)
        {
            var result =_customerInfoService.Add(customerInfoDto);
            return Ok(result);
        }

        [HttpPost("saveAndReturnCustomProduct")]
        public IActionResult SaveAndReturnCustomProduct(CustomerInfoDto entity)
        {
            var result = _customerInfoService.SaveAndReturnCustomProduct(entity);
            return Ok(result);
        }

    }
}
