using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IPlanningStatusService
    {
        List<Entity.PlanningStatus> findAll();
        Entity.PlanningStatus findByPK(int id);
        Entity.PlanningStatus insert(Entity.PlanningStatus entity);
        int update(Entity.PlanningStatus entity);
        int delete(int id);

        //{{FindFK}}
    }
}

