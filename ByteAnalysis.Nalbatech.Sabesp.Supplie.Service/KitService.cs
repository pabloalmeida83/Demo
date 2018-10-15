using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class KitService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IKitService
    {
        Repository.KitRepository repository = null;
        
        public KitService()
        {
            this.repository = new Repository.KitRepository();
        }

        public List<Entity.Kit> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Kit findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.Kit insert(Entity.Kit entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Kit entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

