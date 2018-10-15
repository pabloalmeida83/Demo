using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IServiceTypeService
    {
        List<Entity.ServiceType> findAll();
        Entity.ServiceType findByPK(int id);
        Entity.ServiceType insert(Entity.ServiceType entity);
        int update(Entity.ServiceType entity);
        int delete(int id);

        //{{FindFK}}
    }
}

