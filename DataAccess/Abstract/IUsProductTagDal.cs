using Entities.Concreate;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUsProductTagDal: IEntityRepositoryBase<UsProductTag>
    {
        List<UsProductTagDto> GetAllProductTagsByProductId(int productId);
    }
}
