using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Common.Services
{
    public interface IUserService
    {
        void AddUser(string login, string password, string email);
        void RemoveUser(int id);
        void AssignRoles(int userId, int[] rolesIds);
    }
}
