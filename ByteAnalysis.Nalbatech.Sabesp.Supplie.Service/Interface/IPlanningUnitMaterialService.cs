using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IPlanningUnitMaterialService
    {
        List<Entity.PlanningUnitMaterial> findAll();
        Entity.PlanningUnitMaterial findByPK(int id);
        Entity.PlanningUnitMaterial insert(Entity.PlanningUnitMaterial entity);
        int update(Entity.PlanningUnitMaterial entity);
        int delete(int id);

        //{{FindFK}}
    }
}

