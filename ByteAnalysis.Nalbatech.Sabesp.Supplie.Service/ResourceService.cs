using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class ResourceService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IResourceService
    {
        Repository.ResourceRepository repository = null;
        
        public ResourceService()
        {
            this.repository = new Repository.ResourceRepository();
        }

        public List<Entity.Resource> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Resource findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.Resource insert(Entity.Resource entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Resource entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

