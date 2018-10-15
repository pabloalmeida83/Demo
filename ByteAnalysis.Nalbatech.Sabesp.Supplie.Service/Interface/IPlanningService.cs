using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IPlanningService
    {
        List<Entity.Planning> findAll();
        Entity.Planning findByPK(int id);
        Entity.Planning insert(Entity.Planning entity);
        int update(Entity.Planning entity);
        int delete(int id);

        //{{FindFK}}
    }
}

