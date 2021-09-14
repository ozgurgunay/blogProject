using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProje.DataAccess.Repository.Abstract
{
    public interface IUserRepository
    {
        User LoginByUser(string eMail);
        bool AddUser(User user);
        User GetUser(int id);
        bool UpdateUser(User user);
    }
}
