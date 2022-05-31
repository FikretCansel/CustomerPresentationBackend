using Business.Utilities.Results;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUsProductImageService
    {
        //FileHelper.AddAsync(file);

        DataResult<List<UsProductImage>> GetAll();
        Result Add(IFormFile file, UsProductImage usProductImage);
        Result Update(IFormFile file, UsProductImage usProductImage);
        Result Delete(UsProductImage usProductImage);
        DataResult<List<UsProductImage>> GetAllByUsProductId(int usProductId);
    }
}
