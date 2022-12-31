using Chapter_9.Model.Interfaces;
using Chapter_9.ModelView.Interfaces;
using Chapter_9.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9.ModelView.DepandencyInjectionClasses
{
    // Implement Dependecy injection (constructor way) on user data by class below
    class UsersDependencyInjection
    {
        private IModelViewUsers _users;
        public UsersDependencyInjection(IModelViewUsers users)
        {
            _users = users;
        }

        public List<Users> GetUsersListByDI()
        {
            return _users.GetAllUsers();
        }
    }
}
