using Core.DataAccess;
using DataAccess.Concrete.Context;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.CommentRepository
{
    public class EfCommentDal:EfEntityRepositoryBase<Comment,BlogContext>,ICommentDal
    {
    }
}
