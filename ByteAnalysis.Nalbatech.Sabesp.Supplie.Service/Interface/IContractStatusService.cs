using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IContractStatusService
    {
        List<Entity.ContractStatus> findAll();
        Entity.ContractStatus findByPK(int id);
        Entity.ContractStatus insert(Entity.ContractStatus entity);
        int update(Entity.ContractStatus entity);
        int delete(int id);

        //{{FindFK}}
    }
}

