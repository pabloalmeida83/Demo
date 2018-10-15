using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class ContractAlterationService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IContractAlterationService
    {
        Repository.ContractAlterationRepository repository = null;
        
        public ContractAlterationService()
        {
            this.repository = new Repository.ContractAlterationRepository();
        }

        public List<Entity.ContractAlteration> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.ContractAlteration findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.ContractAlteration insert(Entity.ContractAlteration entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.ContractAlteration entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

