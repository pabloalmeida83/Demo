using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface ISysdiagramsService
    {
        List<Entity.Sysdiagrams> findAll();
        Entity.Sysdiagrams findByPK(int diagram_id);
        Entity.Sysdiagrams insert(Entity.Sysdiagrams entity);
        int update(Entity.Sysdiagrams entity);
        int delete(int diagram_id);

        //{{FindFK}}
    }
}

