using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class UsProductImage:IEntity
    {
        public int Id { get; set; }
        public int UsProductId { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateTime { get; set; }
    }
}
