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
    public partial class CheckFilms : Form
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

        public CheckFilms()
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

        private void Exit_Enable_MouseEnter(object sender, EventArgs e)
        {

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

        private void CheckFilms_Load(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("select Film.name, max(start_date) as start_date, photo From Film inner join Performance on Performance.ID_film = Film.ID_film Where start_date > GETDATE() GROUP BY name, photo", conn);
            command.CommandTimeout = 0;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            int k = 0;
            int top = 9, left = 13;
            while (reader.Read())
            {
                Panel panel = new Panel();
                panel.Name = "card" + k.ToString();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Height = 372;
                panel.Width = 267;
                panel.Top = top + (k / 2) * 385;
                panel.Left = left + (k % 2) * 291;

                PictureBox picture = new PictureBox();
                Bitmap image;
                picture.Name = Convert.ToString(reader[0]);
                picture.Click += PictureOnClick;
                picture.Dock = DockStyle.Top;
                picture.Height = 242;
                image = new Bitmap(Convert.ToString(reader[2]));
                picture.Image = image;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Invalidate();

                Label label = new Label();
                label.Name = "NameFilm" + k.ToString();
                label.Font = new Font("Microsoft Sans Serif", 16);
                label.Top = 245;
                label.Left = 3;
                label.AutoSize = false;
                label.Height = 98;
                label.Width = 262;
                label.Text = Convert.ToString(reader[0]);

                Label label1 = new Label();
                label.Name = "DateFilm" + k.ToString();
                label1.Font = new Font("Microsoft Sans Serif", 12);
                label1.Top = 343;
                label1.Left = 3; 
                label1.AutoSize = false;
                label1.Height = 22;
                label1.Width = 262;
                label1.Text = "До " + Convert.ToString(reader[1]);

                panel.Controls.Add(picture);
                panel.Controls.Add(label);
                panel.Controls.Add(label1);

                this.panel2.Controls.Add(panel);
                k++;
            }

            conn.Close();
        }

        private void PictureOnClick(object sender, EventArgs e)
        {
            var picture = (PictureBox)sender;
            Cache.film = picture.Name;

            Film film = new Film();
            film.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
