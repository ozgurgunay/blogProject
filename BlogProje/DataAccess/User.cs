using System;
using System.Collections.Generic;

#nullable disable

namespace BlogProje.DataAccess
{
    public partial class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Explanation { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
