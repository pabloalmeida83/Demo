using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class ContractSanctionService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IContractSanctionService
    {
        Repository.ContractSanctionRepository repository = null;
        
        public ContractSanctionService()
        {
            this.repository = new Repository.ContractSanctionRepository();
        }

        public List<Entity.ContractSanction> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.ContractSanction findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.ContractSanction insert(Entity.ContractSanction entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.ContractSanction entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

