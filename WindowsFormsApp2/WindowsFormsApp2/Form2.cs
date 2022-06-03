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
    public partial class Form2 : Form
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

        public Form2()
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

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    bool a = control.Name.Contains("Admin");
                    bool b = control.Name.Contains("1");
                    bool c = control.Name.Contains("2");
                    bool d = control.Name.Contains("3");

                    if (!Cache.admin)
                        this.Size = new Size(480, 190);

                    if (a == Cache.admin)
                        control.Visible = true;
                    else
                        control.Visible = false;

                    if (b)
                        control.Location = new Point(69, 50);
                    else if (c)
                        control.Location = new Point(69, 115);
                    else if (d)
                        control.Location = new Point(69, 180);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Enable_Click(object sender, EventArgs e)
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

        private void Admin_hall_Click(object sender, EventArgs e)
        {

        }

        private void User_filter_Click(object sender, EventArgs e)
        {

        }

        private void User_per_Click(object sender, EventArgs e)
        {

        }

        private void Admin_films_Click(object sender, EventArgs e)
        {

        }

        private void Admin_1_Click(object sender, EventArgs e)
        {
            EditFilms form = new EditFilms();
            form.Show();
        }

        private void Admin_2_Click(object sender, EventArgs e)
        {
            EditHalls form = new EditHalls();
            form.Show();
        }

        private void Admin_3_Click(object sender, EventArgs e)
        {
            EditPerformance form = new EditPerformance();
            form.Show();
        }

        private void User_1_Click(object sender, EventArgs e)
        {
            CheckFilms form = new CheckFilms();
            form.Show();
        }

        private void User_3_Click(object sender, EventArgs e)
        {

        }

        private void User_2_Click(object sender, EventArgs e)
        {
            Performance form = new Performance();
            form.Show();
        }
    }
}
