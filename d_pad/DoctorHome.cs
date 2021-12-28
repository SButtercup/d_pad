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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Printing;

namespace d_pad
{
    public partial class DoctorHome : Form
    {
        public DoctorHome()
        {
            InitializeComponent();
            timer1.Start();
        }
        public int id = 0;

        public void formexit()
        {
            this.Close();
        }
        MySqlConnection con = dbConnect.Initialize();

        private void DoctorHome_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            string sqlrecent = "SELECT `ID11`,`patient_name`,`contactpat`,`last_visit`,`next_visit`,`prescription` FROM patientmanagement ORDER BY Id ASC";
            MySqlCommand cmdrecent = new MySqlCommand(sqlrecent, con);
            MySqlDataReader readerecent = cmdrecent.ExecuteReader();
            while (readerecent.Read())
            {
                ListViewItem recentitem = new ListViewItem(readerecent["ID11"].ToString());
                recentitem.SubItems.Add(readerecent["patient_name"].ToString());
                recentitem.SubItems.Add(readerecent["contactpat"].ToString());
                recentitem.SubItems.Add(readerecent["last_visit"].ToString());
                recentitem.SubItems.Add(readerecent["next_visit"].ToString());
                recentitem.SubItems.Add(readerecent["prescription"].ToString());
                listView_patientManagement.Items.Add(recentitem);



            }
            con.Close();
           
        }
     
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //String sql="SELECT *FROM `areadist`"
            icd10 icd10obj = new icd10();
            icd10obj.Visible = true;
        }

        private void button_icd9_Click(object sender, EventArgs e)
        {
            icd9 icd9obj = new icd9();
            icd9obj.Visible = true;
        }

        private void button_drugs_Click(object sender, EventArgs e)
        {
            FormDrug drugsObj = new FormDrug();
            drugsObj.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_addDrug_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_drugs.CheckedItems)
            {
                String drugNames = item.SubItems[2].Text;
                comboBox_ep_medName.Items.Add(drugNames);
                comboBox_ep_medName.DisplayMember = drugNames;


            }
        }

        private void button_newPatient_Click(object sender, EventArgs e)
        {
            //groupBox_oldPat.Visible = false;
        }

        private void button_oldPatient_Click(object sender, EventArgs e)
        {
            //groupBox_oldPat.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_newPatient_Click_1(object sender, EventArgs e)
        {
            textBox_ep_name.Text = "";
            textBox_ep_age.Text = "";
            textBox_ep_height.Text = "";
            textBox_ep_weight.Text = "";
            textBox_ep_plseRate.Text = "";
            textBox_ep_SysPre.Text = "";
            textBox_ep_diasPressure.Text="";
            textBox_ep_contact.Text = "";
            comboBox_d1.Text = "";
            comboBox_d2.Text = "";
            comboBox_m1.Text = "";
            comboBox_m2.Text = "";
            comboBox_y1.Text = "";
            comboBox_y2.Text = "";
            comboBox1_ep_diagnosis.Text = "";
            comboBox_ep_medName.Text = "";
            comboBox_ep_amountMed.Text = "";
            comboBox_ep_medInvest.Text = "";
            comboBox_ep_medTime.Text = "";
            comboBox_ep_referral.Text = "";
            comboBox_med_days.Text = "";
            comboBox_med_detailsInvest.Text = "";

            listView_ep_diag.Items.Clear();
            listView_ep_med.Items.Clear();
            listView_ep_investigation.Clear();
            richTextBox_history.Text = "";


        }

        private void button_patHistory_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            EventsManager evemanobj = new EventsManager();
            evemanobj.Visible = true;


            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time1 = DateTime.Now;
            this.label5.Text = time1.ToString();
        }

        private void button_addEvent_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void tabPage_fav_Click(object sender, EventArgs e)
        {
           
        }

        private void listView_drugs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mname = comboBox_ep_medName.Text;
            string mamount = comboBox_ep_amountMed.Text;
            string mtime = comboBox_ep_medTime.Text;
            string mdays = comboBox_med_days.Text;
            ListViewItem itemMed=new ListViewItem(mname);
            itemMed.SubItems.Add(mamount);
            itemMed.SubItems.Add(mtime);
            itemMed.SubItems.Add(mdays);
            listView_ep_med.Items.Add(itemMed);
        }

        private void tabPage_diag_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage_home_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_fav2_search_Click(object sender, EventArgs e)
        {

        }

        private void button_fav_search_Click(object sender, EventArgs e)
        {

        }

        private void textBox_fav2_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_fav_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_deleteDrug_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_drugs.CheckedItems)
            {
                listView_drugs.Items.Remove(item);
            }
        }

        private void button_deleteDis_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listView_dis.CheckedItems)
            {
                listView_dis.Items.Remove(item);
            }
        }

        private void button_addDis_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_dis.CheckedItems)
            {
                String diseaseNames = item.SubItems[1].Text;
                comboBox1_ep_diagnosis.Items.Add(diseaseNames);
                comboBox_ep_medName.DisplayMember = diseaseNames;


            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView_dis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string invName = comboBox_ep_medInvest.Text;
            string invType = comboBox_med_detailsInvest.Text;
            ListViewItem iteminvest = new ListViewItem(invName);
            iteminvest.SubItems.Add(invType);
            listView_ep_investigation.Items.Add(iteminvest);


        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_searchPatient_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_searchPat_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nameofpat = textBox_ep_name.Text;
            string ageofpat = textBox_ep_age.Text;
            string weightofpat = textBox_ep_weight.Text;
            string heightofpat = textBox_ep_height.Text;
            string pulserateofpat = textBox_ep_plseRate.Text;
            string syspresofpat = textBox_ep_SysPre.Text;
            string dispresofpat = textBox_ep_diasPressure.Text;
            string lastd = comboBox_d1.Text;
            string lastm = comboBox_m1.Text;
            string lasty = comboBox_y1.Text;
            string fastd = comboBox_d2.Text;
            string fastm = comboBox_m2.Text;
            string fasty = comboBox_y2.Text;
            string lv = lastd + "/" + lastm + "/" + lasty;
            string nv = fastd + "/" + fastm + "/" + fasty + "/";
            string reff = comboBox_ep_referral.Text;
            string actualid = textBox_newid.Text + comboBox_d1.Text + comboBox_m1.Text + comboBox_y1.Text;
            MessageBox.Show(actualid);
            string patid = @"G:\VIsual Studio\codes\d_pad\d_pad\prescription2\";
            string fname = @"" + actualid + ".pdf";
            //string filename =Path.
            string fullpath = Path.Combine(patid, actualid + ".pdf");
            FileStream file = new FileStream(fullpath, FileMode.Create);

            string fullpathname = Path.GetFullPath(fullpath);

            Document doc1 = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri1 = PdfWriter.GetInstance(doc1, file);
            doc1.Open();
            Paragraph para;
            Paragraph idpara = new Paragraph("Patient ID :"+actualid);
            para = new Paragraph("Dr.Selina Shaba\nM.B.B.S(DMC),FCPS(BMUH)\nCardiologist\nPatient Watching Time:3:00pm-7:00pm    Days:Fri,Sat,Tues,Wed\n\n" +
                "Patient Name: " + nameofpat + "                                                                                       Age: " + ageofpat + "\n_________________________________________________________________________________\n"
                + "Height: " + heightofpat + "cm                             Weight: " + weightofpat + "kg                             Pulse: " + pulserateofpat + "/min                             Pressure: " + syspresofpat + "/" + dispresofpat + "\n\n");
           




            string medescription = "Medicine Name:              Amount :              Time :                Days:\n\n";
            foreach (ListViewItem medicines in listView_ep_med.Items)
            {
                medescription = medescription + medicines.SubItems[0].Text + "                     " + medicines.SubItems[1].Text + "                          " + medicines.SubItems[2].Text + "                            " + medicines.SubItems[3].Text + "\n";

            }
            string investig = "Required Investigatings :                       Details :   \n\n";
            foreach (ListViewItem investigations in listView_ep_investigation.Items)
            {
                investig = investig + investigations.SubItems[0].Text + "     " + investigations.SubItems[1].Text + "\n";

            }





            PdfPTable table1 = new PdfPTable(2);
            table1.WidthPercentage = 100;

            float[] width = { 200f, 600f };
            table1.SetWidths(width);

            table1.AddCell(investig);

            PdfPCell cellMed = new PdfPCell(new Phrase(medescription));
            //cellMed.Rowspan=2;

            //cellMed.Colspan = 2;
            table1.AddCell(cellMed);

            PdfPCell reffCell = new PdfPCell(new Phrase(reff));
            reffCell.Colspan = 2;
            table1.AddCell("Referred To: "+reffCell);

            Paragraph para2 = new Paragraph("Last Visit: " + comboBox_d1.Text + "/" + comboBox_m1.Text + "/" + comboBox_y1.Text);
            Paragraph para3 = new Paragraph("Next Visit: " + comboBox_d2.Text + "/" + comboBox_m2.Text + "/" + comboBox_y2.Text);

            para.Alignment = Element.ALIGN_CENTER;
            para2.Alignment = Element.ALIGN_LEFT;
            para3.Alignment = Element.ALIGN_RIGHT;
            idpara.Alignment = Element.ALIGN_TOP;
            idpara.Alignment = Element.ALIGN_RIGHT;
            //para1.Alignment = Element.ALIGN_CENTER;
            //para1.FontFamily =FontFamily.GenericSansSerif;
            doc1.Add(idpara);
            doc1.Add(para);
            doc1.Add(table1);
            doc1.Add(para2);
            doc1.Add(para3);
            doc1.Close();
           
           System.Diagnostics.Process.Start(fullpathname);

          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //con.Open();
            string nameofpat = textBox_ep_name.Text;
            string ageofpat = textBox_ep_age.Text;
            string weightofpat = textBox_ep_weight.Text;
            string heightofpat = textBox_ep_height.Text;
            string pulserateofpat = textBox_ep_plseRate.Text;
            string syspresofpat = textBox_ep_SysPre.Text;
            string dispresofpat = textBox_ep_diasPressure.Text;
            string lastd = comboBox_d1.Text;
            string lastm = comboBox_m1.Text;
            string lasty = comboBox_y1.Text;
            string fastd = comboBox_d2.Text;
            string fastm = comboBox_m2.Text;
            string fasty = comboBox_y2.Text;
            string lv = lastd + "/" + lastm + "/" + lasty;
            string nv = fastd + "/" + fastm + "/" + fasty + "/";
            string reff=comboBox_ep_referral.Text;
            string actualid = textBox_newid.Text + comboBox_d1.Text + comboBox_m1.Text + comboBox_y1.Text;
            MessageBox.Show(actualid);
            string patid = @"G:\VIsual Studio\codes\d_pad\d_pad\prescriptions\";
            string fname = @"" + actualid + ".pdf";
            //string filename =Path.
            string fullpath = Path.Combine(patid, actualid + ".pdf");
            FileStream file = new FileStream(fullpath, FileMode.Create);

            string fullpathname = Path.GetFullPath(fullpath);

            Document doc1 = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri1 = PdfWriter.GetInstance(doc1, file);
            doc1.Open();
            Paragraph para;
            para = new Paragraph("Dr.Selina Shaba\nM.B.B.S(DMC),FCPS(BMUH)\nCardiologist\nPatient Watching Time:3:00pm-7:00pm    Days:Fri,Sat,Tues,Wed\n\n"+
                "Patient Name: "+nameofpat+"                                                                    Age: "+ageofpat+"\n_________________________________________________________________________________\n"
                + "Height: " + heightofpat + "cm                             Weight: " + weightofpat + "kg                             Pulse: " + pulserateofpat + "/min                             Pressure: " + syspresofpat + "/" + dispresofpat + "\n\n");
            //para
            Paragraph para1 = new Paragraph("History\n" + "\n\n"+ richTextBox_history.Text+"\n\n");
            Paragraph paraid = new Paragraph("Patient ID :" + actualid);





            string medescription="Medicine Name:              Amount :              Time :                Days:\n\n";
            foreach (ListViewItem medicines in listView_ep_med.Items)
            {                                                                                      
                medescription =  medescription + medicines.SubItems[0].Text + "                     " + medicines.SubItems[1].Text + "                          " + medicines.SubItems[2].Text+ "                            "+medicines.SubItems[3].Text+"\n";

            }
            string diagno="Possible Diagnosis :\n\n" ;
            foreach (ListViewItem diagonsis in listView_ep_diag.Items)
            {
                diagno = diagno + diagonsis.Text+"\n";

            }

            string investig="Required Investigatings :                       Details :   \n\n";
             foreach (ListViewItem investigations in listView_ep_investigation.Items)
            {
                diagno = diagno + investigations.SubItems[0].Text + "     " + investigations.SubItems[1].Text + "\n";

            }

            


             
            PdfPTable table1 = new PdfPTable(2);
            table1.WidthPercentage=100;
          
            float[] width={200f,600f};
            table1.SetWidths(width);

            table1.AddCell(para1);

            PdfPCell cellMed=new PdfPCell(new Phrase(medescription));
            cellMed.Rowspan=2;
           
            //cellMed.Colspan = 2;
            table1.AddCell(cellMed);

            table1.AddCell(diagno);
            table1.AddCell(investig);

            PdfPCell reffCell=new PdfPCell(new Phrase(reff));
           reffCell.Colspan=2;
            table1.AddCell("Referred to :"+reffCell);
            
            Paragraph para2 = new Paragraph("Last Visit: "+comboBox_d1.Text+"/"+comboBox_m1.Text+"/"+comboBox_y1.Text);
            Paragraph para3 = new Paragraph("Next Visit: " + comboBox_d2.Text + "/" + comboBox_m2.Text + "/" + comboBox_y2.Text);

            para.Alignment = Element.ALIGN_CENTER;
            para2.Alignment = Element.ALIGN_LEFT;
            para3.Alignment = Element.ALIGN_RIGHT;
            paraid.Alignment = Element.ALIGN_RIGHT;
            paraid.Alignment = Element.ALIGN_TOP;
            //para1.Alignment = Element.ALIGN_CENTER;
            //para1.FontFamily =FontFamily.GenericSansSerif;
            doc1.Add(paraid);
            doc1.Add(para);
            doc1.Add(table1);
            doc1.Add(para2);
            doc1.Add(para3);
            doc1.Close();
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            string contact=textBox_ep_contact.Text;
            string sqlrecent = "INSERT INTO `patientmanagement`(`patient_name`,`contactpat`,`last_visit`,`next_visit`,`prescription`) VALUES ('" + nameofpat + "', '" + contact + "', '" + lv + "', '" + nv + "', '" + actualid + "')"; 
                MySqlCommand cmdaddpat = new MySqlCommand(sqlrecent, con);
                //MySqlDataReader readerecent = cmdrecent.ExecuteReader();
                cmdaddpat.ExecuteNonQuery();
            
            con.Close();
            //System.Diagnostics.Process.Start(fullpathname);
          

        }

        private void tabPage_manP_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            listView_patientManagement.Items.Clear();
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            string sqlrecent = "SELECT `ID11`,`patient_name`,`contactpat`,`last_visit`,`next_visit`,`prescription` FROM patientmanagement ORDER BY ID11 ASC";
            MySqlCommand cmdrecent = new MySqlCommand(sqlrecent, con);
            MySqlDataReader readerecent = cmdrecent.ExecuteReader();
            while (readerecent.Read())
            {
                ListViewItem recentitem = new ListViewItem(readerecent["ID11"].ToString());
                recentitem.SubItems.Add(readerecent["patient_name"].ToString());
                recentitem.SubItems.Add(readerecent["contactpat"].ToString());
                recentitem.SubItems.Add(readerecent["last_visit"].ToString());
                recentitem.SubItems.Add(readerecent["next_visit"].ToString());
                recentitem.SubItems.Add(readerecent["prescription"].ToString());
                listView_patientManagement.Items.Add(recentitem);



            }
            con.Close();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            listView_patientManagement.Items.Clear();
            if (con.State == ConnectionState.Open)
                con.Close();
            listView_patientManagement.Items.Clear();
            con.Open();
            MySqlCommand cmd;
            MySqlDataReader read;
            string str = textBox_Search_pat.Text;
           
            ListViewItem item;
            
               
                string sql = "SELECT `ID11`,`patient_name`,`contactpat`,`last_visit`,`next_visit`,`prescription` FROM patientmanagement WHERE `prescription`='"+str+"'";
                cmd = new MySqlCommand(sql, con);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    item = new ListViewItem(read["ID11"].ToString());
                    item.SubItems.Add(read["patient_name"].ToString());
                    item.SubItems.Add(read["contactpat"].ToString());
                    item.SubItems.Add(read["last_visit"].ToString());
                    item.SubItems.Add(read["next_visit"].ToString());
                    item.SubItems.Add(read["prescription"].ToString());
                    listView_patientManagement.Items.Add(item);
                 
                }
            
                       con.Close();
        }

        private void button_all_Click(object sender, EventArgs e)
        {
            listView_patientManagement.Items.Clear();
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            string sqlrecent = "SELECT `ID11`,`patient_name`,`contactpat`,`last_visit`,`next_visit`,`prescription` FROM patientmanagement";
            MySqlCommand cmdrecent = new MySqlCommand(sqlrecent, con);
            MySqlDataReader readerecent = cmdrecent.ExecuteReader();
            while (readerecent.Read())
            {
                ListViewItem recentitem = new ListViewItem(readerecent["ID11"].ToString());
                recentitem.SubItems.Add(readerecent["patient_name"].ToString());
                recentitem.SubItems.Add(readerecent["contactpat"].ToString());
                recentitem.SubItems.Add(readerecent["last_visit"].ToString());
                recentitem.SubItems.Add(readerecent["next_visit"].ToString());
                recentitem.SubItems.Add(readerecent["prescription"].ToString());
                listView_patientManagement.Items.Add(recentitem);



            }
            con.Close();
        }

        private void button_recent_Click(object sender, EventArgs e)
        {
            listView_patientManagement.Items.Clear();
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            string sqlrecent = "SELECT `ID11`,`patient_name`,`contactpat`,`last_visit`,`next_visit`,`prescription` FROM patientmanagement ORDER BY ID11 DESC";
            MySqlCommand cmdrecent = new MySqlCommand(sqlrecent,con);
            MySqlDataReader readerecent = cmdrecent.ExecuteReader();
            while (readerecent.Read())
            {
                ListViewItem recentitem = new ListViewItem(readerecent["ID11"].ToString());
                recentitem.SubItems.Add(readerecent["patient_name"].ToString());
                recentitem.SubItems.Add(readerecent["contactpat"].ToString());
                recentitem.SubItems.Add(readerecent["last_visit"].ToString());
                recentitem.SubItems.Add(readerecent["next_visit"].ToString());
                recentitem.SubItems.Add(readerecent["prescription"].ToString());
                listView_patientManagement.Items.Add(recentitem);



            }
            con.Close();

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            foreach (ListViewItem patdel in listView_patientManagement.CheckedItems)
            {
                string id = patdel.SubItems[0].Text;
                string sqlrecent = "DELETE FROM patientmanagement WHERE  `ID11`='" + id + "'";
                MySqlCommand cmdrecent = new MySqlCommand(sqlrecent, con);
                //MySqlDataReader readerecent = cmdrecent.ExecuteReader();
                cmdrecent.ExecuteNonQuery();
                patdel.Remove();
            }
            con.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

       /* private void button_search_old_pat_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            string searchWithId = textBox_oldpat.Text;
            string sql = "SELECT prescription 1 `patient_id` FROM table ORDER BY Id ASC";
            MySqlCommand cmd2 = new MySqlCommand(sql, con);
            MySqlDataReader red = cmd2.ExecuteReader();
            if (red.Read())
            {
                string idstr = red["patient_id"].ToString();
                id = Int32.Parse(idstr);
                id++;
                textBox_newid.Text = id.ToString();
            }
            con.Close();
        } */

        private void textBox_oldpat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_ep_med.SelectedItems)
            {
                listView_ep_med.Items.Remove(item);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_ep_investigation.SelectedItems)
            {
                listView_ep_investigation.Items.Remove(item);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_ep_diag.SelectedItems)
            {
                listView_ep_diag.Items.Remove(item);

            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            MySqlConnection con2 = dbConnect.Initialize();
            con2.Open();
            string sql1 = "SELECT DISTINCT code,disname FROM code_fav";
            
            MySqlCommand cmd1, cmd2;
            cmd1 = new MySqlCommand(sql1, con2);
           
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                ListViewItem item1 = new ListViewItem(reader1["code"].ToString());
                item1.SubItems.Add(reader1["disname"].ToString());
                listView_dis.Items.Add(item1);
            }
            con2.Close();
            con2.Open();
            string sql2 = "SELECT DISTINCT  `ID6`,`dname`,`gname`,`tuse` FROM `drug_fav`";
            cmd2 = new MySqlCommand(sql2, con2);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                ListViewItem item1 = new ListViewItem(reader2["ID6"].ToString());
                item1.SubItems.Add(reader2["dname"].ToString());
                item1.SubItems.Add(reader2["gname"].ToString());
                item1.SubItems.Add(reader2["tuse"].ToString());
                listView_drugs.Items.Add(item1);
            }

            con2.Close();
        }

        private void comboBox1_ep_diagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mdays = comboBox1_ep_diagnosis.Text;
            ListViewItem itemMed = new ListViewItem(mdays);
            listView_ep_diag.Items.Add(itemMed);
        }

        private void button_openPrespat_Click(object sender, EventArgs e)
        {
           // string id=textBox_oldpat.Text;
        }
    }
}
