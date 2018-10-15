using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class UnitMaterialTypeService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IUnitMaterialTypeService
    {
        Repository.UnitMaterialTypeRepository repository = null;
        
        public UnitMaterialTypeService()
        {
            this.repository = new Repository.UnitMaterialTypeRepository();
        }

        public List<Entity.UnitMaterialType> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.UnitMaterialType findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.UnitMaterialType insert(Entity.UnitMaterialType entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.UnitMaterialType entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

