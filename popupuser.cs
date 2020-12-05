using System;
using MySql.Data.MySqlClient;
using MySql;
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
    public partial class popupuser : Form
    {
        public popupuser()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
           
            
            MySqlCommand save = new MySqlCommand("INSERT INTO `ogrenci` (`NUMARA`,`İSİM`,`SOYİSİM`,`ŞEHİR`,`BAKİYE`) VALUES ('" + num.Text + "','" + usname.Text+ "','" + ussur.Text + "','" + city.Text + "','" + budget.Text + "');  ", Form1.connect);
            MySqlDataReader read;
            Form1.connect.Open();
            read = save.ExecuteReader();
            
            Form1.connect.Close();
            Form1.cstatus = false;
            read.Close();
        }
        public void swapconstatus() 
        {
            if (Form1.cstatus==true) 
            {
                Form1.cstatus = false;
            }
            else 
            {
                Form1.cstatus = true;
            }
        }

        private void budget_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
