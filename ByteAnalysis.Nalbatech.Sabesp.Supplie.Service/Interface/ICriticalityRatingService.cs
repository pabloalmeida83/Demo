using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface ICriticalityRatingService
    {
        List<Entity.CriticalityRating> findAll();
        Entity.CriticalityRating findByPK(int id);
        Entity.CriticalityRating insert(Entity.CriticalityRating entity);
        int update(Entity.CriticalityRating entity);
        int delete(int id);

        //{{FindFK}}
    }
}

