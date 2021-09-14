using BlogProje.DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProje.DataAccess.Repository.Concrete
{
    public class PostRepository : IPostRepository
    {
        BlogDbContext context;
        public PostRepository(BlogDbContext context)
        {
            this.context = context;
        }
        public List<Post> GetPosts()
        {
            return context.Posts.ToList();
        }
        public Post GetPost(int id)
        {
            return context.Posts.SingleOrDefault(x => x.PostId == id);
        }
    }
}
