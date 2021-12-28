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
using System.Text.RegularExpressions;

namespace d_pad
{
    public partial class icd10 : Form
    {
        public icd10()
        {
            InitializeComponent();
            
        }
        public int count=0;

        MySqlConnection con = dbConnect.Initialize();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                        

        }
       
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            if (textBox_search.Text =="")
            {
                fillList();
            }
            
        }
        
        private void icd10_Load(object sender, EventArgs e)
        {
            fillList();
            
        }
        public void fillList()
        {
            ListViewItem item;
            con.Open();
            string sql = " SELECT `ICD10`,`Disease` FROM `new_icd_codes`";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                item = new ListViewItem(reader["ICD10"].ToString());
                item.SubItems.Add(reader["Disease"].ToString());
                listView_icd10.Items.Add(item);
            }
            con.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView_icd10_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button_searchicd10_Click(object sender, EventArgs e)
        {
            listView_icd10.Items.Clear();
            con.Open();
            MySqlCommand cmd;
            MySqlDataReader read;
            string str = comboBox_icd10_search.Text;
            string txt = textBox_search.Text;
            ListViewItem item;
            if (str == "ICD-10 Code")
            {
                string sql = " SELECT `ICD10`,`Disease` FROM `new_icd_codes` WHERE `ICD10`='" + txt + "'";
                cmd = new MySqlCommand(sql, con);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    item = new ListViewItem(read["ICD10"].ToString());
                    item.SubItems.Add(read["Disease"].ToString());
                    listView_icd10.Items.Add(item);
                }
            }
            else if (str == "Name")
            {
                Regex reg = new Regex("\\b"+txt+"\\b");
                string sql = " SELECT `ICD10`,`Disease` FROM `new_icd_codes`";
                cmd = new MySqlCommand(sql, con);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    item = new ListViewItem(read["ICD10"].ToString());
                    item.SubItems.Add(read["Disease"].ToString());
                    string str2 = item.SubItems[1].ToString();
                   
                    if(reg.IsMatch(str2)){
                    listView_icd10.Items.Add(item); }
                }
            }
            else if (str == "")
                MessageBox.Show("Choose a valid searching option please");
            con.Close();
        }
        private void listView_icd10_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            this.listView_icd10.FullRowSelect = e.Item.Selected;
            if (e.Item.Selected)
            {
                e.Item.Checked = true;
                count++;
            }

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string code,dise;
            int i=0;
            con.Open();
            MySqlCommand cmd3;
            foreach(ListViewItem item in listView_icd10.CheckedItems)
            {
                code = item.SubItems[0].Text;
                dise = item.SubItems[1].Text;
                string sql = "INSERT INTO `code_fav`(`code`,`disname`) VALUES ('" + code + "', '" + dise + "')";
                cmd3 = new MySqlCommand(sql, con);
                cmd3.ExecuteNonQuery();
                
            }
            con.Close();
            MessageBox.Show("items added successfully!");
            
            foreach (ListViewItem item2 in listView_icd10.CheckedItems)
            {
                item2.Checked = false;
            }
            this.Refresh();
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            con.Open();
            string str4;
            string str5 = listView_icd10.CheckedItems[0].Text; ;
            if (count > 1)
                MessageBox.Show("Multiple Selection not allowed");
            else
            {
                string sql = "SELECT ICD9 FROM new_icd_codes WHERE ICD10='" + str5 + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    str4 = read["ICD9"].ToString();
                    MessageBox.Show("ICD-10 code:" + str5 + "\nICD-9 Code: " + str4);
                }
            }
            con.Close();
            foreach (ListViewItem item2 in listView_icd10.CheckedItems)
            {
                item2.Checked = false;
            }
            count = 0;
            this.Refresh();
        }   
    }
}
