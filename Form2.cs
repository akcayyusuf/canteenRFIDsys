using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KANTİN
{
    public partial class Form2 : Form
    {
        userform formum = new userform();
       
        envanter inv = new envanter();
        setting opt = new setting();
        shop shopf = new shop();
        public Form2()
        {
            
            InitializeComponent();
            label2.Text = DateTime.Now.ToString();
        }
        private userform mainForm = null;

        public Form2(Form callingForm)
        {
            mainForm = callingForm as userform;
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           // this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
      
   

        private void pnlcontain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            shopf.TopLevel = false;
          //  shopf.AutoScroll = false;
            pnlcontain.Controls.Remove(formum);
            pnlcontain.Controls.Add(shopf);
            shopf.Show();
            
       
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void shop_Click(object sender, EventArgs e)
        {
        
            renkac(panel7);
            pnlcontain.Controls.Clear();
            shopf.TopLevel = false;
          
            pnlcontain.Controls.Remove(formum);
            pnlcontain.Controls.Add(shopf);
            shopf.Show();
           
        }
        public void renkac(Panel pnl)
        {
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            pnl.Visible = true;
            pnl.BackColor = Color.FromArgb(20, 130, 140);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();

            


            renkac(panel12);
            pnlcontain.Controls.Clear();
            formum.TopLevel = false;
            shopf.AutoScroll = false;
          
            pnlcontain.Controls.Add(formum);
            formum.Show();

            MySqlConnection connectbeta = new MySqlConnection("Server=127.0.0.1;Database=canteen;Uid=root;Pwd='';");
            connectbeta.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT*FROM ogrenci", connectbeta);
            //SearchData(" ");


            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            dgv.DataSource = dt2;
            connectbeta.Close();



            this.formum.Loaddata = dt2;


        }

        private void storage_Click(object sender, EventArgs e)
        {
            renkac(panel8);
            pnlcontain.Controls.Clear();
            inv.TopLevel = false;
            pnlcontain.Controls.Add(inv);
            inv.Show();

           
        }

        private void chart_Click(object sender, EventArgs e)
        {
         

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void settings_Click(object sender, EventArgs e)
        {
            renkac(panel11);
            pnlcontain.Controls.Clear();
            opt.TopLevel = false;
            pnlcontain.Controls.Add(opt);
            opt.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
