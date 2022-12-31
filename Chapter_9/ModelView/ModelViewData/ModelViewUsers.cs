using Chapter_9.Model.Data;
using Chapter_9.ModelView.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Chapter_9.ModelView.ModelViewData
{
    class ModelViewUsers : IModelViewUsers
    {
        public List<Users> GetAllUsers()
        {
            List<Users> listUsers = new List<Users>();

            listUsers.Add(new Users { UserName = "Mohammed", UserDetails = "27/01/1982" });
            listUsers.Add(new Users { UserName = "Ahmed", UserDetails = "03/02/2012" });
            listUsers.Add(new Users { UserName = "Hasan", UserDetails = "05/01/2015" });
            listUsers.Add(new Users { UserName = "Ali", UserDetails = "09/04/1999" });
            listUsers.Add(new Users { UserName = "Rasha", UserDetails = "23/09/1984" });

            return listUsers;
        }

        public Users GetUser(string str)
        {
            throw new NotImplementedException();
        }
    }
}
