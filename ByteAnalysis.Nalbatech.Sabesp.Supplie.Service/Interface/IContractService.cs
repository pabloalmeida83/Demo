using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IContractService
    {
        List<Entity.Contract> findAll();
        Entity.Contract findByPK(int id);
        Entity.Contract insert(Entity.Contract entity);
        int update(Entity.Contract entity);
        int delete(int id);

        //{{FindFK}}
    }
}

