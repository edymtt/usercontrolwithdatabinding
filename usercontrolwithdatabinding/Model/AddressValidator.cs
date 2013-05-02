using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace usercontrolwithdatabinding.Model
{
    class AddressValidator : IDataErrorInfo
    {
        private static string _streetProperty;
        private static string _cityProperty;
        
        private const string _errorValue = "error";
        private Address _address;
        public AddressValidator(Address address)
        {
            _address = address;
            _streetProperty=PropertySupport.ExtractPropertyName(() => _address.Street);
            _cityProperty = PropertySupport.ExtractPropertyName(() => _address.City);
        }

        public string Error
        {
            get { return null; }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == _streetProperty)
                {
                    if (_address.Street == _errorValue)
                    {
                        return _errorValue;
                    }
                }
                if (columnName == _cityProperty)
                {
                    if (_address.City == _errorValue)
                    {
                        return _errorValue;
                    }
                }
               
                return null;
            }
        }
    }
}
