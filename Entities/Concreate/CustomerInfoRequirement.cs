using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class CustomerInfoRequirement:IEntity
    {
        public int CustomerInfoId { get; set; }
        public int RequirementId { get; set; }
    }
}
