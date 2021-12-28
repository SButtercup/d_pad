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
    public partial class AddNew : Form
    {
        public AddNew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string un = textBox1.Text;
            string pas = textBox2.Text;
            MySqlConnection con = dbConnect.Initialize();
            con.Open();
            if (radioButton_Doc.Checked)
            {
                string sql1 = "INSERT INTO `doclogin`(`Username`, `Password`) VALUES ('" + un + "','" + pas + "')";
                MySqlCommand cmd1 = new MySqlCommand(sql1, con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Added SuccessFully");
                con.Close();
                this.Close();
            }
            else if (radioButton_sta.Checked)
            {
                string sql2 = "INSERT INTO `stafflogin`(`nameUser`, `wordPass`) VALUES ('" + un + "','" + pas + "')";
                MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Added SuccessFully");
                con.Close();
                this.Close();
            }
            else
                MessageBox.Show("Information Not Complete");
            
        }
    }
}
