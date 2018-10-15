using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IPlanningTypeService
    {
        List<Entity.PlanningType> findAll();
        Entity.PlanningType findByPK(int id);
        Entity.PlanningType insert(Entity.PlanningType entity);
        int update(Entity.PlanningType entity);
        int delete(int id);

        //{{FindFK}}
    }
}

