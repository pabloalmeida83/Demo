using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IRepresentativeService
    {
        List<Entity.Representative> findAll();
        Entity.Representative findByPK(int id);
        Entity.Representative insert(Entity.Representative entity);
        int update(Entity.Representative entity);
        int delete(int id);

        //{{FindFK}}
    }
}

