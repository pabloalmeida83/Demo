using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class PlanningTypeService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IPlanningTypeService
    {
        Repository.PlanningTypeRepository repository = null;
        
        public PlanningTypeService()
        {
            this.repository = new Repository.PlanningTypeRepository();
        }

        public List<Entity.PlanningType> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.PlanningType findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.PlanningType insert(Entity.PlanningType entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.PlanningType entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

