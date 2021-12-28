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
    public partial class FormDrug : Form
    {
        public FormDrug()
        {
            InitializeComponent();
        }
        MySqlConnection con = dbConnect.Initialize();
        private void button_drug_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fillList()
        {
            ListViewItem item;
            con.Open();
            string sql = " SELECT `ID10`,`bname`,`gname`,`tuse` FROM `drugdb`";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                item = new ListViewItem(reader["ID10"].ToString());
                item.SubItems.Add(reader["bname"].ToString());
                item.SubItems.Add(reader["gname"].ToString());
                item.SubItems.Add(reader["tuse"].ToString());
                listView_drug.Items.Add(item);
            }
            con.Close();
        }
        private void button_drug_search_Click(object sender, EventArgs e)
        {
            listView_drug.Items.Clear();
            con.Open();
            MySqlCommand cmd;
            MySqlDataReader read;
            string txt = textBox_searchName_drug.Text;
            ListViewItem item;
            string sql = "SELECT `ID10`,`bname`,`gname`,`tuse` FROM `drugdb` WHERE `gname`='" + txt + "'";
            cmd = new MySqlCommand(sql, con);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                item = new ListViewItem(read["ICD9"].ToString());
                item.SubItems.Add(read["Disease"].ToString());
                listView_drug.Items.Add(item);
            }

            con.Close();
        }

        private void button_drug_ADD_Click(object sender, EventArgs e)
        {
            string bn, gn, tu;
            int i = 0;
            con.Open();
            MySqlCommand cmd3;
            foreach (ListViewItem item in listView_drug.CheckedItems)
            {
                bn = item.SubItems[1].Text;
                gn = item.SubItems[2].Text;
                tu = item.SubItems[3].Text;
                string sql = "INSERT INTO `drug_fav`(`dname`,`gname`,`tuse`) VALUES ('" + bn + "', '" + gn + "', '" + tu + "')";
                cmd3 = new MySqlCommand(sql, con);
                cmd3.ExecuteNonQuery();

            }
            con.Close();
            MessageBox.Show("items added successfully!");

            foreach (ListViewItem item2 in listView_drug.CheckedItems)
            {
                item2.Checked = false;
            }
            this.Refresh();
            con.Close();
        }

        private void FormDrug_Load(object sender, EventArgs e)
        {
            fillList();
        }
    }
}
