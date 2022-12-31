using Chapter_9.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9.Model.Data
{
    class Users : IUsers
    {
        public string UserName { get; set; }
        public string UserDetails { get; set; }
    }
}
