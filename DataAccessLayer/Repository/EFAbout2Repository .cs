using DataAccessLayer.Data;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class EFAbout2Repository : Repository<About2>, IAbout2Repository
    {
        public EFAbout2Repository(Context context) : base(context)
        {

        }
    }
}
