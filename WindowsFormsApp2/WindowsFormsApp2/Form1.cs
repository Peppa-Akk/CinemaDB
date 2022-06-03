using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Point MouseHook;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public Form1()
        {
            InitializeComponent();

            foreach (Control control in this.panel1.Controls)
            {
                if (control is PictureBox)
                {
                    bool b = control.Name.Contains("Exit");
                    bool c = control.Name.Contains("Enable");

                    if (b)
                        control.Location = new Point(this.Width - control.Width, 0);
                    else
                        control.Location = new Point(this.Width - control.Width * 2, 0);

                    if (c)
                        control.Visible = false;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Логин";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Пароль";
            textBox2.ForeColor = Color.Gray;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimized_Enable_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Minimized_Enable_MouseLeave(object sender, EventArgs e)
        {
            Minimized_Enable.Visible = false;
        }

        private void Minimized_Disable_MouseEnter(object sender, EventArgs e)
        {
            Minimized_Enable.Visible = true;
        }

        private void Exit_Enable_MouseLeave(object sender, EventArgs e)
        {
            Exit_Enable.Visible = false;
        }

        private void Exit_Disable_MouseEnter(object sender, EventArgs e)
        {
            Exit_Enable.Visible = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.Gray)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Логин";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.ForeColor == Color.Gray)
            {
                textBox2.UseSystemPasswordChar = true;
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Пароль";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cache.admin = false;
            Form2 form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Roma" && textBox2.Text == "1234")
            {
                Cache.admin = true;
                Form2 form = new Form2();
                form.Show();
            }
            else
                MessageBox.Show("Вы ввели неверные данные!", "Ошибка");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
