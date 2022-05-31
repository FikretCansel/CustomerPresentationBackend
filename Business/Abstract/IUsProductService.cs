using Business.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUsProductService
    {
        DataResult<List<UsProduct>> GetAll();

        DataResult<List<UsProduct>> GetAllCustomeProducts(int customerId);

    }
}
