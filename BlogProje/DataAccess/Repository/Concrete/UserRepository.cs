using BlogProje.DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProje.DataAccess.Repository.Concrete
{
    public class UserRepository : IUserRepository
    {
        //Scaffold-DbContext "Server=DESKTOP-BL2GJU5\MSSQLSERV; Database=BlogDb; uid=user; pwd=Ozgur1995;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir DataAccess

        BlogDbContext context;
        public UserRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public bool AddUser(User user)
        {
            context.Add(user);
            return context.SaveChanges() > 0;
        }
        public bool UpdateUser (User user)
        {
            User updateUser = context.Users.Where(x => x.Email == user.Email).FirstOrDefault();
            updateUser.FirstName = user.FirstName;
            updateUser.LastName = user.LastName;
            updateUser.UserName = user.UserName;
            updateUser.Email = user.Email;
            updateUser.Explanation = user.Explanation;
            updateUser.Picture = user.Picture;

            return context.SaveChanges() > 0;

        }

        public User GetUser(int id)
        {
            return context.Users.Where(x => x.UserId == id).SingleOrDefault();
        }

        public User LoginByUser(string eMail)
        {
            return context.Users.Where(x => x.Email == eMail).SingleOrDefault();
        }
    }
}
