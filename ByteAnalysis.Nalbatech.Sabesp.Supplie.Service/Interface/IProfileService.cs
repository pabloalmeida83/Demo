using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IProfileService
    {
        List<Entity.Profile> findAll();
        Entity.Profile findByPK(int id);
        Entity.Profile insert(Entity.Profile entity);
        int update(Entity.Profile entity);
        int delete(int id);

        //{{FindFK}}
    }
}

