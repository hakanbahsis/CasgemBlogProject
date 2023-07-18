using Core.DataAccess;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.CommentRepository
{
    public interface ICommentDal:IGenericRepository<Comment>
    {
    }
}
