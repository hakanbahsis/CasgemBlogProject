using Core.DataAccess;
using DataAccess.Concrete.Context;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.NoteRepository
{
    public class EfNoteDal:EfEntityRepositoryBase<Note,BlogContext>,INoteDal
    {
    }
}
