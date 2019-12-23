using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            refresh();

        }
        void refresh()
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database=fitnescenter;uid=root;pwd= ;Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from subscription", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database=fitnescenter;uid=root;pwd= ;Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO subscription(Sname,Sprice,Sdataend) values('" + textBox1.Text+ "','" + textBox3.Text + "','" +textBox2.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database=fitnescenter;uid=root;pwd= ;Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE From subscription Where ID_S="+textBox4.Text, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            refresh();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
