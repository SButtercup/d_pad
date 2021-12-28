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
    public partial class LogIn1 : Form
    {
        public LogIn1()
        {
            InitializeComponent();
        }
        MySqlConnection con = dbConnect.Initialize();

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIN_Click(object sender, EventArgs e)
        {
            string username = textBox_name.Text;
            string password = textBox_password.Text;
            if (textBox_name.Text == "" || textBox_password.Text== "")
                MessageBox.Show("Username or password can not be null");
            con.Open();
            String sql="SELECT `Username`, `Password` FROM `doclogin` WHERE `Username`='" + username + "' and `Password`='" + password + "'";
            MySqlCommand cmd = new MySqlCommand(sql,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            if (reader.Read())
            {
                
               
                this.Close();
                
                HomePage homeobj = new HomePage();
                homeobj.closeform(1);
                DoctorHome dochomeobj = new DoctorHome();
                dochomeobj.Visible = true;

            }
            else
            {
                MessageBox.Show("UserName or Password invalid");
            }
            con.Close();
  
        }
    }
}
