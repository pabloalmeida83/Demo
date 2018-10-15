using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IPlanningUnitService
    {
        List<Entity.PlanningUnit> findAll();
        Entity.PlanningUnit findByPK(int id);
        Entity.PlanningUnit insert(Entity.PlanningUnit entity);
        int update(Entity.PlanningUnit entity);
        int delete(int id);

        //{{FindFK}}
    }
}

