using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IAtaService
    {
        List<Entity.Ata> findAll();
        Entity.Ata findByPK(int id);
        Entity.Ata insert(Entity.Ata entity);
        int update(Entity.Ata entity);
        int delete(int id);

        //{{FindFK}}
    }
}

