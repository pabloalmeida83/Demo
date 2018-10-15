using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IProviderService
    {
        List<Entity.Provider> findAll();
        Entity.Provider findByPK(int id);
        Entity.Provider insert(Entity.Provider entity);
        int update(Entity.Provider entity);
        int delete(int id);

        //{{FindFK}}
    }
}

