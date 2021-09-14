using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProje.DataAccess.Repository.Abstract
{
    public interface IPostRepository
    {
        List<Post> GetPosts();
        Post GetPost(int id);
    }

}
