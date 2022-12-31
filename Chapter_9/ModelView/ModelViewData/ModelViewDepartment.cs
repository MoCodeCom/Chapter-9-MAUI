using Chapter_9.Model.Data;
using Chapter_9.ModelView.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9.ModelView.ModelViewData
{
    class ModelViewDepartment : IModelViewDepartment
    {
        public List<Department> GetAllDepartment()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { DepartmentName="Management Department", DepartmentCode = "A1001"});
            list.Add(new Department { DepartmentName = "Accountant Department", DepartmentCode = "F9905" });
            list.Add(new Department { DepartmentName = "Planning Department", DepartmentCode = "C2301" });

            return list;
        }

        public Department GetDepartment()
        {
            throw new NotImplementedException();
        }
    }
}
