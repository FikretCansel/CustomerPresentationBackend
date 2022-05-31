using Business.Utilities.Results;
using Entities.Concreate;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerInfoService
    {
        Result Add(CustomerInfoDto entity);

        DataResult<List<UsProduct>> SaveAndReturnCustomProduct(CustomerInfoDto entity);


    }
}
