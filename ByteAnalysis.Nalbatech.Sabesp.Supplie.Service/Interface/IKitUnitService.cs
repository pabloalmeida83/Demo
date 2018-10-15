using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IKitUnitService
    {
        List<Entity.KitUnit> findAll();
        Entity.KitUnit findByPK(int id);
        Entity.KitUnit insert(Entity.KitUnit entity);
        int update(Entity.KitUnit entity);
        int delete(int id);

        //{{FindFK}}
    }
}

