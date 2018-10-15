using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IPlanningMaterialService
    {
        List<Entity.PlanningMaterial> findAll();
        Entity.PlanningMaterial findByPK(int id);
        Entity.PlanningMaterial insert(Entity.PlanningMaterial entity);
        int update(Entity.PlanningMaterial entity);
        int delete(int id);

        //{{FindFK}}
    }
}

