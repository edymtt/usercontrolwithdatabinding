using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace usercontrolwithdatabinding.Model
{
    class CustomerValidator : IDataErrorInfo
    {

        private static string _titleProperty;
        private static string _firstNameProperty;
        private static string _lastNameProperty;
        private const string _errorValue = "error";
        private Customer _customer;
        public CustomerValidator(Customer customer)
        {
            _customer = customer;
            _titleProperty=PropertySupport.ExtractPropertyName(() => _customer.Title);
            _firstNameProperty = PropertySupport.ExtractPropertyName(() => _customer.FirstName);
            _lastNameProperty = PropertySupport.ExtractPropertyName(() => _customer.LastName);
        }

        public string Error
        {
            get { return null; }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == _titleProperty)
                {
                    if (_customer.Title == _errorValue)
                    {
                        return _errorValue;
                    }
                }
                if (columnName == _firstNameProperty)
                {
                    if (_customer.FirstName == _errorValue)
                    {
                        return _errorValue;
                    }
                }
                if (columnName == _lastNameProperty)
                {
                    if (_customer.LastName == _errorValue)
                    {
                        return _errorValue;
                    }
                }

                return null;
            }
        }
    }
}
