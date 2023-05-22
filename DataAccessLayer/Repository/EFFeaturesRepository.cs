using DataAccessLayer.Data;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class EFFeaturesRepository : Repository<Feature>, IFeatureRepository
    {
        public EFFeaturesRepository(Context context) : base(context)
        {
        }
    }
}
