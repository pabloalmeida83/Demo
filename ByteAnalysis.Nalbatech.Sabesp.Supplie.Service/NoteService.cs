using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Service
{
    public class NoteService:ByteAnalysis.Nalbatech.Sabesp.Supplie.Service.Interface.INoteService
    {
        Repository.NoteRepository repository = null;
        
        public NoteService()
        {
            this.repository = new Repository.NoteRepository();
        }

        public List<Entity.Note> findAll()
        {
            return this.repository.findAll();
        }

        public Entity.Note findByPK(int id)
        {
            return this.repository.findByPK(id);
        }

        public Entity.Note insert(Entity.Note entity)
        {
            return this.repository.insert(entity);
        }

        public int update(Entity.Note entity)
        {
            return this.repository.update(entity);
        }

        public int delete(int id)
        {
            return this.repository.delete(id);
        }
    }
}

