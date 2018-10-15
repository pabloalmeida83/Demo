using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IBiddingStatusService
    {
        List<Entity.BiddingStatus> findAll();
        Entity.BiddingStatus findByPK(int id);
        Entity.BiddingStatus insert(Entity.BiddingStatus entity);
        int update(Entity.BiddingStatus entity);
        int delete(int id);

        //{{FindFK}}
    }
}

