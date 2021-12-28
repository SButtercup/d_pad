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

namespace d_pad
{
    public partial class icd9 : Form
    {
        public icd9()
        {
            InitializeComponent();
        }

        private void comboBox_icd9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int count2 = 0;
        MySqlConnection con = dbConnect.Initialize();
        private void button_searchicd9_Click(object sender, EventArgs e)
        {
            listView_icd9.Items.Clear();
            con.Open();
            MySqlCommand cmd;
            MySqlDataReader read;
            string txt = textBox_searchICD9.Text;
            ListViewItem item;
            string sql = "SELECT `ICD9`,`Disease` FROM `new_icd_codes` WHERE `ICD9`='" + txt + "'OR `Disease`='" + txt + "'";
                cmd = new MySqlCommand(sql, con);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    item = new ListViewItem(read["ICD9"].ToString());
                    item.SubItems.Add(read["Disease"].ToString());
                    listView_icd9.Items.Add(item);
                }
            
            con.Close();
        }

        private void icd9_Load(object sender, EventArgs e)
        {
            ListViewItem item;
            con.Open();
            string sql = " SELECT `ICD9`,`Disease` FROM `new_icd_codes`";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                item = new ListViewItem(reader["ICD9"].ToString());
                item.SubItems.Add(reader["Disease"].ToString());
                listView_icd9.Items.Add(item);
            }
            con.Close();
        }

        private void button_convertICD9_Click(object sender, EventArgs e)
        {
            con.Open();
            string str4;
            string str5 = listView_icd9.CheckedItems[0].Text; ;
            if (count2 > 1)
                MessageBox.Show("Multiple Selection not allowed");
            else
            {
                string sql = "SELECT ICD10 FROM new_icd_codes WHERE ICD9='" + str5 + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    str4 = read["ICD10"].ToString();
                    MessageBox.Show("ICD-9 code:" + str5 + "\nICD-10 Code: " + str4);
                }
            }
            con.Close();
            foreach (ListViewItem item2 in listView_icd9.CheckedItems)
            {
                item2.Checked = false;
            }
            count2 = 0;
            this.Refresh();
        }

        private void button_closeICD9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView_icd9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listView_icd10_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            this.listView_icd9.FullRowSelect = e.Item.Selected;
            if (e.Item.Selected)
            {
                e.Item.Checked = true;
                count2++;
            }
        }
    }
}
