using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IContractAlterationService
    {
        List<Entity.ContractAlteration> findAll();
        Entity.ContractAlteration findByPK(int id);
        Entity.ContractAlteration insert(Entity.ContractAlteration entity);
        int update(Entity.ContractAlteration entity);
        int delete(int id);

        //{{FindFK}}
    }
}

