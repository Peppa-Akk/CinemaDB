using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Film : Form
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

        SqlConnection conn = new SqlConnection();
        string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\kc.mdf; Integrated Security = True; Connect Timeout = 30";
        public Film()
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

            conn = new SqlConnection(ConnectionString);
        }

        private void Film_Load(object sender, EventArgs e)
        {
            Bitmap image;

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT name, photo, description, genre, regiser FROM [Film] WHERE name = N'" + Cache.film + "'", conn);
            command.CommandTimeout = 0;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                image = new Bitmap(Convert.ToString(reader["photo"]));
                pictureBox2.Image = image;
                pictureBox2.Invalidate();
                label1.Text = Convert.ToString(reader["name"]);
                label2.Text = Convert.ToString(reader["genre"]);
                label4.Text = Convert.ToString(reader["description"]);
                label3.Text = "Режиссёр: " + Convert.ToString(reader["regiser"]);
            }

            conn.Close();
        }

        private void Minimized_Enable_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Enable_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
