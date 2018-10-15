using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class ProviderService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IProviderService
    {
        Repository.ProviderRepository repository = null;
        
        public ProviderService()
        {
            this.repository = new Repository.ProviderRepository();
        }

        public List<Entity.Provider> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Provider findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.Provider insert(Entity.Provider entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Provider entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

