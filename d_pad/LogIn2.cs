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
    public partial class LogIn2 : Form
    {
        public LogIn2()
        {
            InitializeComponent();
        }
        MySqlConnection con = dbConnect.Initialize();
        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_usernam.Text;
            string password = textBoxPassword.Text;
            if (username == "" || password == "")
                MessageBox.Show("Username or password can not be null");
            con.Open();
            String sql = "SELECT `nameUser`, `wordPass` FROM `stafflogin` WHERE `nameUser`='" + username + "' and `wordPass`='" + password + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {


                this.Close();

                HomePage homeobj = new HomePage();
                homeobj.closeform(1);
                Staff staffobj = new Staff();
                staffobj.Visible = true;

            }
            else
            {
                MessageBox.Show("UserName or Password invalid");
            }
            con.Close();
  
        }
    }
}
