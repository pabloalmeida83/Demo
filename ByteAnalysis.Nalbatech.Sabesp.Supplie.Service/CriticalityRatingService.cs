using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class CriticalityRatingService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.ICriticalityRatingService
    {
        Repository.CriticalityRatingRepository repository = null;
        
        public CriticalityRatingService()
        {
            this.repository = new Repository.CriticalityRatingRepository();
        }

        public List<Entity.CriticalityRating> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.CriticalityRating findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.CriticalityRating insert(Entity.CriticalityRating entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.CriticalityRating entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

