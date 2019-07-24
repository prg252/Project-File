using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightApp
{
    public partial class ResultsForm : Form
    {
        BindingSource bs = new BindingSource();
       
        public ResultsForm(int idFlight)
        {
            InitializeComponent();
            //bs.DataSource = flightDetails.getSelectedFlight(1);\
            FlightDetails flight = new FlightDetails();
            bs.DataSource = flight.getSelectedFlight(idFlight);
            txtName.Text = bs.DataMember = "Name";
            txtFuel.Text = bs.DataMember = "Fuel";
            txtSpeed.Text = bs.DataMember = "Speed";




        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
           // FlightDetails idflightdeets = new FlightDetails()
        }
    }
}
