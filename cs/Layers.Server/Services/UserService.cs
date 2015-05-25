using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Common.Services;

namespace Layers.Server.Services
{
    public class UserService : IUserService
    {
        public void AddUser(string login, string password, string email)
        {
            //implementation of business logic
            throw new NotImplementedException();
        }

        public void RemoveUser(int id)
        {
            //implementation of business logic
            throw new NotImplementedException();
        }

        public void AssignRoles(int userId, int[] rolesIds)
        {
            //implementation of business logic
            throw new NotImplementedException();
        }
    }
}
