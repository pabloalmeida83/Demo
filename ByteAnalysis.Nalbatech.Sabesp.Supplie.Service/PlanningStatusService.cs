using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class PlanningStatusService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IPlanningStatusService
    {
        Repository.PlanningStatusRepository repository = null;
        
        public PlanningStatusService()
        {
            this.repository = new Repository.PlanningStatusRepository();
        }

        public List<Entity.PlanningStatus> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.PlanningStatus findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.PlanningStatus insert(Entity.PlanningStatus entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.PlanningStatus entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

