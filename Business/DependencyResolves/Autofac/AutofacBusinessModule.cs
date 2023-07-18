using Autofac;
using Business.Repository.CategoryRepository;
using Business.Repository.CommentRepository;
using Business.Repository.NoteRepository;
using DataAccess.Repository.CategoryRepository;
using DataAccess.Repository.CommentRepository;
using DataAccess.Repository.NoteRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ICategoryService>().As<CategoryManager>();
            builder.RegisterType<ICategoryDal>().As<EfCategoryDal>();
            
            builder.RegisterType<ICommentService>().As<CommentManager>();
            builder.RegisterType<ICommentDal>().As<EfCommentDal>();
            
            builder.RegisterType<INoteService>().As<NoteManager>();
            builder.RegisterType<INoteDal>().As<EfNoteDal>();

        }
    }
}
