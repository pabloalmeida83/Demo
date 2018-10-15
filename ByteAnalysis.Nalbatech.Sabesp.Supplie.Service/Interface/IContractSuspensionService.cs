using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IContractSuspensionService
    {
        List<Entity.ContractSuspension> findAll();
        Entity.ContractSuspension findByPK(int id);
        Entity.ContractSuspension insert(Entity.ContractSuspension entity);
        int update(Entity.ContractSuspension entity);
        int delete(int id);

        //{{FindFK}}
    }
}

