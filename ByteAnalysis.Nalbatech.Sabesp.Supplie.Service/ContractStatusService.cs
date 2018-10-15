using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class ContractStatusService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IContractStatusService
    {
        Repository.ContractStatusRepository repository = null;
        
        public ContractStatusService()
        {
            this.repository = new Repository.ContractStatusRepository();
        }

        public List<Entity.ContractStatus> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.ContractStatus findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.ContractStatus insert(Entity.ContractStatus entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.ContractStatus entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

