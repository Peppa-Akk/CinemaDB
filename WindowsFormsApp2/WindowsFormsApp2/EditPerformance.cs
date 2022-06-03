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
using System.Globalization;

namespace WindowsFormsApp2
{
    public partial class EditPerformance : Form
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
        public EditPerformance()
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

        private void EditPerformance_Load(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT name FROM [Cinema] ORDER BY name ASC", conn);
            command.CommandTimeout = 0;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }

            conn.Close();

            conn.Open();

            Cache.id_film.Clear();

            SqlCommand command1 = new SqlCommand("SELECT ID_film, name FROM [Film]", conn);
            command1.CommandTimeout = 0;
            SqlDataReader reader1;
            reader1 = command1.ExecuteReader();
            comboBox3.Items.Clear();
            while (reader1.Read())
            {
                comboBox3.Items.Add(reader1[1].ToString());
                Cache.id_film.Add(Int32.Parse(reader1[0].ToString()));
            }

            conn.Close();

            comboBox3.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
           
            SqlCommand dobcommand = new SqlCommand("INSERT INTO [Performance] (ID_hall, ID_film, start_date, price)VALUES(@ID_hall, @ID_film, @start_date, @price)", conn);

            dobcommand.Parameters.AddWithValue("ID_hall", Cache.id_hall[comboBox2.SelectedIndex].ToString());
            dobcommand.Parameters.AddWithValue("ID_film", Cache.id_film[comboBox3.SelectedIndex].ToString());
            IFormatProvider culture = CultureInfo.InvariantCulture;
            dobcommand.Parameters.AddWithValue("start_date", DateTime.Parse(dateTimePicker1.Text.Replace(".", "-") + " " + maskedTextBox1.Text));
            dobcommand.Parameters.AddWithValue("price", textBox1.Text);

            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || textBox1.Text == "" || comboBox3.SelectedIndex < 0)
                MessageBox.Show("Ошибка, не введён один из параметров!");
            else
            {
                dobcommand.ExecuteNonQuery();
                MessageBox.Show("Фильм " + comboBox3.SelectedItem + " был добавлен на сеанс на " + dateTimePicker1.Text + " в " + maskedTextBox1.Text + " в кинотеатр " + comboBox1.SelectedItem + " (Зал - " + comboBox2.SelectedItem + "). Стоимость билета будет составлять " + textBox1.Text + " б.р. !");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string id_cinema = "";
            Cache.list.Clear();
            Cache.type.Clear();
            Cache.id_cinema.Clear();
            Cache.id_hall.Clear();

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT ID_cinema FROM [Cinema] WHERE name = N'" + comboBox1.SelectedItem.ToString() + "'", conn);
            try
            {
                sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                    id_cinema = Convert.ToString(sqlReader["ID_cinema"]);
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

            comboBox2.Items.Clear();

            SqlCommand com1 = new SqlCommand("SELECT type, kolvo_r, kolvo_p, floor, ID_hall FROM [Hall] WHERE ID_cinema = N'" + id_cinema + "'", conn);
            SqlDataReader reader1;
            reader1 = com1.ExecuteReader();
            while (reader1.Read())
            {
                try
                {
                    comboBox2.Items.Add(reader1[0].ToString() + ", Этаж - " + reader1[3].ToString());
                    Cache.list.Add(reader1[1].ToString() + "x" + reader1[2].ToString());
                    Cache.type.Add(reader1[0].ToString());
                    Cache.id_cinema.Add(Int32.Parse(id_cinema));
                    Cache.id_hall.Add(Int32.Parse(reader1[4].ToString()));
                }
                catch { }
            }
            conn.Close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Disable_Click(object sender, EventArgs e)
        {

        }
    }
}
