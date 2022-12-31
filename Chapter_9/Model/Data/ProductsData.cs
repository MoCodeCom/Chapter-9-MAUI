using Chapter_9.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9.Model.Data
{
    public class ProductsData : IProducts, INotifyPropertyChanged
    {
        private string _Name;
        private string _Number;
        public string Name
        {
            get
            {
                return _Name;
            }
            /*
             set
            {
                 _Name = value;
                 OnPropertyChange("Name");
            }
             */
            set
            {
                if (!value.Equals(Name, StringComparison.Ordinal))
                {
                    _Name = value;
                    OnPropertyChange("Name");
                }
            }
        }
        public string Number
        {
            get { return _Number; }
            set
            {
                /*
            set
            {
                 _Name = value;
                 OnPropertyChange("Name");
            }
             */
                if (!value.Equals(Number, StringComparison.Ordinal))
                {
                    _Number = value;
                    OnPropertyChange("Number");
                }
                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChange([CallerMemberName]string str=null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(str));
            }
        }

        /*
         
        public void OnPropertyChange(string str)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(str));
            }
        }
         
         */
    }
}
