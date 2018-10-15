using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IContractSanctionService
    {
        List<Entity.ContractSanction> findAll();
        Entity.ContractSanction findByPK(int id);
        Entity.ContractSanction insert(Entity.ContractSanction entity);
        int update(Entity.ContractSanction entity);
        int delete(int id);

        //{{FindFK}}
    }
}

