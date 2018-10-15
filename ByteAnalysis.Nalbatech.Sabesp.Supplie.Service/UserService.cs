using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class UserService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IUserService
    {
        Repository.UserRepository repository = null;
        
        public UserService()
        {
            this.repository = new Repository.UserRepository();
        }

        public List<Entity.User> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.User findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.User insert(Entity.User entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.User entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

