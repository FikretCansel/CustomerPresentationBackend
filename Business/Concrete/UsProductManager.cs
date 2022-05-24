using Business.Abstract;
using Business.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UsProductManager : IUsProductService
    {
        private IUsProductDal _productDal; 
        public UsProductManager(IUsProductDal productDal)
        {
            _productDal = productDal;
        }

        public DataResult<List<UsProduct>> GetAll()
        {
            return new DataResult<List<UsProduct>> { isSuccess = true, Message = "Işlem Başarılı", Data = _productDal.GetAll() };
        }
    }
}
