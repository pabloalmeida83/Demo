using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class PlanningUnitService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IPlanningUnitService
    {
        Repository.PlanningUnitRepository repository = null;
        
        public PlanningUnitService()
        {
            this.repository = new Repository.PlanningUnitRepository();
        }

        public List<Entity.PlanningUnit> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.PlanningUnit findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.PlanningUnit insert(Entity.PlanningUnit entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.PlanningUnit entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

