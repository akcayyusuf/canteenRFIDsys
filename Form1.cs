using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Input;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KANTİN
{
    
    public partial class Form1 : Form
    {
        public static MySqlConnection connect = new MySqlConnection("Server=127.0.0.1;Database=canteen;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public static bool cstatus;
        public Form1()
        {
            
            
            connect.Open();
            cstatus = true;
            InitializeComponent();
             
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (cstatus == false)
            {
                connect.Open();
                cstatus = true;
            }
            cmd = new MySqlCommand("SELECT * FROM admin where name='" + usertb.Text + "' AND pwd='" + pwdtb.Text + "';");
            cmd.Connection = connect;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                connect.Close();
                this.Hide();
                this.Controls.Clear();
                GC.Collect();
                Form2 mainform = new Form2();
                dr.Close();
                mainform.Show();
            }
            else 
            {
                MessageBox.Show("hata");
                connect.Close();
                cstatus = false;
            }

        }

        private void logintag_Click(object sender, EventArgs e)
        {

        }
    }
}
