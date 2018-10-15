using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class PlanningUnitMaterialService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IPlanningUnitMaterialService
    {
        Repository.PlanningUnitMaterialRepository repository = null;
        
        public PlanningUnitMaterialService()
        {
            this.repository = new Repository.PlanningUnitMaterialRepository();
        }

        public List<Entity.PlanningUnitMaterial> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.PlanningUnitMaterial findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.PlanningUnitMaterial insert(Entity.PlanningUnitMaterial entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.PlanningUnitMaterial entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

