using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FlightApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int planeX = 39, planeY = 510;
        int obstical1_X = 248, obstical1_Y = 233;
        int obstical2_X = 456, obstical2_Y = 418;
        int obstical3_X = 838, obstical3_Y = 339;
        int obstical4_X = 634, obstical4_Y = 91;
        //Thread myStart = new Thread();


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //x 39 ; y 510
            //ob1x 248 ; ob1y 418
            

            while (planeX < label3.Location.X)
            {
                planeX++;
                Thread.Sleep(10);
                label1.SetBounds(planeX, planeY, 1, 1);
                while (planeY > label3.Location.Y)
                {
                    planeY--;
                    Thread.Sleep(10);
                    label1.SetBounds(planeX, planeY, 1, 1);
                }

            }

            
            


        }
    }
}
