using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IUnitService
    {
        List<Entity.Unit> findAll();
        Entity.Unit findByPK(int id);
        Entity.Unit insert(Entity.Unit entity);
        int update(Entity.Unit entity);
        int delete(int id);

        //{{FindFK}}
    }
}

