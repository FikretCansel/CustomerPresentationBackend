using Business.Abstract;
using Business.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TagManager:ITagService
    {
        public ITagDal _tagDal;
        public IUsProductTagDal _usProductTagDal;
        public TagManager(ITagDal tagDal, IUsProductTagDal usProductTagDal)
        {
            _tagDal = tagDal;
            _usProductTagDal = usProductTagDal;
        }

        public DataResult<List<Tag>> GetAllSectors()
        {
             return new DataResult<List<Tag>> { isSuccess = true, Message = "Başarılı", Data = _tagDal.GetAll(t=>t.TagTypeId==2) };
        }

        public DataResult<List<UsProductTagDto>> GetAllProductTagsByProductId(int productId)
        {
            return new DataResult<List<UsProductTagDto>> { isSuccess = true, Message = "Başarılı", Data = _usProductTagDal.GetAllProductTagsByProductId(productId) };
        }


    }
}
