using DataAccessLayer.Data;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class EFFeatures2Repository : Repository<Feature2>, IFeature2Repository
    {
        public EFFeatures2Repository(Context context) : base(context)
        {
        }
    }
}
