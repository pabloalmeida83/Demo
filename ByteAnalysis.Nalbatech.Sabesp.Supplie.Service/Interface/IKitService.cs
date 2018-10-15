using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IKitService
    {
        List<Entity.Kit> findAll();
        Entity.Kit findByPK(int id);
        Entity.Kit insert(Entity.Kit entity);
        int update(Entity.Kit entity);
        int delete(int id);

        //{{FindFK}}
    }
}

