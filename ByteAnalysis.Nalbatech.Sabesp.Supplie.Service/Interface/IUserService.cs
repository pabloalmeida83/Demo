using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface
{
    public interface IUserService
    {
        List<Entity.User> findAll();
        Entity.User findByPK(int id);
        Entity.User insert(Entity.User entity);
        int update(Entity.User entity);
        int delete(int id);

        //{{FindFK}}
    }
}

