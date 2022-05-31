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
        public IUsProductService _usProductService;
        public ICustomerTagDal _customerTagDal;

        public CustomerInfoManager(ICustomerInfoDal customerInfoDal, IUsProductService usProductService, ICustomerTagDal customerTagDal)
        {
            _customerInfoDal = customerInfoDal;
            _usProductService = usProductService;
            _customerTagDal = customerTagDal;
    }

        public Result Add(CustomerInfoDto entity)
        {
            _customerInfoDal.Add(new CustomerInfo {MailAddress=entity.MailAddress,
                AuthorizedName=entity.AuthorizedName,CompanyName=entity.Name,PhoneNumber=entity.PhoneNumber,
                WebAddress=entity.WebAddress });
                
            return new Result { isSuccess= true,Message= "İşlem Başarılı"};
        }

        public DataResult<List<UsProduct>> SaveAndReturnCustomProduct(CustomerInfoDto entity)
        {
            var customerInfo = _customerInfoDal.Add(
                new CustomerInfo{
                MailAddress = entity.MailAddress,
                AuthorizedName = entity.AuthorizedName,
                CompanyName = entity.Name,
                PhoneNumber = entity.PhoneNumber,
                WebAddress = entity.WebAddress,
                Note=entity.Note
            });
            int customerId = customerInfo.Id;
            _customerTagDal.AddAllCustomerTags(entity.CustomerTags , customerId);

            var products = _usProductService.GetAllCustomeProducts(customerInfo.Id);

            return new DataResult<List<UsProduct>> { isSuccess = true, Message = "İşlem Başarılı",Data= products.Data };

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
