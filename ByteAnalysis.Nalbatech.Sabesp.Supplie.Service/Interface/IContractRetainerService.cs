using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IContractRetainerService
    {
        List<Entity.ContractRetainer> findAll();
        Entity.ContractRetainer findByPK(int id);
        Entity.ContractRetainer insert(Entity.ContractRetainer entity);
        int update(Entity.ContractRetainer entity);
        int delete(int id);

        //{{FindFK}}
    }
}

