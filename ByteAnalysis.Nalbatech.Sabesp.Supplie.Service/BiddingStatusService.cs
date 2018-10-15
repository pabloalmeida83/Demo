using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class BiddingStatusService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IBiddingStatusService
    {
        Repository.BiddingStatusRepository repository = null;
        
        public BiddingStatusService()
        {
            this.repository = new Repository.BiddingStatusRepository();
        }

        public List<Entity.BiddingStatus> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.BiddingStatus findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.BiddingStatus insert(Entity.BiddingStatus entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.BiddingStatus entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

