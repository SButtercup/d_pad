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
    public partial class EventsManager : Form
    {
        public EventsManager()
        {
            InitializeComponent();
        }

        private void EventsManager_Load(object sender, EventArgs e)
        {
            //if(listView_events.Container
        }
        public void add(ListViewItem item)
        {
            listView_events.Items.Add(item);

        }

        private void button_event_add_Click(object sender, EventArgs e)
        {
            string eventName = textBox_event.Text;
            string eventtime = textBox_time.Text;
            string day = "";

            String[] row = { eventName, eventtime, day };
            ListViewItem item = new ListViewItem(row);
            add(item);
           
        }

        private void listView_events_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_events.SelectedItems[0].SubItems[0].Text = listView_events.SelectedItems[0].SubItems[0].Text;
            listView_events.SelectedItems[0].SubItems[0].Text = listView_events.SelectedItems[0].SubItems[1].Text;
            listView_events.SelectedItems[0].SubItems[0].Text = listView_events.SelectedItems[0].SubItems[2].Text;
        }

        private void button_event_delete_Click(object sender, EventArgs e)
        {
            listView_events.Items.RemoveAt(listView_events.SelectedIndices[0]);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
