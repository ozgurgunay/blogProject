using BlogProje.DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProje.DataAccess.Repository.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        BlogDbContext context;
        public CategoryRepository (BlogDbContext context)
        {
            this.context = context;
        }

        public List<PostCategory> GetPostCategories()
        {
            return context.PostCategories.ToList();
        }
    }
}
