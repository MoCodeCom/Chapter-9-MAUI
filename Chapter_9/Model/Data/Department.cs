using Chapter_9.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9.Model.Data
{
    class Department : IDepartment
    {
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
    }
}
