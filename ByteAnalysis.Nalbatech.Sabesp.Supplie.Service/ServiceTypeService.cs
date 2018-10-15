using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class ServiceTypeService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IServiceTypeService
    {
        Repository.ServiceTypeRepository repository = null;
        
        public ServiceTypeService()
        {
            this.repository = new Repository.ServiceTypeRepository();
        }

        public List<Entity.ServiceType> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.ServiceType findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.ServiceType insert(Entity.ServiceType entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.ServiceType entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

