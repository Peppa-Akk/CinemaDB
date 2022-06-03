namespace WindowsFormsApp2
{
    partial class CheckFilms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckFilms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit_Enable = new System.Windows.Forms.PictureBox();
            this.Minimized_Enable = new System.Windows.Forms.PictureBox();
            this.Minimized_Disable = new System.Windows.Forms.PictureBox();
            this.Exit_Disable = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Enable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Enable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Disable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Disable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit_Enable);
            this.panel1.Controls.Add(this.Minimized_Enable);
            this.panel1.Controls.Add(this.Minimized_Disable);
            this.panel1.Controls.Add(this.Exit_Disable);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 22);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 382);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // Exit_Enable
            // 
            this.Exit_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Enable.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Enable.Image")));
            this.Exit_Enable.Location = new System.Drawing.Point(414, 0);
            this.Exit_Enable.Name = "Exit_Enable";
            this.Exit_Enable.Size = new System.Drawing.Size(23, 23);
            this.Exit_Enable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Enable.TabIndex = 14;
            this.Exit_Enable.TabStop = false;
            this.Exit_Enable.Click += new System.EventHandler(this.Exit_Enable_Click);
            this.Exit_Enable.MouseEnter += new System.EventHandler(this.Exit_Enable_MouseEnter);
            this.Exit_Enable.MouseLeave += new System.EventHandler(this.Exit_Enable_MouseLeave);
            // 
            // Minimized_Enable
            // 
            this.Minimized_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimized_Enable.Image = ((System.Drawing.Image)(resources.GetObject("Minimized_Enable.Image")));
            this.Minimized_Enable.Location = new System.Drawing.Point(270, 0);
            this.Minimized_Enable.Name = "Minimized_Enable";
            this.Minimized_Enable.Size = new System.Drawing.Size(23, 23);
            this.Minimized_Enable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimized_Enable.TabIndex = 11;
            this.Minimized_Enable.TabStop = false;
            this.Minimized_Enable.Click += new System.EventHandler(this.Minimized_Enable_Click);
            this.Minimized_Enable.MouseLeave += new System.EventHandler(this.Minimized_Enable_MouseLeave);
            // 
            // Minimized_Disable
            // 
            this.Minimized_Disable.Image = ((System.Drawing.Image)(resources.GetObject("Minimized_Disable.Image")));
            this.Minimized_Disable.Location = new System.Drawing.Point(321, 0);
            this.Minimized_Disable.Name = "Minimized_Disable";
            this.Minimized_Disable.Size = new System.Drawing.Size(23, 23);
            this.Minimized_Disable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimized_Disable.TabIndex = 12;
            this.Minimized_Disable.TabStop = false;
            this.Minimized_Disable.MouseEnter += new System.EventHandler(this.Minimized_Disable_MouseEnter);
            // 
            // Exit_Disable
            // 
            this.Exit_Disable.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Disable.Image")));
            this.Exit_Disable.Location = new System.Drawing.Point(372, -1);
            this.Exit_Disable.Name = "Exit_Disable";
            this.Exit_Disable.Size = new System.Drawing.Size(23, 23);
            this.Exit_Disable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Disable.TabIndex = 13;
            this.Exit_Disable.TabStop = false;
            this.Exit_Disable.MouseEnter += new System.EventHandler(this.Exit_Disable_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // CheckFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckFilms";
            this.Text = "CheckFilms";
            this.Load += new System.EventHandler(this.CheckFilms_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Enable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Enable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Disable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Disable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Minimized_Enable;
        private System.Windows.Forms.PictureBox Minimized_Disable;
        private System.Windows.Forms.PictureBox Exit_Disable;
        private System.Windows.Forms.PictureBox Exit_Enable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}