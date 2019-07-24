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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnExitMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblCloseProgram_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnOpenSimulator_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        //PANSBOS
        //can you see?asdasdsdasda
        //https://github.com/prg252/Project-File.git
        
    }
}
