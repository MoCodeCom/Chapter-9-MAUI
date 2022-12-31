using Chapter_9.Model.Data;
using Chapter_9.ModelView.Interfaces;
using Chapter_9.ModelView.ModelViewData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chapter_9.ModelView.DependencyInjectionExtention
{
    class MainPageModel
    {
  
        public string strMP { get; set; }
        public MainPageModel( ITestDI itd)
        {
            
            strMP = itd.str();
        }

        
    }
}
