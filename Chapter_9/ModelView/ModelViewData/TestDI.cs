using Chapter_9.ModelView.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9.ModelView.ModelViewData
{
    public class TestDI : ITestDI
    {
        public string str()
        {
            return "Value throw dependency Injection...";
        }
    }
}
