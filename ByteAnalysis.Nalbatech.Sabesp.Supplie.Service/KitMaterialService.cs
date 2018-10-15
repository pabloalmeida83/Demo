using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class KitMaterialService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IKitMaterialService
    {
        Repository.KitMaterialRepository repository = null;
        
        public KitMaterialService()
        {
            this.repository = new Repository.KitMaterialRepository();
        }

        public List<Entity.KitMaterial> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.KitMaterial findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.KitMaterial insert(Entity.KitMaterial entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.KitMaterial entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

