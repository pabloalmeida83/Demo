using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IKitMaterialService
    {
        List<Entity.KitMaterial> findAll();
        Entity.KitMaterial findByPK(int id);
        Entity.KitMaterial insert(Entity.KitMaterial entity);
        int update(Entity.KitMaterial entity);
        int delete(int id);

        //{{FindFK}}
    }
}

