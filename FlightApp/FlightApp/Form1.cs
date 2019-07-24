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

        int planeX = 130, planeY = 393;
        BindingSource bs = new BindingSource();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Form1 frmrst = new Form1();
            this.Hide();
            frmrst.Show();

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

        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressTravel.Maximum = 929;
            progressTravel.Minimum = 42;
            progressTravel.Value = 45;
            progressTravel.Step = 1;

            //  timer1.Interval = getPlaneSpeed(flight.FlightName1);
            //timer1.Interval = 2000;

            int tank = 200;
            try
            {
                do
                {

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

                    //200   =  201
                    if (pnlfuel.Width > tank)
                    {
                        pnlfuel.Width = pnlfuel.Width - 75;
                    }

                    progressTravel.Step = 1;
                    progressTravel.PerformStep();


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



                    if (planeX < lblEnd.Location.X)
                    {

                        planeX++;
                        progressTravel.Step = 1;
                        progressTravel.PerformStep();
                        Thread.Sleep(10);
                        lblPlane.SetBounds(planeX, planeY, 1, 1);

                        if (planeY > lblEnd.Location.Y)
                        {
                            planeY--;
                            progressTravel.Step = 1;
                            progressTravel.PerformStep();
                            Thread.Sleep(10);
                            lblPlane.SetBounds(planeX, planeY, 1, 1);

                        }

                    }

                    pnlfuel.Width = pnlfuel.Width - 2;

                } while (planeX != lblEnd.Location.X && planeY != lblEnd.Location.Y);

            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
            


        }
    }
}
