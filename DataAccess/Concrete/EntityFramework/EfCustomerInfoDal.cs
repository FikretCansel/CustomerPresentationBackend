﻿using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerInfoDal:EfEntityRepositoryBase<CustomerInfo,EfCustomerUIContext>,ICustomerInfoDal
    {
    }
}
