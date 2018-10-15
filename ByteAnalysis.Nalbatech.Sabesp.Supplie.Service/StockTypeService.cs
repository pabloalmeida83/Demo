using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class StockTypeService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IStockTypeService
    {
        Repository.StockTypeRepository repository = null;
        
        public StockTypeService()
        {
            this.repository = new Repository.StockTypeRepository();
        }

        public List<Entity.StockType> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.StockType findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.StockType insert(Entity.StockType entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.StockType entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

