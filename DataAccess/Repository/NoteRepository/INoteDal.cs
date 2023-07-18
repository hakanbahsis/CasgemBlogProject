using Core.DataAccess;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.NoteRepository
{
    public interface INoteDal:IGenericRepository<Note>
    {
    }
}
