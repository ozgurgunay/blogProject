using System;
using System.Collections.Generic;

#nullable disable

namespace BlogProje.DataAccess
{
    public partial class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public DateTime? DateOfWriting { get; set; }
        public string ContentText { get; set; }
        public string Summary { get; set; }
        public TimeSpan? ReadTime { get; set; }
        public int? ReadCount { get; set; }
        public int? UserId { get; set; }
        public int? CatId { get; set; }

        public virtual PostCategory Cat { get; set; }
        public virtual User User { get; set; }
    }
}
