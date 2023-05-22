using DataAccessLayer.Data;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class EFSubAboutRepository : Repository<SubAbout>, ISubAboutRepository
    {
        public EFSubAboutRepository(Context context) : base(context)
        {
        }
    }
}
