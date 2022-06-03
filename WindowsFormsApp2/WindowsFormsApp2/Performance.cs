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
    public partial class Performance : Form
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
        void DelControls(Panel pnl)
        {
            Control tempRef;
            for (int i = pnl.Controls.Count - 1; i >= 0; i--)
            {
                tempRef = pnl.Controls[i];
                if (tempRef is Panel)
                {
                    pnl.Controls.RemoveAt(i);
                }
            }
        }

        SqlConnection conn = new SqlConnection();
        string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\kc.mdf; Integrated Security = True; Connect Timeout = 30";
        public Performance()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelControls(panel2);

            conn.Open();

            string com = "select Film.name, Film.photo, Performance.start_date from Performance left join Film on Performance.ID_film = Film.ID_film left join Hall on Performance.ID_hall =  Hall.ID_hall left join Cinema on Hall.ID_cinema = Cinema.ID_cinema Where Performance.start_date > GETDATE()";
            if (checkBox1.Checked)
                com += " AND Cinema.name LIKE N'" + comboBox1.SelectedItem + "'";
            if (checkBox2.Checked)
                com += " AND Film.genre LIKE N'%" + textBox1.Text + "%'";
            if (checkBox3.Checked)
                com += " AND Film.regiser LIKE N'%" + textBox2.Text + "%'";
            if (checkBox4.Checked)
                com += " AND Performance.price < " + textBox3.Text + "";

            SqlCommand command = new SqlCommand(com, conn);
            command.CommandTimeout = 0;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            int k = 0;
            int top = 9, left = 16;
            while (reader.Read())
            {
                Panel panel = new Panel();
                panel.Name = "card" + k.ToString();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Height = 149;
                panel.Width = 439;
                panel.Top = top + k * 169;
                panel.Left = left;

                PictureBox picture = new PictureBox();
                Bitmap image;
                picture.Name = Convert.ToString(reader[0]);
                picture.Dock = DockStyle.Left;
                picture.Height = 116;
                image = new Bitmap(Convert.ToString(reader[1]));
                picture.Image = image;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Invalidate();

                Label label = new Label();
                label.Name = "NameFilm" + k.ToString();
                label.Font = new Font("Microsoft Sans Serif", 18);
                label.Top = 0;
                label.Left = 122;
                label.AutoSize = false;
                label.Height = 121;
                label.Width = 312;
                label.Text = Convert.ToString(reader[0]);

                Label label1 = new Label();
                label.Name = "DateFilm" + k.ToString();
                label1.Font = new Font("Microsoft Sans Serif", 10);
                label1.Top = 121;
                label1.Left = 122;
                label1.Text = Convert.ToString(reader[2]);

                panel.Controls.Add(picture);
                panel.Controls.Add(label);
                panel.Controls.Add(label1);

                this.panel2.Controls.Add(panel);
                k++;
            }

            conn.Close();
        }

        private void Performance_Load(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand command1 = new SqlCommand("SELECT name FROM [Cinema] ORDER BY name ASC", conn);
            command1.CommandTimeout = 0;
            SqlDataReader reader1;
            reader1 = command1.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader1.Read())
            {
                comboBox1.Items.Add(reader1[0].ToString());
            }

            conn.Close();
        }
    }
}
