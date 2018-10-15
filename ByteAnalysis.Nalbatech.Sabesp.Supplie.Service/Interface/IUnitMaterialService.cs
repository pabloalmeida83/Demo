using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IUnitMaterialService
    {
        List<Entity.UnitMaterial> findAll();
        Entity.UnitMaterial findByPK(int id);
        Entity.UnitMaterial insert(Entity.UnitMaterial entity);
        int update(Entity.UnitMaterial entity);
        int delete(int id);

        //{{FindFK}}
    }
}

