using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usercontrolwithdatabinding.UserControls
{
    public partial class NameControl : UserControl
    {
        public NameControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e);
        }

        public event EventHandler TextChanged;

        [Bindable(true)]
        public string Text
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
    }
}
