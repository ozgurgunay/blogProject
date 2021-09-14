using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProje.Models
{
    public class PostListVM
    {
        public List<UserVM> Users { get; set; }
        public List<PostVM> Posts { get; set; }

    }
}
