using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IResourceService
    {
        List<Entity.Resource> findAll();
        Entity.Resource findByPK(int id);
        Entity.Resource insert(Entity.Resource entity);
        int update(Entity.Resource entity);
        int delete(int id);

        //{{FindFK}}
    }
}

