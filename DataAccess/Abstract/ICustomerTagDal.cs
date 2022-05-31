using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICustomerTagDal: IEntityRepositoryBase<CustomerTag>
    {
        void AddAllCustomerTags(List<CustomerTag> tags, int customerId);
    }
}
