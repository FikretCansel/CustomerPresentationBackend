using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class UsProductTagDto
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int UsProductId { get; set; }
        public string ProductName { get; set; }
    }
}
