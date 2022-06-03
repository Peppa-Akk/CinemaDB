namespace WindowsFormsApp2
{
    partial class EditPerformance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPerformance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimized_Enable = new System.Windows.Forms.PictureBox();
            this.Exit_Enable = new System.Windows.Forms.PictureBox();
            this.Exit_Disable = new System.Windows.Forms.PictureBox();
            this.Minimized_Disable = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Enable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Enable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Disable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Disable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Minimized_Enable);
            this.panel1.Controls.Add(this.Exit_Enable);
            this.panel1.Controls.Add(this.Exit_Disable);
            this.panel1.Controls.Add(this.Minimized_Disable);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 22);
            this.panel1.TabIndex = 0;
            // 
            // Minimized_Enable
            // 
            this.Minimized_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimized_Enable.Image = ((System.Drawing.Image)(resources.GetObject("Minimized_Enable.Image")));
            this.Minimized_Enable.Location = new System.Drawing.Point(389, 0);
            this.Minimized_Enable.Name = "Minimized_Enable";
            this.Minimized_Enable.Size = new System.Drawing.Size(23, 23);
            this.Minimized_Enable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimized_Enable.TabIndex = 13;
            this.Minimized_Enable.TabStop = false;
            this.Minimized_Enable.Click += new System.EventHandler(this.Minimized_Enable_Click);
            this.Minimized_Enable.MouseLeave += new System.EventHandler(this.Minimized_Enable_MouseLeave);
            // 
            // Exit_Enable
            // 
            this.Exit_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Enable.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Enable.Image")));
            this.Exit_Enable.Location = new System.Drawing.Point(486, 0);
            this.Exit_Enable.Name = "Exit_Enable";
            this.Exit_Enable.Size = new System.Drawing.Size(23, 23);
            this.Exit_Enable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Enable.TabIndex = 16;
            this.Exit_Enable.TabStop = false;
            this.Exit_Enable.Click += new System.EventHandler(this.Exit_Enable_Click);
            this.Exit_Enable.MouseLeave += new System.EventHandler(this.Exit_Enable_MouseLeave);
            // 
            // Exit_Disable
            // 
            this.Exit_Disable.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Disable.Image")));
            this.Exit_Disable.Location = new System.Drawing.Point(457, -1);
            this.Exit_Disable.Name = "Exit_Disable";
            this.Exit_Disable.Size = new System.Drawing.Size(23, 23);
            this.Exit_Disable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Disable.TabIndex = 15;
            this.Exit_Disable.TabStop = false;
            this.Exit_Disable.Click += new System.EventHandler(this.Exit_Disable_Click);
            this.Exit_Disable.MouseEnter += new System.EventHandler(this.Exit_Disable_MouseEnter);
            // 
            // Minimized_Disable
            // 
            this.Minimized_Disable.Image = ((System.Drawing.Image)(resources.GetObject("Minimized_Disable.Image")));
            this.Minimized_Disable.Location = new System.Drawing.Point(418, 0);
            this.Minimized_Disable.Name = "Minimized_Disable";
            this.Minimized_Disable.Size = new System.Drawing.Size(23, 23);
            this.Minimized_Disable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimized_Disable.TabIndex = 14;
            this.Minimized_Disable.TabStop = false;
            this.Minimized_Disable.MouseEnter += new System.EventHandler(this.Minimized_Disable_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(508, 146);
            this.maskedTextBox1.Mask = "00:00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(90, 31);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 31);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(294, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Выберите кинотеатр: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Выберите кинозал: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Выберите фильм: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Выберите дату и время: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Введите цену: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(353, 33);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(167, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(240, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "б.р.";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(229, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(369, 33);
            this.comboBox2.TabIndex = 25;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(209, 107);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(389, 33);
            this.comboBox3.TabIndex = 26;
            // 
            // EditPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 228);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPerformance";
            this.Text = "EditPerformance";
            this.Load += new System.EventHandler(this.EditPerformance_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Enable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Enable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Disable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Disable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Minimized_Enable;
        private System.Windows.Forms.PictureBox Minimized_Disable;
        private System.Windows.Forms.PictureBox Exit_Disable;
        private System.Windows.Forms.PictureBox Exit_Enable;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}