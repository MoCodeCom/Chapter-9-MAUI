using Chapter_9.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9.ModelView.Interfaces
{
    interface IModelViewUsers
    {
        List<Users> GetAllUsers();
        Users GetUser(string str);
    }
}
