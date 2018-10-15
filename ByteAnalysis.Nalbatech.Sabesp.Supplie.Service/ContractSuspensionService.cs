using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class ContractSuspensionService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IContractSuspensionService
    {
        Repository.ContractSuspensionRepository repository = null;
        
        public ContractSuspensionService()
        {
            this.repository = new Repository.ContractSuspensionRepository();
        }

        public List<Entity.ContractSuspension> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.ContractSuspension findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.ContractSuspension insert(Entity.ContractSuspension entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.ContractSuspension entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

