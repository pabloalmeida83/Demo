using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class SanctionStatusService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.ISanctionStatusService
    {
        Repository.SanctionStatusRepository repository = null;
        
        public SanctionStatusService()
        {
            this.repository = new Repository.SanctionStatusRepository();
        }

        public List<Entity.SanctionStatus> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.SanctionStatus findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.SanctionStatus insert(Entity.SanctionStatus entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.SanctionStatus entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

