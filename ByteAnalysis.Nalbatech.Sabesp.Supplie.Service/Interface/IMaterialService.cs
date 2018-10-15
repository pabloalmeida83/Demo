using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IMaterialService
    {
        List<Entity.Material> findAll();
        Entity.Material findByPK(int id);
        Entity.Material insert(Entity.Material entity);
        int update(Entity.Material entity);
        int delete(int id);

        //{{FindFK}}
    }
}

