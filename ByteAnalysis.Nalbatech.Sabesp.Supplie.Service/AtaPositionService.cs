using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class AtaPositionService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IAtaPositionService
    {
        Repository.AtaPositionRepository repository = null;
        
        public AtaPositionService()
        {
            this.repository = new Repository.AtaPositionRepository();
        }

        public List<Entity.AtaPosition> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.AtaPosition findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.AtaPosition insert(Entity.AtaPosition entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.AtaPosition entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

