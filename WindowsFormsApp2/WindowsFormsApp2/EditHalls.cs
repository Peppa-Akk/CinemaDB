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
    public partial class EditHalls : Form
    {
        private Point MouseHook;
        private void Clear()
        {
            foreach (Control control in this.panel2.Controls)
            {
                if (control is Button)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            if (control.Name == (i + 1).ToString() + "x" + (j + 1).ToString())
                            {
                                control.Visible = false;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void Clear1()
        {
            foreach (Control control in this.panel3.Controls)
            {
                if (control is Button)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            if (control.Name == "d" + (i + 1).ToString() + "x" + (j + 1).ToString())
                            {
                                control.Visible = false;
                                break;
                            }
                        }
                    }
                }
            }
        }

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
        public EditHalls()
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

        private void EditHalls_Load(object sender, EventArgs e)
        {
            int top = 60;
            int left = 20;
            int height = 28;
            int width = 24;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button button = new Button();
                    button.Left = left + (j * 30);
                    button.Top = top + (i * 34);
                    button.Height = height;
                    button.Width = width;
                    button.UseVisualStyleBackColor = true;
                    button.Visible = false;
                    button.Name = (i + 1).ToString() + "x" + (j + 1).ToString();
                    button.Click += ButtonOnClick;

                    this.panel2.Controls.Add(button);
                }
            }

            top = 145;
            left = 20;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button button = new Button();
                    button.Left = left + (j * 30);
                    button.Top = top + (i * 34);
                    button.Height = height;
                    button.Width = width;
                    button.UseVisualStyleBackColor = true;
                    button.Visible = false;
                    button.Name = "d" + (i + 1).ToString() + "x" + (j + 1).ToString();
                    button.Click += ButtonOnClickd;

                    this.panel3.Controls.Add(button);
                }
            }

            panel2.Top = Cache.top;
            panel2.Left = Cache.left;
            panel2.Height = Cache.height;
            panel2.Width = Cache.width;

            panel3.Top = Cache.top;
            panel3.Left = Cache.left1;
            panel3.Height = Cache.height;
            panel3.Width = Cache.width;

            panel2.Visible = true;
            panel3.Visible = false;

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT name FROM [Cinema] ORDER BY name ASC", conn);
            command.CommandTimeout = 0;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
                comboBox2.Items.Add(reader[0].ToString());
            }

            conn.Close();
        }

        private void ButtonOnClickd(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int indexOfChar = button.Name.IndexOf("x");
            MessageBox.Show("Ряд: " + button.Name.Substring(1, indexOfChar - 1) + ", Место: " + button.Name.Substring(indexOfChar + 1) + ".");
        }

        private void ButtonOnClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int indexOfChar = button.Name.IndexOf("x");
            MessageBox.Show("Ряд: " + button.Name.Substring(0, indexOfChar) + ", Место: " + button.Name.Substring(indexOfChar + 1) + ".");
        }
        
        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void button226_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clear();

            string str = textBox1.Text.Trim();
            string str2 = textBox2.Text.Trim();
            int num;

            bool isNum = int.TryParse(str, out num);
            bool isNum2 = int.TryParse(str2, out num);

            if (!isNum || !isNum2)
                MessageBox.Show("Неверно введены данные!");
            else
            {
                if ((int.Parse(textBox1.Text) < 1 || int.Parse(textBox1.Text) > 10) || (int.Parse(textBox2.Text) < 1 || int.Parse(textBox2.Text) > 20))
                    MessageBox.Show("Минимальное кол-во рядов - 1, максимальное кол-во рядов - 10\nМинимальное кол-во мест - 1, максимальное кол-во мест - 20");
                else
                {
                    foreach (Control control in this.panel2.Controls)
                    {
                        if (control is Button)
                        {
                            for (int i = 0; i < int.Parse(textBox1.Text); i++)
                            {
                                for (int j = 0; j < int.Parse(textBox2.Text); j++)
                                {
                                    if (control.Name == (i + 1).ToString() + "x" + (j + 1).ToString())
                                    {
                                        control.Visible = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button161_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string id_cinema = "";

            if (comboBox1.SelectedIndex >= 0)
            {
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
            }

            SqlCommand dobcommand = new SqlCommand("INSERT INTO [Hall] (ID_cinema, type, kolvo_r, kolvo_p, floor)VALUES(@ID_cinema, @type, @kolvo_r, @kolvo_p, @floor)", conn);

            dobcommand.Parameters.AddWithValue("ID_cinema", id_cinema.ToString());
            dobcommand.Parameters.AddWithValue("type", textBox3.Text);
            dobcommand.Parameters.AddWithValue("kolvo_r", textBox1.Text);
            dobcommand.Parameters.AddWithValue("kolvo_p", textBox2.Text);
            dobcommand.Parameters.AddWithValue("floor", textBox4.Text);

            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox1.Text == "" || comboBox1.SelectedIndex < 0)
                MessageBox.Show("Ошибка, не введён один из параметров!");
            else
            {
                dobcommand.ExecuteNonQuery();
                MessageBox.Show("Кинозал " + textBox3.Text + " успешно добавлен в кинотеатр " + comboBox1.SelectedItem + "!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.SelectedIndex = -1;
                Clear();
            }
            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel4.Top = pictureBox2.Top;

            panel2.Left = Cache.left;

            panel3.Left = Cache.left1;

            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel4.Top = pictureBox3.Top;

            panel3.Left = Cache.left;

            panel2.Left = Cache.left1;

            panel3.Visible = true;
            panel2.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string id_cinema = "";
            Cache.list.Clear();
            Cache.type.Clear();
            Cache.id_cinema.Clear();

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT ID_cinema FROM [Cinema] WHERE name = N'" + comboBox2.SelectedItem.ToString() + "'", conn);
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

            comboBox3.Items.Clear();

            SqlCommand com1 = new SqlCommand("SELECT type, kolvo_r, kolvo_p, floor FROM [Hall] WHERE ID_cinema = N'" + id_cinema + "'", conn);
            SqlDataReader reader1;
            reader1 = com1.ExecuteReader();
            while (reader1.Read())
            {
                try
                {
                    comboBox3.Items.Add(reader1[0].ToString() + ", Этаж - " + reader1[3].ToString());
                    Cache.list.Add(reader1[1].ToString() + "x" + reader1[2].ToString());
                    Cache.type.Add(reader1[0].ToString());
                    Cache.id_cinema.Add(Int32.Parse(id_cinema));
                }
                catch { }
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear1();

            int indexOfChar = Cache.list[comboBox3.SelectedIndex].IndexOf("x");

            foreach (Control control in this.panel3.Controls)
            {
                if (control is Button)
                {
                    for (int i = 0; i < Int32.Parse(Cache.list[comboBox3.SelectedIndex].Substring(0, indexOfChar)); i++)
                    {
                        for (int j = 0; j < Int32.Parse(Cache.list[comboBox3.SelectedIndex].Substring(indexOfChar + 1)); j++)
                        {
                            if (control.Name == "d" + (i + 1).ToString() + "x" + (j + 1).ToString())
                            {
                                control.Visible = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand udcommand = new SqlCommand("DELETE FROM [Hall] WHERE ID_cinema = N'" + Cache.id_cinema[comboBox3.SelectedIndex].ToString() + "' AND type = N'" + Cache.type[comboBox3.SelectedIndex] + "'", conn);

            if (comboBox2.SelectedIndex < 0 || comboBox3.SelectedIndex < 0)
                MessageBox.Show("Ошибка, не введён один из параметров!");
            else
            {
                udcommand.ExecuteNonQuery();
                comboBox3.SelectedIndex = -1;
                Clear1();
            }

            conn.Close();
        }
    }
}