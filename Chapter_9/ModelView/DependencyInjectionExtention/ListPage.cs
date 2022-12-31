using Chapter_9.Model.Data;
using Chapter_9.ModelView.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9.ModelView.DependencyInjectionExtention
{
    internal class ListPage
    {
        public List<Department> lstDepartment { get; set; }
        public ListPage(IModelViewDepartment ivd)
        {
            lstDepartment = ivd.GetAllDepartment();
        }
    }
}
