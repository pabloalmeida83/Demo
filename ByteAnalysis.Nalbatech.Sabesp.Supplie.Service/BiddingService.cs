using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class BiddingService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IBiddingService
    {
        Repository.BiddingRepository repository = null;
        
        public BiddingService()
        {
            this.repository = new Repository.BiddingRepository();
        }

        public List<Entity.Bidding> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Bidding findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.Bidding insert(Entity.Bidding entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Bidding entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

