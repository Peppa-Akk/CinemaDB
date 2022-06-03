namespace WindowsFormsApp2
{
    partial class Film
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Film));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimized_Disable = new System.Windows.Forms.PictureBox();
            this.Minimized_Enable = new System.Windows.Forms.PictureBox();
            this.Exit_Disable = new System.Windows.Forms.PictureBox();
            this.Exit_Enable = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Disable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Enable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Disable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Enable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit_Enable);
            this.panel1.Controls.Add(this.Exit_Disable);
            this.panel1.Controls.Add(this.Minimized_Enable);
            this.panel1.Controls.Add(this.Minimized_Disable);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 22);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Minimized_Disable
            // 
            this.Minimized_Disable.Image = ((System.Drawing.Image)(resources.GetObject("Minimized_Disable.Image")));
            this.Minimized_Disable.Location = new System.Drawing.Point(389, 0);
            this.Minimized_Disable.Name = "Minimized_Disable";
            this.Minimized_Disable.Size = new System.Drawing.Size(23, 23);
            this.Minimized_Disable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimized_Disable.TabIndex = 15;
            this.Minimized_Disable.TabStop = false;
            this.Minimized_Disable.MouseEnter += new System.EventHandler(this.Minimized_Disable_MouseEnter);
            // 
            // Minimized_Enable
            // 
            this.Minimized_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimized_Enable.Image = ((System.Drawing.Image)(resources.GetObject("Minimized_Enable.Image")));
            this.Minimized_Enable.Location = new System.Drawing.Point(418, 0);
            this.Minimized_Enable.Name = "Minimized_Enable";
            this.Minimized_Enable.Size = new System.Drawing.Size(23, 23);
            this.Minimized_Enable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimized_Enable.TabIndex = 16;
            this.Minimized_Enable.TabStop = false;
            this.Minimized_Enable.Click += new System.EventHandler(this.Minimized_Enable_Click);
            this.Minimized_Enable.MouseLeave += new System.EventHandler(this.Minimized_Enable_MouseLeave);
            // 
            // Exit_Disable
            // 
            this.Exit_Disable.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Disable.Image")));
            this.Exit_Disable.Location = new System.Drawing.Point(447, 0);
            this.Exit_Disable.Name = "Exit_Disable";
            this.Exit_Disable.Size = new System.Drawing.Size(23, 23);
            this.Exit_Disable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Disable.TabIndex = 17;
            this.Exit_Disable.TabStop = false;
            this.Exit_Disable.MouseEnter += new System.EventHandler(this.Exit_Disable_MouseEnter);
            // 
            // Exit_Enable
            // 
            this.Exit_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Enable.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Enable.Image")));
            this.Exit_Enable.Location = new System.Drawing.Point(476, 0);
            this.Exit_Enable.Name = "Exit_Enable";
            this.Exit_Enable.Size = new System.Drawing.Size(23, 23);
            this.Exit_Enable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Enable.TabIndex = 18;
            this.Exit_Enable.TabStop = false;
            this.Exit_Enable.Click += new System.EventHandler(this.Exit_Enable_Click);
            this.Exit_Enable.MouseLeave += new System.EventHandler(this.Exit_Enable_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(295, 344);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(313, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(313, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(313, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(313, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(475, 277);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ы";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Film";
            this.Text = "Film";
            this.Load += new System.EventHandler(this.Film_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Disable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Enable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Disable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Enable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Minimized_Disable;
        private System.Windows.Forms.PictureBox Minimized_Enable;
        private System.Windows.Forms.PictureBox Exit_Disable;
        private System.Windows.Forms.PictureBox Exit_Enable;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}