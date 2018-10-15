using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class UnitMaterialService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IUnitMaterialService
    {
        Repository.UnitMaterialRepository repository = null;
        
        public UnitMaterialService()
        {
            this.repository = new Repository.UnitMaterialRepository();
        }

        public List<Entity.UnitMaterial> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.UnitMaterial findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.UnitMaterial insert(Entity.UnitMaterial entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.UnitMaterial entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

