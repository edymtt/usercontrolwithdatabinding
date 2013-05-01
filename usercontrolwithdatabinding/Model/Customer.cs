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
        public Address DeliveryAddress { get; set; }
        public Address InvoiceAddress { get; set; }
        public Address DefaultAddress { get; set; }
    }
}
