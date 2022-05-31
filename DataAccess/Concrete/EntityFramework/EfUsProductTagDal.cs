using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUsProductTagDal: EfEntityRepositoryBase<UsProductTag, EfCustomerUIContext>, IUsProductTagDal
    {
        public List<UsProduct> GetAllCustomeProducts(int customerId)
        {
            using (EfCustomerUIContext context = new EfCustomerUIContext())
            {

                var result = from pt in context.UsProductTags
                             join ct in context.CustomerTags on pt.TagId equals ct.TagId
                             join product in context.UsProducts on pt.UsProductId equals product.Id
                             where ct.CustomerId == customerId
                             select new UsProduct
                             {
                                 Id = pt.UsProductId,
                                 Descripiton = product.Descripiton,
                                 ImageUrl = product.ImageUrl,
                                 Name = product.Name
                             };

                return result.Distinct().ToList();
            }
        }

        public List<UsProductTagDto> GetAllProductTagsByProductId(int productId)
        {
            using (EfCustomerUIContext context = new EfCustomerUIContext())
            {

                var result = from pt in context.UsProductTags
                             join t in context.Tags on pt.TagId equals t.Id
                             where productId == pt.UsProductId
                             select new UsProductTagDto
                             {
                                 ProductName = t.Name,
                                 TagId = pt.UsProductId,
                                 UsProductId = pt.UsProductId,
                                 Id = pt.Id
                             };

                return result.Distinct().ToList();
            }
        }
    }
}
