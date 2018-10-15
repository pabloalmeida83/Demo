using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class PlanningMaterialService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IPlanningMaterialService
    {
        Repository.PlanningMaterialRepository repository = null;
        
        public PlanningMaterialService()
        {
            this.repository = new Repository.PlanningMaterialRepository();
        }

        public List<Entity.PlanningMaterial> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.PlanningMaterial findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.PlanningMaterial insert(Entity.PlanningMaterial entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.PlanningMaterial entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

