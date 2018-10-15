using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class ContractService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IContractService
    {
        Repository.ContractRepository repository = null;
        
        public ContractService()
        {
            this.repository = new Repository.ContractRepository();
        }

        public List<Entity.Contract> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Contract findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.Contract insert(Entity.Contract entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Contract entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

