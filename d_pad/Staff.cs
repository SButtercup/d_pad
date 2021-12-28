using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d_pad
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ser = textBox_s.Text;
            string name = textBox_name.Text;
            string contact = textBoxcon.Text;
            string st = comboBoxst.Text;
            ListViewItem item = new ListViewItem(ser);;
            item.SubItems.Add(name);
            item.SubItems.Add(contact);
            item.SubItems.Add(st);
            listView1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                item.Remove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                string st = comboBox2.Text;
                string sn = item.SubItems[0].Text;
                string name = item.SubItems[1].Text;
                string conta = item.SubItems[2].Text;

                item.Remove();
                ListViewItem it = new ListViewItem(sn);
                it.SubItems.Add(name.ToString());
                it.SubItems.Add(conta.ToString());
                it.SubItems.Add(st.ToString());
                
                listView1.Items.Add(it);
            }
        }
    }
}
