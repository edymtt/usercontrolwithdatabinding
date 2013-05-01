using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usercontrolwithdatabinding.Model
{
    public class Address : BindableBase
    {
        private string _street;
        public string Street { 
            get
            {
                return _street;
            } 
            set
            {
                SetProperty(ref _street, value);
            }
        }

        private string _city;
        public string City {
            get
            {
                return _city;
            }
            set
            {
                SetProperty(ref _city, value);
            }
        }
    }
}
