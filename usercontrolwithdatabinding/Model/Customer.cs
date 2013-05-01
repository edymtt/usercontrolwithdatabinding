using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usercontrolwithdatabinding.Model
{
    class Customer : BindableBase
    {
        private string _firstName;
        public string FirstName {
            get
            {
                return _firstName;
            }
            set
            {
                SetProperty(ref _firstName, value);
            }
        }

        private string _lastName;
        public string LastName {
            get
            {
                return _lastName;
            }
            set
            {
                SetProperty(ref _lastName, value);
            }
        }

        private string _title;
        public string Title {
            get
            {
                return _title;
            }
            set
            {
                SetProperty(ref _title, value);
            }
        }


        private Address _DeliveryAddress = new Address();
        public Address DeliveryAddress
        {
            get
            {
                return _DeliveryAddress;
            }
            set
            {
                _DeliveryAddress = value;
            }
        }


        private Address _InvoiceAddress = new Address();
        public Address InvoiceAddress
        {
            get
            {
                return _InvoiceAddress;
            }
            set
            {
                _InvoiceAddress = value;
            }
        }


        private Address _defaultAddress=new Address();
        public Address DefaultAddress {
            get
        {
                return _defaultAddress;
            } 
            set
            {
                _defaultAddress = value;
            }
        }
    }
}
