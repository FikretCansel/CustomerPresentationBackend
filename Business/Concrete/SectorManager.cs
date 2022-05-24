using Business.Abstract;
using Business.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SectorManager : ISectorService
    {
        public DataResult<List<Sector>> GetAll()
        {
            return new DataResult<List<Sector>>
            {
                isSuccess = true,
                Message = "Başarılı",
                Data = new List<Sector> {
                new Sector{Id=1,Name="Otomative" },
                new Sector{Id=2,Name="Tekstil" },
                new Sector{Id=3,Name="Gıda" },
                new Sector{Id=4,Name="Ahşap Teknolojisi." },
                new Sector{Id=5,Name="Eğitim" },
                new Sector{Id=6,Name="Enerji" },

                }
            };
        }
    }
}
