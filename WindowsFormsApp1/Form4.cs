using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            MySqlConnection con = new MySqlConnection("Server = localhost; Database=fitnescenter;uid=root;pwd= ;Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from client", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database=fitnescenter;uid=root;pwd= ;Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter(String.Format("Select * from client where Csurname Like'%{0}%'", textBox1.Text), con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
