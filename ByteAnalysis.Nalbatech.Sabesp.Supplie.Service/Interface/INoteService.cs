using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface INoteService
    {
        List<Entity.Note> findAll();
        Entity.Note findByPK(int id);
        Entity.Note insert(Entity.Note entity);
        int update(Entity.Note entity);
        int delete(int id);

        //{{FindFK}}
    }
}

