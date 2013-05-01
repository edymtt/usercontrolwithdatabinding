using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usercontrolwithdatabinding.Model;

namespace usercontrolwithdatabinding
{
    public partial class Form1 : Form
    {
        private Customer _model;

        public Form1()
        {
            InitializeComponent();
            _InitModel();
        }

        private void _InitModel()
        {
            _model = new Customer();
            _model.PropertyChanged += _model_PropertyChanged;
            _model.DefaultAddress.PropertyChanged += 
                DefaultAddress_PropertyChanged;
            _model.InvoiceAddress.PropertyChanged += DefaultAddress_PropertyChanged;
            _model.DeliveryAddress.PropertyChanged += DefaultAddress_PropertyChanged;
            bsCustomer.DataSource = _model;
            _SerializeModel();
        }

        void DefaultAddress_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _SerializeModel();
        }

        void _model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _SerializeModel();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            _SerializeModel();
        }

        private void _SerializeModel()
        {
            txtModel.Text = Newtonsoft.Json.JsonConvert.SerializeObject(_model, Newtonsoft.Json.Formatting.Indented);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
