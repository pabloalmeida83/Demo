using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class ProfileService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IProfileService
    {
        Repository.ProfileRepository repository = null;
        
        public ProfileService()
        {
            this.repository = new Repository.ProfileRepository();
        }

        public List<Entity.Profile> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Profile findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.Profile insert(Entity.Profile entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Profile entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

