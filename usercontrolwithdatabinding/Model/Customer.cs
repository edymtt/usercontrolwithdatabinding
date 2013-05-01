using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usercontrolwithdatabinding.Model
{
    class Customer : NotificationObject
    {
        private string _firstName;
        public string FirstName {
            get
            {
                return _firstName;
            }
            set
            { 
                if(! String.Equals(value,_firstName))
                {
                    _firstName = value;
                    RaisePropertyChanged(() => this.FirstName);
                }
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
                if (!String.Equals(value, _lastName))
                {
                    _lastName = value;
                    RaisePropertyChanged(() => this.LastName);
                }
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
                if (!String.Equals(value, _title))
                {
                    _title = value;
                    RaisePropertyChanged(() => this.Title);
                }
            }
        }
        public Address DeliveryAddress { get; set; }
        public Address InvoiceAddress { get; set; }
        public Address DefaultAddress { get; set; }
    }
}
