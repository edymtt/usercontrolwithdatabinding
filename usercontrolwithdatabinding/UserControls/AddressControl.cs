using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usercontrolwithdatabinding.Model;

namespace usercontrolwithdatabinding.UserControls
{
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }

        private Address _model=new Address();

        [Bindable(true)]
        public Address DataSource
        {
            get
            {
                return _model;
            }
            set
            {
                if (value== null) 
                {
                    value=new Address();
                }
                _model = value;
                bsAddress.DataSource = value;
            }
        }
    }
}
