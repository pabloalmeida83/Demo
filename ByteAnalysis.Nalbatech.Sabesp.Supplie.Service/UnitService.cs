using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class UnitService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IUnitService
    {
        Repository.UnitRepository repository = null;
        
        public UnitService()
        {
            this.repository = new Repository.UnitRepository();
        }

        public List<Entity.Unit> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Unit findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.Unit insert(Entity.Unit entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Unit entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

