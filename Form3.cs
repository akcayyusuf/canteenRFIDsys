using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.CodeDom;

namespace KANTİN
{
   
    public partial class userform : Form
    {
        public static float fromwhere,bakiye;
        public static string ad,soyad,town,rfid;
        DataTable searchtab;
        MySqlDataAdapter searchadapter;
      
        public userform()
        {
            
            Form1.connect.Open();
                                                          
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM ogrenci",Form1.connect);                //KULLANICI VERİ TABANINA BİR SORGU GÖNDER
            DataGridViewButtonColumn butcol = new DataGridViewButtonColumn();
            DataGridViewButtonCell bcell = new DataGridViewButtonCell();
            DataTable dt = new DataTable();
            data.Fill(dt);
            
         
       


            InitializeComponent();
           dataGridView1.DataSource = dt;
            butcol.FlatStyle = FlatStyle.Flat;
            butcol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 150;   //RFID
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 130;
            //dataGridView1.Columns[6].Width = 54;

            butcol.HeaderText = "DÜZENLE";
            butcol.Text = "Düzenle";
      
            butcol.Name = "edit";

            dataGridView1.Columns.Insert(6, butcol);

            dataGridView1.Height = Convert.ToInt32(dataGridView1.Rows.Count.ToString()) * 50 + 80;
            Form1.connect.Close();
        }

        private void userform_Load(object sender, EventArgs e)
        {
     
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            SearchData(textBox1.Text);
            

            dataGridView1.Height = Convert.ToInt32(dataGridView1.Rows.Count.ToString()) * 50 + 80;

        }
        public void display()
        {
            searchadapter = new MySqlDataAdapter("SELECT*FROM ogrenci", Form1.connect);
            searchtab = new DataTable();
            searchadapter.Fill(searchtab);
            dataGridView1.DataSource = searchtab;
        }
        public void SearchData(string search)
        {
            string ques = "SELECT * FROM ogrenci WHERE  CONCAT(İSİM, ' ', SOYİSİM) like '%" + search + "%'   ";
            searchadapter = new MySqlDataAdapter(ques, Form1.connect);
            searchtab = new DataTable();
            
            searchadapter.Fill(searchtab);
            dataGridView1.DataSource = searchtab;
            dataGridView1.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        public void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            popupuser popup = new popupuser();
            popup.Show();
           
        }

        public  void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
         
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                fromwhere = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                bakiye =Convert.ToSingle( dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                ad = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                soyad = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
              
                rfid= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                editwindow frm = new editwindow(this);
                frm.Show();
                //editwindow editt = new editwindow();

                //editt.Show();



                //TODO - Button Clicked - Execute Code Here
            }
        }
        public DataTable Loaddata
        {

            get
            {
                return searchtab;
            }
            set 
            {
                dataGridView1.DataSource = value;
            }

         






        }
    }
}
