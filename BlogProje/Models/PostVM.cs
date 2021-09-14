using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProje.Models
{
    public class PostVM
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public DateTime DataOfWriting { get; set; }
        public string ContentText { get; set; }
        public string Summary { get; set; }
        public TimeSpan ReadTime { get; set; }
        public int ReadCount { get; set; }
        public int UserId { get; set; }
        public int CatId { get; set; }
    }
}
