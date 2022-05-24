using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class CustomerInfo:IEntity
    {
        public int Id { get; set; }
        public int CustomerTypeId { get; set; }
        public int SectorId { get; set; }
        public int TypeOfNeedId { get; set; }
        public string Name { get; set; }
        public string AuthorizedName { get; set; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string WebAddress { get; set; }

    }
}
