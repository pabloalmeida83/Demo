using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IStockTypeService
    {
        List<Entity.StockType> findAll();
        Entity.StockType findByPK(int id);
        Entity.StockType insert(Entity.StockType entity);
        int update(Entity.StockType entity);
        int delete(int id);

        //{{FindFK}}
    }
}

