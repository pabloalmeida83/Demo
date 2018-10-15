using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class SysdiagramsService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.ISysdiagramsService
    {
        Repository.SysdiagramsRepository repository = null;
        
        public SysdiagramsService()
        {
            this.repository = new Repository.SysdiagramsRepository();
        }

        public List<Entity.Sysdiagrams> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Sysdiagrams findByPK(int diagram_id)
        {
            return this.repository.findByPK(diagram_id);
        }

        public Entity.Sysdiagrams insert(Entity.Sysdiagrams entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Sysdiagrams entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int diagram_id)
        {
            return this.repository.delete(diagram_id);
        }
    }
}

