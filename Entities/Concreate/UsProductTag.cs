﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class UsProductTag:IEntity
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int UsProductId { get; set; }
    }
}
