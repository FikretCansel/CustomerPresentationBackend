using Business.Abstract;
using Business.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerInfoRequirementManager : ICustomerInfoRequirementService
    {
        ICustomerInfoRequirementDal _customerInfoRequirement;

        public CustomerInfoRequirementManager(ICustomerInfoRequirementDal customerInfoRequirement)
        {
            _customerInfoRequirement = customerInfoRequirement;
        }

        public void Add(CustomerInfoRequirement entity)
        {
            _customerInfoRequirement.Add(entity);
        }

        public void Delete(CustomerInfoRequirement entity)
        {
            throw new NotImplementedException();
        }

        public CustomerInfoRequirement Get(Expression<Func<CustomerInfoRequirement, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CustomerInfoRequirement> GetAll(Expression<Func<CustomerInfoRequirement, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerInfoRequirement entity)
        {
            throw new NotImplementedException();
        }
    }
}
