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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            
        }
        MySqlConnection con = dbConnect.Initialize();


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
           String sql = "SELECT *FROM `areadist`";
          // fillCombo(sql, "area");
           
            

        }
        private void fillCombo(String query, String item)
        {


            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_home_area.DataSource = table;
            comboBox_home_area.DisplayMember = item;
        }
 
        private void label_home_specialtiy_Click(object sender, EventArgs e)
        {

        }

       
        private void comboBox_home_specialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
       
        private void comboBox_home_dist_SelectedIndexChanged(object sender, EventArgs e)
        {
            String item = comboBox_home_dist.Text; 
            con.Open();
            String sql = "SELECT *FROM `areadist` WHERE `dist`='" + item + "'";
            fillCombo(sql,"area");
            
           
        }
        
        private void comboBox_home_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sp=comboBox_home_specialty.Text;
            String ds=comboBox_home_dist.Text;
            String ar=comboBox_home_area.Text;
            String query = "SELECT Name ,Place,Time,Day,Contact FROM `myarea_docs` WHERE `District`='" + ds + "'AND `Area`='" + ar + "'AND `Speciality`='" + sp + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            BindingSource bsource = new BindingSource();
            adapter.Fill(table);
            bsource.DataSource=table;
            dataGridView_docInfo.DataSource = bsource;
            adapter.Update(table);
            DataGridViewColumn col0 = dataGridView_docInfo.Columns[0];
            col0.Width = 235;
            DataGridViewColumn col1 = dataGridView_docInfo.Columns[1];
            col1.Width = 235;
            DataGridViewColumn col2 = dataGridView_docInfo.Columns[2];
            col2.Width = 238;
            DataGridViewColumn col3 = dataGridView_docInfo.Columns[3];
            col3.Width = 235;
            DataGridViewColumn col4 = dataGridView_docInfo.Columns[4];
            col4.Width = 235;
           
        }
        public void closeform(int x)
        {
            if (x == 1)
                this.Visible = false;
            else
                this.Visible = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            LogIn2 login2obj = new LogIn2();
            login2obj.Visible = true;
        }

        private void button_home_doctor_Click(object sender, EventArgs e)
        {
            LogIn1 login1obj = new LogIn1();
            login1obj.Visible = true;
           
        }

        private void dataGridView_docInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddNew adobj = new AddNew();
            adobj.Visible = true;
        }
    }
}
