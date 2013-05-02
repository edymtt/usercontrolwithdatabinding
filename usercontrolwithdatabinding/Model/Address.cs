using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace usercontrolwithdatabinding.Model
{
    public class Address : BindableBase, IDataErrorInfo
    {
        private AddressValidator _validator;
        public Address()
        {
            _validator = new AddressValidator(this);
        }

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

        string IDataErrorInfo.Error
        {
            get { return _validator.Error; }
        }

        string IDataErrorInfo.this[string columnName]
        {
            get { return _validator[columnName]; }
        }
    }
}
