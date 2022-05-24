using Business.Abstract;
using Business.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerInfoManager : ICustomerInfoService
    {
        public ICustomerInfoDal _customerInfoDal;

        public CustomerInfoManager(ICustomerInfoDal customerInfoDal)
        {
            _customerInfoDal = customerInfoDal;
        }

        


        public Result Add(CustomerInfoDto entity)
        {
            _customerInfoDal.Add(new CustomerInfo {CustomerTypeId=entity.CustomerTypeId,
                SectorId=entity.SectorId,TypeOfNeedId=entity.TypeOfNeedId,MailAddress=entity.MailAddress,
                AuthorizedName=entity.AuthorizedName,Name=entity.Name,PhoneNumber=entity.PhoneNumber,
                WebAddress=entity.WebAddress });

            return new Result { isSuccess= true,Message= "İşlem Başarılı"};

        }

        public void Delete(CustomerInfo entity)
        {
            throw new NotImplementedException();
        }

        public CustomerInfo Get(Expression<Func<CustomerInfo, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CustomerInfo> GetAll(Expression<Func<CustomerInfo, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerInfo entity)
        {
            throw new NotImplementedException();
        }
    }
}
