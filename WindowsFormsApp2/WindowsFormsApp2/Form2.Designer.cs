namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimized_Enable = new System.Windows.Forms.PictureBox();
            this.Exit_Enable = new System.Windows.Forms.PictureBox();
            this.Exit_Disable = new System.Windows.Forms.PictureBox();
            this.Minimized_Disable = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.User_1 = new System.Windows.Forms.Button();
            this.User_2 = new System.Windows.Forms.Button();
            this.Admin_1 = new System.Windows.Forms.Button();
            this.Admin_2 = new System.Windows.Forms.Button();
            this.Admin_3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Enable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Enable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Disable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Disable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Minimized_Enable
            // 
            this.Minimized_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimized_Enable.Image = ((System.Drawing.Image)(resources.GetObject("Minimized_Enable.Image")));
            this.Minimized_Enable.Location = new System.Drawing.Point(173, -1);
            this.Minimized_Enable.Name = "Minimized_Enable";
            this.Minimized_Enable.Size = new System.Drawing.Size(23, 23);
            this.Minimized_Enable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimized_Enable.TabIndex = 10;
            this.Minimized_Enable.TabStop = false;
            this.Minimized_Enable.Click += new System.EventHandler(this.Minimized_Enable_Click);
            this.Minimized_Enable.MouseLeave += new System.EventHandler(this.Minimized_Enable_MouseLeave);
            // 
            // Exit_Enable
            // 
            this.Exit_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Enable.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Enable.Image")));
            this.Exit_Enable.Location = new System.Drawing.Point(361, 0);
            this.Exit_Enable.Name = "Exit_Enable";
            this.Exit_Enable.Size = new System.Drawing.Size(23, 23);
            this.Exit_Enable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Enable.TabIndex = 9;
            this.Exit_Enable.TabStop = false;
            this.Exit_Enable.Click += new System.EventHandler(this.Exit_Enable_Click);
            this.Exit_Enable.MouseLeave += new System.EventHandler(this.Exit_Enable_MouseLeave);
            // 
            // Exit_Disable
            // 
            this.Exit_Disable.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Disable.Image")));
            this.Exit_Disable.Location = new System.Drawing.Point(299, -1);
            this.Exit_Disable.Name = "Exit_Disable";
            this.Exit_Disable.Size = new System.Drawing.Size(23, 23);
            this.Exit_Disable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Disable.TabIndex = 12;
            this.Exit_Disable.TabStop = false;
            this.Exit_Disable.MouseEnter += new System.EventHandler(this.Exit_Disable_MouseEnter);
            // 
            // Minimized_Disable
            // 
            this.Minimized_Disable.Image = ((System.Drawing.Image)(resources.GetObject("Minimized_Disable.Image")));
            this.Minimized_Disable.Location = new System.Drawing.Point(232, -1);
            this.Minimized_Disable.Name = "Minimized_Disable";
            this.Minimized_Disable.Size = new System.Drawing.Size(23, 23);
            this.Minimized_Disable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimized_Disable.TabIndex = 11;
            this.Minimized_Disable.TabStop = false;
            this.Minimized_Disable.MouseEnter += new System.EventHandler(this.Minimized_Disable_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Minimized_Enable);
            this.panel1.Controls.Add(this.Exit_Enable);
            this.panel1.Controls.Add(this.Minimized_Disable);
            this.panel1.Controls.Add(this.Exit_Disable);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 22);
            this.panel1.TabIndex = 13;
            // 
            // User_1
            // 
            this.User_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_1.Location = new System.Drawing.Point(121, 66);
            this.User_1.Name = "User_1";
            this.User_1.Size = new System.Drawing.Size(359, 40);
            this.User_1.TabIndex = 13;
            this.User_1.Text = "Просмотр фильмов";
            this.User_1.UseVisualStyleBackColor = true;
            this.User_1.Click += new System.EventHandler(this.User_1_Click);
            // 
            // User_2
            // 
            this.User_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_2.Location = new System.Drawing.Point(121, 134);
            this.User_2.Name = "User_2";
            this.User_2.Size = new System.Drawing.Size(359, 40);
            this.User_2.TabIndex = 14;
            this.User_2.Text = "Выбор сеанса";
            this.User_2.UseVisualStyleBackColor = true;
            this.User_2.Click += new System.EventHandler(this.User_2_Click);
            // 
            // Admin_1
            // 
            this.Admin_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admin_1.Location = new System.Drawing.Point(0, 28);
            this.Admin_1.Name = "Admin_1";
            this.Admin_1.Size = new System.Drawing.Size(359, 40);
            this.Admin_1.TabIndex = 16;
            this.Admin_1.Text = "Редактирование фильмов";
            this.Admin_1.UseVisualStyleBackColor = true;
            this.Admin_1.Click += new System.EventHandler(this.Admin_1_Click);
            // 
            // Admin_2
            // 
            this.Admin_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admin_2.Location = new System.Drawing.Point(0, 101);
            this.Admin_2.Name = "Admin_2";
            this.Admin_2.Size = new System.Drawing.Size(359, 40);
            this.Admin_2.TabIndex = 17;
            this.Admin_2.Text = "Редактирование залов";
            this.Admin_2.UseVisualStyleBackColor = true;
            this.Admin_2.Click += new System.EventHandler(this.Admin_2_Click);
            // 
            // Admin_3
            // 
            this.Admin_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admin_3.Location = new System.Drawing.Point(0, 169);
            this.Admin_3.Name = "Admin_3";
            this.Admin_3.Size = new System.Drawing.Size(359, 40);
            this.Admin_3.TabIndex = 18;
            this.Admin_3.Text = "Редактирование сеансов";
            this.Admin_3.UseVisualStyleBackColor = true;
            this.Admin_3.Click += new System.EventHandler(this.Admin_3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 258);
            this.Controls.Add(this.Admin_3);
            this.Controls.Add(this.Admin_2);
            this.Controls.Add(this.Admin_1);
            this.Controls.Add(this.User_2);
            this.Controls.Add(this.User_1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Enable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Enable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Disable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Disable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Minimized_Enable;
        private System.Windows.Forms.PictureBox Exit_Enable;
        private System.Windows.Forms.PictureBox Exit_Disable;
        private System.Windows.Forms.PictureBox Minimized_Disable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button User_1;
        private System.Windows.Forms.Button User_2;
        private System.Windows.Forms.Button Admin_1;
        private System.Windows.Forms.Button Admin_2;
        private System.Windows.Forms.Button Admin_3;
    }
}