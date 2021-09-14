﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BlogProje.DataAccess
{
    public partial class PostCategory
    {
        public PostCategory()
        {
            Posts = new HashSet<Post>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int PostId { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
