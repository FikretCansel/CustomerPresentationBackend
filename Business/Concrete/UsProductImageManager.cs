using Business.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Business.Abstract;
using Entities.Concreate;
using DataAccess.Abstract;
using Business.Utilities.FileHelper;

namespace Business.Concrete
{
    public class UsProductImageManager : IUsProductImageService
    {
        public IUsProductImageDal _usProductImageDal;
        public UsProductImageManager(IUsProductImageDal usProductImageDal)
        {
            _usProductImageDal = usProductImageDal;
        }
        

        public Result Add(IFormFile file, UsProductImage usProduct)
        {
            usProduct.ImagePath = FileHelper.AddAsync(file);
            usProduct.DateTime = DateTime.Now;
            _usProductImageDal.Add(usProduct);
            return new Result { isSuccess = true };
        }

        public Result Delete(UsProductImage usProductImage)
        {
            _usProductImageDal.Delete(usProductImage);
            return new Result { isSuccess = true };
        }

        public DataResult<List<UsProductImage>> GetAllByUsProductId(int usProductId)
        {
            var usProductImage=_usProductImageDal.GetAll(x=>x.UsProductId==usProductId);
            return new DataResult<List<UsProductImage>> { isSuccess = true,Data=usProductImage };
        }

        public DataResult<List<UsProductImage>> GetAll()
        {
            var usProductImages=_usProductImageDal.GetAll();
            return new DataResult<List<UsProductImage>> { isSuccess = true,Data= usProductImages };
        }


        public Result Update(IFormFile file, UsProductImage usProductImage)
        {
            _usProductImageDal.Update(usProductImage);
            return new Result { isSuccess = true };
        }
    }
}
