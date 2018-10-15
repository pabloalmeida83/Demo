using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class RepresentativeService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IRepresentativeService
    {
        Repository.RepresentativeRepository repository = null;
        
        public RepresentativeService()
        {
            this.repository = new Repository.RepresentativeRepository();
        }

        public List<Entity.Representative> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Representative findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.Representative insert(Entity.Representative entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Representative entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

