using Core.DataAccess;
using DataAccess.Concrete.Context;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.CategoryRepository
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, BlogContext>, ICategoryDal
    {
       
    }
}
