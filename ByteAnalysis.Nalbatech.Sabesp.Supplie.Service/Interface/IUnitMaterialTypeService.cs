using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IUnitMaterialTypeService
    {
        List<Entity.UnitMaterialType> findAll();
        Entity.UnitMaterialType findByPK(int id);
        Entity.UnitMaterialType insert(Entity.UnitMaterialType entity);
        int update(Entity.UnitMaterialType entity);
        int delete(int id);

        //{{FindFK}}
    }
}

