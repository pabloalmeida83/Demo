using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class AtaService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.IAtaService
    {
        Repository.AtaRepository repository = null;
        
        public AtaService()
        {
            this.repository = new Repository.AtaRepository();
        }

        public List<Entity.Ata> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Ata findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.Ata insert(Entity.Ata entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Ata entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

