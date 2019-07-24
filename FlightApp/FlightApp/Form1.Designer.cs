namespace FlightApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPlane = new System.Windows.Forms.Label();
            this.lblObsticale1 = new System.Windows.Forms.Label();
            this.lblObsticale2 = new System.Windows.Forms.Label();
            this.lblObsticale3 = new System.Windows.Forms.Label();
            this.lblObsticale4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblEnd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressFuel = new System.Windows.Forms.ProgressBar();
            this.progressTravel = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.choosePlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boeing737ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boeing891ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.challengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boeing747ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airBusA335ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlane
            // 
            this.lblPlane.AutoSize = true;
            this.lblPlane.BackColor = System.Drawing.Color.Aqua;
            this.lblPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlane.Location = new System.Drawing.Point(130, 393);
            this.lblPlane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlane.Name = "lblPlane";
            this.lblPlane.Size = new System.Drawing.Size(45, 18);
            this.lblPlane.TabIndex = 0;
            this.lblPlane.Text = "Plane";
            // 
            // lblObsticale1
            // 
            this.lblObsticale1.AutoSize = true;
            this.lblObsticale1.BackColor = System.Drawing.Color.Red;
            this.lblObsticale1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsticale1.Location = new System.Drawing.Point(306, 246);
            this.lblObsticale1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObsticale1.Name = "lblObsticale1";
            this.lblObsticale1.Size = new System.Drawing.Size(82, 18);
            this.lblObsticale1.TabIndex = 1;
            this.lblObsticale1.Text = "Obsticale 1";
            // 
            // lblObsticale2
            // 
            this.lblObsticale2.AutoSize = true;
            this.lblObsticale2.BackColor = System.Drawing.Color.Red;
            this.lblObsticale2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsticale2.Location = new System.Drawing.Point(419, 190);
            this.lblObsticale2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObsticale2.Name = "lblObsticale2";
            this.lblObsticale2.Size = new System.Drawing.Size(82, 18);
            this.lblObsticale2.TabIndex = 2;
            this.lblObsticale2.Text = "Obsticale 2";
            // 
            // lblObsticale3
            // 
            this.lblObsticale3.AutoSize = true;
            this.lblObsticale3.BackColor = System.Drawing.Color.Red;
            this.lblObsticale3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsticale3.Location = new System.Drawing.Point(183, 139);
            this.lblObsticale3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObsticale3.Name = "lblObsticale3";
            this.lblObsticale3.Size = new System.Drawing.Size(82, 18);
            this.lblObsticale3.TabIndex = 3;
            this.lblObsticale3.Text = "Obsticale 3";
            // 
            // lblObsticale4
            // 
            this.lblObsticale4.AutoSize = true;
            this.lblObsticale4.BackColor = System.Drawing.Color.Red;
            this.lblObsticale4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsticale4.Location = new System.Drawing.Point(373, 102);
            this.lblObsticale4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObsticale4.Name = "lblObsticale4";
            this.lblObsticale4.Size = new System.Drawing.Size(82, 18);
            this.lblObsticale4.TabIndex = 4;
            this.lblObsticale4.Text = "Obsticale 4";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.GreenYellow;
            this.lblEnd.Location = new System.Drawing.Point(729, 42);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(117, 18);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "End of Obsticale";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 33);
            this.panel1.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(978, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(19, 18);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(847, 372);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 29);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Refresh Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(847, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Check Results";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // progressFuel
            // 
            this.progressFuel.Location = new System.Drawing.Point(376, 435);
            this.progressFuel.Name = "progressFuel";
            this.progressFuel.Size = new System.Drawing.Size(212, 23);
            this.progressFuel.TabIndex = 11;
            // 
            // progressTravel
            // 
            this.progressTravel.Location = new System.Drawing.Point(376, 464);
            this.progressTravel.Name = "progressTravel";
            this.progressTravel.Size = new System.Drawing.Size(212, 23);
            this.progressTravel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(330, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fuel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(297, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Progress:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choosePlaneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // choosePlaneToolStripMenuItem
            // 
            this.choosePlaneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boeing737ToolStripMenuItem,
            this.boeing891ToolStripMenuItem,
            this.challengerToolStripMenuItem,
            this.boeing747ToolStripMenuItem,
            this.airBusA335ToolStripMenuItem});
            this.choosePlaneToolStripMenuItem.Name = "choosePlaneToolStripMenuItem";
            this.choosePlaneToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.choosePlaneToolStripMenuItem.Text = "Choose Plane";
            // 
            // boeing737ToolStripMenuItem
            // 
            this.boeing737ToolStripMenuItem.Name = "boeing737ToolStripMenuItem";
            this.boeing737ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.boeing737ToolStripMenuItem.Text = "Boeing737";
            this.boeing737ToolStripMenuItem.Click += new System.EventHandler(this.Boeing737ToolStripMenuItem_Click);
            // 
            // boeing891ToolStripMenuItem
            // 
            this.boeing891ToolStripMenuItem.Name = "boeing891ToolStripMenuItem";
            this.boeing891ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.boeing891ToolStripMenuItem.Text = "Boeing891";
            this.boeing891ToolStripMenuItem.Click += new System.EventHandler(this.Boeing891ToolStripMenuItem_Click);
            // 
            // challengerToolStripMenuItem
            // 
            this.challengerToolStripMenuItem.Name = "challengerToolStripMenuItem";
            this.challengerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.challengerToolStripMenuItem.Text = "Challenger";
            this.challengerToolStripMenuItem.Click += new System.EventHandler(this.ChallengerToolStripMenuItem_Click);
            // 
            // boeing747ToolStripMenuItem
            // 
            this.boeing747ToolStripMenuItem.Name = "boeing747ToolStripMenuItem";
            this.boeing747ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.boeing747ToolStripMenuItem.Text = "Boeing747";
            this.boeing747ToolStripMenuItem.Click += new System.EventHandler(this.Boeing747ToolStripMenuItem_Click);
            // 
            // airBusA335ToolStripMenuItem
            // 
            this.airBusA335ToolStripMenuItem.Name = "airBusA335ToolStripMenuItem";
            this.airBusA335ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.airBusA335ToolStripMenuItem.Text = "AirBus A335";
            this.airBusA335ToolStripMenuItem.Click += new System.EventHandler(this.AirBusA335ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressTravel);
            this.Controls.Add(this.progressFuel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblObsticale4);
            this.Controls.Add(this.lblObsticale3);
            this.Controls.Add(this.lblObsticale2);
            this.Controls.Add(this.lblObsticale1);
            this.Controls.Add(this.lblPlane);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlane;
        private System.Windows.Forms.Label lblObsticale1;
        private System.Windows.Forms.Label lblObsticale2;
        private System.Windows.Forms.Label lblObsticale3;
        private System.Windows.Forms.Label lblObsticale4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressFuel;
        private System.Windows.Forms.ProgressBar progressTravel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem choosePlaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boeing737ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boeing891ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem challengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boeing747ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airBusA335ToolStripMenuItem;
    }
}