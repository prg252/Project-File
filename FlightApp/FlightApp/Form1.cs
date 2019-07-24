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

        //int planeX = 39, planeY = 510;
        int planeX = 130, planeY = 393;

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

            //while (planeX < label2.Location.X - 50)
            //{
            //    planeX++;
            //    Thread.Sleep(10);
            //    label1.SetBounds(planeX, planeY, 1, 1);
            //    while (planeY > label2.Location.Y - 20)
            //    {
            //        planeY--;
            //        Thread.Sleep(10);
            //        label1.SetBounds(planeX, planeY, 1, 1);
            //    }

            //}


            do
            {

                if (planeX < label7.Location.X )
                {
                    label1.SetBounds(planeX, planeY, 1, 1);
                    planeX++;
                    
                    Thread.Sleep(10);

                    if (planeY > label7.Location.Y )
                    {
                        planeY--;
                        Thread.Sleep(10);
                        label1.SetBounds(planeX, planeY, 1, 1);
                    }
                }

                while (planeX < label2.Location.X - 50)
                {
                    planeX++;
                    Thread.Sleep(10);
                    label1.SetBounds(planeX, planeY, 1, 1);
                    while (planeY > label2.Location.Y - 10)
                    {
                        planeY--;
                        Thread.Sleep(10);
                        label1.SetBounds(planeX, planeY, 1, 1);
                    }

                }



                while (planeX < label3.Location.X - 5)
                {
                    planeX++;
                    Thread.Sleep(10);
                    label1.SetBounds(planeX, planeY, 1, 1);
                    while (planeY > label3.Location.Y - 25)
                    {
                        planeY--;
                        Thread.Sleep(10);
                        label1.SetBounds(planeX, planeY, 1, 1);
                    }

                }

                while (planeX < label5.Location.X - 50)
                {
                    planeX++;
                    Thread.Sleep(10);
                    label1.SetBounds(planeX, planeY, 1, 1);
                    while (planeY > label5.Location.Y - 20)
                    {
                        planeY--;
                        Thread.Sleep(10);
                        label1.SetBounds(planeX, planeY, 1, 1);
                    }

                }


                //x=729
                //y=42
                //x39
                //y510

            } while (planeX != label7.Location.X && planeY != label7.Location.Y );

            //MessageBox.Show("Flight landed safelty.");

        }
    }
}
