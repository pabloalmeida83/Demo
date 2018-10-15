using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class PlanningService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IPlanningService
    {
        Repository.PlanningRepository repository = null;
        
        public PlanningService()
        {
            this.repository = new Repository.PlanningRepository();
        }

        public List<Entity.Planning> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Planning findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.Planning insert(Entity.Planning entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Planning entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

