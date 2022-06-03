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
    public partial class EditFilms : Form
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

        public EditFilms()
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

            comboBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Top = pictureBox2.Top;
            comboBox1.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel2.Top = pictureBox3.Top;
            comboBox1.Visible = true;
            button3.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = true;

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT name FROM [Film] ORDER BY name ASC", conn);
            command.CommandTimeout = 0;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Height = 35 + 29 * (textBox1.Text.Length / 27);
            textBox2.Top = 47 + 29 * (textBox1.Text.Length / 27);
            label1.Top = 126 + 29 * (textBox1.Text.Length / 27);
            maskedTextBox1.Top = 154 + 29 * (textBox1.Text.Length / 27);
            textBox4.Top = 88 + 29 * (textBox1.Text.Length / 27);
        }

        private void EditFilms_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Название";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Жанр";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Описание";
            textBox3.ForeColor = Color.Gray;
            textBox4.Text = "Режиссёр";
            textBox4.ForeColor = Color.Gray;
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
                textBox1.Text = "Название";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.ForeColor == Color.Gray)
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Жанр";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.ForeColor == Color.Gray)
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Описание";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image;

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    Cache.photo_path = open_dialog.FileName;
                    pictureBox4.Image = image;
                    pictureBox4.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand dobcommand = new SqlCommand("INSERT INTO [Film] (name, photo, description, genre, regiser, time_h, time_m)VALUES(@name, @photo, @description, @genre, @regiser, @time_h, @time_m)", conn);

            dobcommand.Parameters.AddWithValue("name", textBox1.Text);
            dobcommand.Parameters.AddWithValue("photo", Cache.photo_path);
            dobcommand.Parameters.AddWithValue("description", textBox3.Text);
            dobcommand.Parameters.AddWithValue("genre", textBox2.Text);
            dobcommand.Parameters.AddWithValue("regiser", textBox4.Text);
            dobcommand.Parameters.AddWithValue("time_h", maskedTextBox1.Text.Substring(0, 2));
            dobcommand.Parameters.AddWithValue("time_m", maskedTextBox1.Text.Substring(3, 2));

            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox1.Text == "" || maskedTextBox1.Text == "  :  :")
                MessageBox.Show("Ошибка, не введён один из параметров!");
            else
            {
                dobcommand.ExecuteNonQuery();
                MessageBox.Show("Фильм " + textBox1.Text + " успешно добавлен в библиотеку!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                maskedTextBox1.Text = "  :  :";
                pictureBox4.Image = null;
            }
            conn.Close();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.ForeColor == Color.Gray)
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Режиссёр";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Height = 35 + 29 * (textBox2.Text.Length / 27);
            label1.Top = 126 + 29 * (textBox2.Text.Length / 27);
            maskedTextBox1.Top = 154 + 29 * (textBox2.Text.Length / 27);
            textBox4.Top = 88 + 29 * (textBox2.Text.Length / 27);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Height = 35 + 29 * (textBox4.Text.Length / 27);
            label1.Top = 126 + 29 * (textBox4.Text.Length / 27);
            maskedTextBox1.Top = 154 + 29 * (textBox4.Text.Length / 27);
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox4.Image = null;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Bitmap image;

            conn.Open();
            
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Film] WHERE name = N'" + comboBox1.SelectedItem.ToString() + "'", conn);
            try
            {
                sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    textBox1.Text = Convert.ToString(sqlReader["name"]);
                    textBox2.Text = Convert.ToString(sqlReader["genre"]);
                    textBox3.Text = Convert.ToString(sqlReader["description"]);
                    textBox4.Text = Convert.ToString(sqlReader["regiser"]);
                    maskedTextBox1.Text = Convert.ToString(sqlReader["time_h"]) + ":" + Convert.ToString(sqlReader["time_m"]) + ":00";
                    image = new Bitmap(Convert.ToString(sqlReader["photo"]));
                    pictureBox4.Image = image;
                    pictureBox4.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
            conn.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            pictureBox4.Image = null;
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand udcommand = new SqlCommand("DELETE FROM [Film] WHERE name = N'" + textBox1.Text.ToString() + "'", conn);

            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Ошибка, не введён один из параметров!");
            else
            {
                udcommand.ExecuteNonQuery();
                MessageBox.Show("Фильм " + textBox1.Text + " успешно удалён из библиотеки!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                maskedTextBox1.Text = "  :  :";
                pictureBox4.Image = null;
            }

            SqlCommand command = new SqlCommand("SELECT name FROM [Film] ORDER BY name ASC", conn);
            command.CommandTimeout = 0;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }

            conn.Close();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {

        }
    }
}
