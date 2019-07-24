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
        BindingSource bs = new BindingSource();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

       

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Boeing737ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void Boeing891ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 30;
            timer1.Start();
        }

        private void ChallengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 400;
            timer1.Start();
        }

        private void Boeing747ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void AirBusA335ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 150;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           
            progressFuel.Maximum = lblEnd.Location.X + lblEnd.Location.Y;
            progressTravel.Minimum = lblPlane.Location.X + lblPlane.Location.Y;
            progressTravel.Value = lblPlane.Location.X + lblPlane.Location.Y;
            progressTravel.Step = 1;
            //  timer1.Interval = getPlaneSpeed(flight.FlightName1);
            timer1.Interval = 2000;
            
            do
            {

                if (planeX < lblEnd.Location.X )
                {
                    lblPlane.SetBounds(planeX, planeY, 1, 1);
                    planeX++;
                    progressTravel.Step = 1;
                    progressTravel.PerformStep();
                    Thread.Sleep(10);

                    if (planeY > lblEnd.Location.Y )
                    {
                        planeY--;
                        progressTravel.Step = 1;
                        progressTravel.PerformStep();
                        Thread.Sleep(10);
                        lblPlane.SetBounds(planeX, planeY, 1, 1);
                    }
                }

                while (planeX < lblObsticale1.Location.X - 50)
                {
                    planeX++;
                    progressTravel.Step = 1;
                    progressTravel.PerformStep();
                    Thread.Sleep(10);
                    lblPlane.SetBounds(planeX, planeY, 1, 1);
                    while (planeY > lblObsticale1.Location.Y - 10)
                    {
                        planeY--;
                        progressTravel.Step = 1;
                        progressTravel.PerformStep();
                        Thread.Sleep(10);
                        lblPlane.SetBounds(planeX, planeY, 1, 1);
                    }

                }



                while (planeX < lblObsticale2.Location.X - 5)
                {
                    planeX++;
                    progressTravel.PerformStep();
                    progressTravel.Step = 1;
                    Thread.Sleep(10);
                    lblPlane.SetBounds(planeX, planeY, 1, 1);
                    while (planeY > lblObsticale2.Location.Y - 25)
                    {
                        planeY--;
                        progressTravel.Step = 1;
                        progressTravel.PerformStep();
                        Thread.Sleep(10);
                        lblPlane.SetBounds(planeX, planeY, 1, 1);
                    }

                }

                while (planeX < lblObsticale4.Location.X - 50)
                {
                    planeX++;
                    progressTravel.Step = 1;
                    progressTravel.PerformStep();
                    Thread.Sleep(10);
                    lblPlane.SetBounds(planeX, planeY, 1, 1);
                    while (planeY > lblObsticale4.Location.Y - 20)
                    {
                        planeY--;
                        progressTravel.Step = 1;
                        progressTravel.PerformStep();
                        Thread.Sleep(10);
                        lblPlane.SetBounds(planeX, planeY, 1, 1);
                    }

                }


                //x=729
                //y=42
                //x39
                //y510

            } while (planeX != lblEnd.Location.X && planeY != lblEnd.Location.Y );

            //MessageBox.Show("Flight landed safelty.");

        }
    }
}
