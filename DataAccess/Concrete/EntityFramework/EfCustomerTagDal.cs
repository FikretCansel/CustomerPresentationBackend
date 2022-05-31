using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerTagDal : EfEntityRepositoryBase<CustomerTag, EfCustomerUIContext>, ICustomerTagDal
    {
        public void AddAllCustomerTags(List<CustomerTag> tags,int customerId)
        {
            using (EfCustomerUIContext context = new EfCustomerUIContext())
            {
                foreach (var row in tags)
                {
                    row.CustomerId= customerId;
                    var addedEntity = context.Entry(row);
                    addedEntity.State = EntityState.Added;
                }
                context.SaveChanges();
            }
        }
    }
}
