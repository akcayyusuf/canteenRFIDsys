using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace KANTİN
{
    public partial class shop : Form
    {
       
        Single bakiye;
        string pname=null;
        int id;
        MySqlDataAdapter dta = new MySqlDataAdapter("SELECT `id`,`urun_adi`,`alis_fiyati`,`urun_adedi` FROM `urun`  ", Form1.connect);
        DataTable dtable = new DataTable();
        DataTable searchtab;
        MySqlDataAdapter searchadapter;

        MySqlDataAdapter adap;
        DataTable p_ara = new DataTable();

        SerialPort sp = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
        
        public shop()
        {
          
            InitializeComponent();


            Control.CheckForIllegalCrossThreadCalls = false;

           
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);

           sp.Open();

            
            dta.Fill(dtable);
            dataGridView1.DataSource= dtable;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ÜRÜN ADI";
            dataGridView1.Columns[2].HeaderText = "SATIŞ FİYATI";
            dataGridView1.Columns[3].HeaderText = "ADETİ";
   
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
           
          // label1.Parent = pictureBox1;

            dataGridView3.Columns[0].Width = 200;
            dataGridView3.Columns[4].Width = 50;
            dataGridView3.Columns[1].Width = 80;
            dataGridView3.Columns[2].Width = 80;
            dataGridView3.Columns[3].Width = 70;

           dataGridView3.Height = Convert.ToInt32(dataGridView3.Rows.Count.ToString()) * 0;



        }
       

        public void button10_Click(object sender, EventArgs e)
        {
            
            pname = "Kahve";
            finalfunc();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchData(textBox1.Text);


            dataGridView1.Height = Convert.ToInt32(dataGridView1.Rows.Count.ToString()) * 30 + 40;
        }
        public void SearchData(string search)
        {
            string ques = "SELECT `id`,`urun_adi`,`alis_fiyati`,`urun_adedi` FROM urun WHERE  urun_adi like '%" + search + "%'   ";
            searchadapter = new MySqlDataAdapter(ques, Form1.connect);
            searchtab = new DataTable();
            searchadapter.Fill(searchtab);
            dataGridView1.DataSource = searchtab;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    
        
        private void button23_Click(object sender, EventArgs e)
        {
            pname = "Maden Suyu Sade";
            finalfunc();
        }
     

        private void button15_Click(object sender, EventArgs e)
        {
            pname = "Çay";
            finalfunc();
      
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
            var senderGrid = (DataGridView)sender;
          

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                bool isit;                     
                isit = check(pname);
            
                bool joker=true;
                if (joker == true)
                {
                    DataGridViewCell cell = dataGridView3.Rows[e.RowIndex].Cells[1];
                    cell.Value = -1 + Convert.ToInt32(cell.Value.ToString());
                    //ADETİN OLDUĞU CELL

                    DataGridViewCell celltotal;
                    if ((int)cell.Value == 0)
                    {
                        dataGridView3.Rows.Remove(dataGridView3.Rows[e.RowIndex]);
                    }
                    if (e.RowIndex!=dataGridView3.Rows.Count) 
                    {
                        
                        celltotal = dataGridView3.Rows[e.RowIndex].Cells[3];
                        celltotal.Value = Convert.ToSingle(dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString()) * Convert.ToSingle(dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString());
                    }
                    else 
                    {
                        
                    }
                    
                }
                dataGridView3.Height = Convert.ToInt32(dataGridView3.Rows.Count.ToString()) * 30+40;
                total();
              
            }
        }

        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) 
        {

            var senderGrid = (DataGridView)sender;


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                bool isit;
                isit = check(pname);

                bool joker = true;
                if (joker == true)
                {
                    DataGridViewCell cell = dataGridView3.Rows[e.RowIndex].Cells[1];
                    cell.Value = -1 + Convert.ToInt32(cell.Value.ToString());
                    //ADETİN OLDUĞU CELL

                    DataGridViewCell celltotal;
                    if ((int)cell.Value == 0)
                    {
                        dataGridView3.Rows.Remove(dataGridView3.Rows[e.RowIndex]);

                    }
                    if (e.RowIndex != dataGridView3.Rows.Count)
                    {

                        celltotal = dataGridView3.Rows[e.RowIndex].Cells[3];
                        celltotal.Value = Convert.ToSingle(dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString()) * Convert.ToSingle(dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString());
                    }
                    else
                    {

                    }

                }
              
                total();

            }
        }
        public void sec() 
        {
            if (dataGridView2.Rows.Count != 0) 
            {
                dataGridView2.Rows.RemoveAt(0);
            }
            string sorgu = "SELECT * FROM urun WHERE  urun_adi = '" + pname + "';";
    
            adap = new MySqlDataAdapter(sorgu, Form1.connect);
            adap.Fill(p_ara);
            dataGridView2.DataSource = p_ara;

        }
        public bool check(string urunadı) 
        {
            int i = 0;
            bool buldum= false;
            if (dataGridView3.Rows.Count == 0) 
            {
                buldum = false;
            }
            else 
            {
                while(i<=dataGridView3.Rows.Count && buldum == false) 
                {
       
                    if (dataGridView3.Rows[i].Cells[0].Value.Equals(urunadı)) 
                    {
                        buldum = true;
                    }
                    else 
                    {
                        buldum = false;
                        if (dataGridView3.Rows.Count == i+1)
                        {
                            return buldum;
                        }
                    }
                    i++;
                }
            }
            i = 0;
            return buldum;
        }
        public int where(string search) 
        {
            int i = 0;
            int adress=0;
            bool buldum=false;
            while (i <= dataGridView3.Rows.Count&&buldum==false) 
            {
                if (dataGridView3[0, i].Value.Equals(search)) 
                {
                    adress = i;
                    buldum = true;
                }
                i++;
               
            }

            return adress;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bool isit;
            pname = "Simit";
            sec();
            int adress = 0;
            isit = check(pname);

            if (isit == true)
            {
                adress = where(pname);

                DataGridViewCell cell = dataGridView3.Rows[adress].Cells[1];
                cell.Value = 1 + Convert.ToInt32(cell.Value.ToString());                    //ADETİN OLDUĞU CELL
                dataGridView3.Refresh();


                DataGridViewCell celltotal = dataGridView3.Rows[adress].Cells[3];
                celltotal.Value = Convert.ToSingle(dataGridView3.Rows[adress].Cells[1].Value.ToString()) * Convert.ToSingle(dataGridView3.Rows[adress].Cells[2].Value.ToString());
            }
            else
            {
                dataGridView3.Rows.Add(pname, 1, dataGridView2[3, 0].Value, Convert.ToSingle(dataGridView2[3, 0].Value.ToString()) * 1);
            }
            total();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void total()
        {
          
            float toplam=0;
            for (int a = 0; a <= (dataGridView3.Rows.Count-1 ); a++) 
            {

                toplam = toplam + Convert.ToSingle(dataGridView3[3, a].Value.ToString());

                label1.TextAlign = ContentAlignment.MiddleRight;
               
                    
            }
            //  if(dataGridView3.Rows.Count>)
      
            dataGridView3.Height = Convert.ToInt32(dataGridView3.Rows.Count.ToString()) * 30+40;
            label1.Text = toplam.ToString() + " ₺";
            
        }
        public void finalfunc() 
        {
            bool isit;
            int adress = 0;

            sec();
            isit = check(pname);

            if (isit == true)
            {
                adress = where(pname);

                DataGridViewCell cell = dataGridView3.Rows[adress].Cells[1];
                cell.Value = 1 + Convert.ToInt32(cell.Value.ToString());                    //ADETİN OLDUĞU CELL
                dataGridView3.Refresh();


                DataGridViewCell celltotal = dataGridView3.Rows[adress].Cells[3];
                celltotal.Value = Convert.ToSingle(dataGridView3.Rows[adress].Cells[1].Value.ToString()) * Convert.ToSingle(dataGridView3.Rows[adress].Cells[2].Value.ToString());
            }
            else
            {
                dataGridView3.Rows.Add(pname, 1, dataGridView2[3, 0].Value, Convert.ToSingle(dataGridView2[3, 0].Value.ToString()) * 1);
            }
            
            total();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pname = "Su";
            finalfunc();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pname = "Poğaça";
            finalfunc();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pname = "Meyve Suyu";
            finalfunc();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pname = "Köfte";
            finalfunc();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            pname = "Ayran";
            finalfunc();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pname = "Sucuklu Tost";
            finalfunc();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            pname = "Karışık Tost";
            finalfunc();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pname = "Kaşarlı Tost";
            finalfunc();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = sp.ReadExisting();
            
            
            if (data.StartsWith("UID: ")) 
            {
                data=data.Substring(5,11);
                ara(data);
                sp.WriteLine("A");
             
            }
            else 
            {
                MessageBox.Show("Bir şey oldu");
            }

            

            
           
           
         
         
        }

        public void ara(string uid) 
        {
            
            
            string ques = "SELECT * FROM `ogrenci` WHERE  `RFID ID` = '" + uid+"'"+"";
            MySqlCommand cmd = new MySqlCommand(ques,Form1.connect);
            Form1.connect.Open();
            MySqlDataReader deneme= cmd.ExecuteReader();
            deneme.Read();
           
            try
            {
                
                label2.Text = deneme.GetString("İSİM")+" "+ deneme.GetString("SOYİSİM");
                label3.Text = deneme.GetString("BAKİYE")+ "₺";
                bakiye = Convert.ToSingle(label3.Text.Substring(0, label3.Text.Length - 1));
                label4.Text = deneme.GetString("NUMARA");
                id = deneme.GetInt32("ID");
                
            }
            catch 
            {
                MessageBox.Show("Kayıtlı kimse yok");
            }
            Form1.connect.Close();

           
            deneme.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            Single money = (Convert.ToSingle(label1.Text.Substring(0,label1.Text.Length-1)));
            MessageBox.Show((bakiye-money).ToString());
            Single nbudget = (bakiye - money);

            MessageBox.Show(id.ToString());
            MySqlCommand edited = new MySqlCommand("UPDATE `ogrenci` SET `BAKİYE` = '" + nbudget.ToString().Replace(",",".") + "' WHERE `ogrenci`.`ID` = " + id + ";", Form1.connect);
            MySqlDataReader read;
            Form1.connect.Open();
            Form1.cstatus = true;
            read = edited.ExecuteReader();
            read.Close();
        

            Form1.connect.Close();
        }
    }
}
