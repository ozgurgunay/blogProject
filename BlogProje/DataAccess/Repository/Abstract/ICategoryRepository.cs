using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProje.DataAccess.Repository.Abstract
{
    public interface ICategoryRepository
    {
        List<PostCategory> GetPostCategories();
    }
}
