using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface ISanctionStatusService
    {
        List<Entity.SanctionStatus> findAll();
        Entity.SanctionStatus findByPK(int id);
        Entity.SanctionStatus insert(Entity.SanctionStatus entity);
        int update(Entity.SanctionStatus entity);
        int delete(int id);

        //{{FindFK}}
    }
}

