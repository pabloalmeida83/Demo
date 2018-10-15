using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class KitUnitService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IKitUnitService
    {
        Repository.KitUnitRepository repository = null;
        
        public KitUnitService()
        {
            this.repository = new Repository.KitUnitRepository();
        }

        public List<Entity.KitUnit> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.KitUnit findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.KitUnit insert(Entity.KitUnit entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.KitUnit entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

