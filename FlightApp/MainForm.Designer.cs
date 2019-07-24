namespace FlightApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenSimulator = new System.Windows.Forms.Button();
            this.lblCloseProgram = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(71, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Simulator";
            // 
            // btnOpenSimulator
            // 
            this.btnOpenSimulator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenSimulator.Location = new System.Drawing.Point(213, 243);
            this.btnOpenSimulator.Name = "btnOpenSimulator";
            this.btnOpenSimulator.Size = new System.Drawing.Size(174, 23);
            this.btnOpenSimulator.TabIndex = 2;
            this.btnOpenSimulator.Text = "Start";
            this.btnOpenSimulator.UseVisualStyleBackColor = true;
            this.btnOpenSimulator.Click += new System.EventHandler(this.BtnOpenSimulator_Click);
            // 
            // lblCloseProgram
            // 
            this.lblCloseProgram.AutoSize = true;
            this.lblCloseProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseProgram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCloseProgram.Location = new System.Drawing.Point(595, 9);
            this.lblCloseProgram.Name = "lblCloseProgram";
            this.lblCloseProgram.Size = new System.Drawing.Size(19, 18);
            this.lblCloseProgram.TabIndex = 4;
            this.lblCloseProgram.Text = "X";
            this.lblCloseProgram.Click += new System.EventHandler(this.LblCloseProgram_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lblCloseProgram);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 30);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 134);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(626, 300);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpenSimulator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(626, 300);
            this.MinimumSize = new System.Drawing.Size(626, 300);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenSimulator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCloseProgram;
        private System.Windows.Forms.Panel panel1;
    }
}