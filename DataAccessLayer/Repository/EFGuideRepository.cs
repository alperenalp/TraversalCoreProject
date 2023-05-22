using DataAccessLayer.Data;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    internal class EFGuideRepository : Repository<Guide>, IGuideRepository
    {
        public EFGuideRepository(Context context) : base(context)
        {
        }
    }
}
