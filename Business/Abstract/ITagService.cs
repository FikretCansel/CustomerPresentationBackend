﻿using Business.Utilities.Results;
using Entities.Concreate;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITagService
    {
        DataResult<List<Tag>> GetAllSectors();

        DataResult<List<UsProductTagDto>> GetAllProductTagsByProductId(int productId);
    }
}
