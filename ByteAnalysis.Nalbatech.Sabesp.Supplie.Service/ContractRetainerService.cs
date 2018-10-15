using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class ContractRetainerService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IContractRetainerService
    {
        Repository.ContractRetainerRepository repository = null;
        
        public ContractRetainerService()
        {
            this.repository = new Repository.ContractRetainerRepository();
        }

        public List<Entity.ContractRetainer> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.ContractRetainer findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.ContractRetainer insert(Entity.ContractRetainer entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.ContractRetainer entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

