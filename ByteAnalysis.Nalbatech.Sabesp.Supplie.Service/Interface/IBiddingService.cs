using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IBiddingService
    {
        List<Entity.Bidding> findAll();
        Entity.Bidding findByPK(int id);
        Entity.Bidding insert(Entity.Bidding entity);
        int update(Entity.Bidding entity);
        int delete(int id);

        //{{FindFK}}
    }
}

