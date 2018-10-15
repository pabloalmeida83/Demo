using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IAtaPositionService
    {
        List<Entity.AtaPosition> findAll();
        Entity.AtaPosition findByPK(int id);
        Entity.AtaPosition insert(Entity.AtaPosition entity);
        int update(Entity.AtaPosition entity);
        int delete(int id);

        //{{FindFK}}
    }
}

