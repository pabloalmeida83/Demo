using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class MaterialService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IMaterialService
    {
        Repository.MaterialRepository repository = null;
        
        public MaterialService()
        {
            this.repository = new Repository.MaterialRepository();
        }

        public List<Entity.Material> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Material findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.Material insert(Entity.Material entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Material entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

