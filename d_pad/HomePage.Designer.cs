namespace d_pad
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox_home_specialty = new System.Windows.Forms.ComboBox();
            this.comboBox_home_dist = new System.Windows.Forms.ComboBox();
            this.comboBox_home_area = new System.Windows.Forms.ComboBox();
            this.label_home_specialtiy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_home_area = new System.Windows.Forms.Label();
            this.label_home_dist = new System.Windows.Forms.Label();
            this.button_home_doctor = new System.Windows.Forms.Button();
            this.button_home_staff = new System.Windows.Forms.Button();
            this.dataGridView_docInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_docInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_home_specialty
            // 
            this.comboBox_home_specialty.AllowDrop = true;
            this.comboBox_home_specialty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_home_specialty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_home_specialty.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_home_specialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_home_specialty.FormattingEnabled = true;
            this.comboBox_home_specialty.Items.AddRange(new object[] {
            "Allergist",
            "Audiologist",
            "Cardiologist",
            "Dentist",
            "Dermatologist",
            "Endocrionologist",
            "ENT Specialist",
            "Epidemiologist",
            "Gynecologist",
            "Immunologist",
            "Infectious Disease Specialist",
            "Medicine",
            "Neurologist",
            "Obstetrician",
            "Oncologist",
            "Orthopedic Surgeon",
            "Orthopedics",
            "Plastic Surgeon",
            "Psychiatrist",
            "Urologist"});
            this.comboBox_home_specialty.Location = new System.Drawing.Point(74, 65);
            this.comboBox_home_specialty.Name = "comboBox_home_specialty";
            this.comboBox_home_specialty.Size = new System.Drawing.Size(209, 28);
            this.comboBox_home_specialty.Sorted = true;
            this.comboBox_home_specialty.TabIndex = 2;
            this.comboBox_home_specialty.SelectedIndexChanged += new System.EventHandler(this.comboBox_home_specialty_SelectedIndexChanged);
            // 
            // comboBox_home_dist
            // 
            this.comboBox_home_dist.AllowDrop = true;
            this.comboBox_home_dist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_home_dist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_home_dist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_home_dist.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_home_dist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_home_dist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox_home_dist.FormattingEnabled = true;
            this.comboBox_home_dist.Items.AddRange(new object[] {
            "Bagerhat",
            "Bandarban",
            "Barguna",
            "Barisal",
            "Bhola",
            "Bogra",
            "Brahmanbaria",
            "Chandpur",
            "Chapai-nawabganj",
            "Chittagong",
            "Chuadanga",
            "Comilla",
            "Cox-bazar",
            "Dhaka",
            "Dinajpur",
            "Faridpur",
            "Feni",
            "Gaibandha",
            "Gazipur",
            "Gopalganj",
            "Habiganj",
            "Jamalpur",
            "Jessore",
            "Jhalokati",
            "Jhenaidah",
            "Joypurhat",
            "Khagrachari",
            "Khulna",
            "Kishoreganj",
            "Kurigram",
            "Kushtia",
            "Lakshimipur",
            "Lalmonirhat",
            "Madaripur",
            "Magura",
            "Manikgonj",
            "Maulvibazar",
            "Meherpur",
            "Munshiganj",
            "Mymensingh",
            "Naogaon",
            "Narail",
            "Narayanganj",
            "Narsingdi",
            "Natore",
            "Netrakona",
            "Nilphamari",
            "Noakhali",
            "Pabna",
            "Panchagarh",
            "Patuakhali",
            "Patuakhali",
            "Pirojpur",
            "Rajbari",
            "Rajshahi",
            "Rangamati",
            "Rangpur",
            "Satkhira",
            "Shariatpur",
            "Sherpur",
            "Sirajganj",
            "Sunamganj",
            "Sylhet",
            "Tangail",
            "Thakurgaon"});
            this.comboBox_home_dist.Location = new System.Drawing.Point(395, 65);
            this.comboBox_home_dist.Name = "comboBox_home_dist";
            this.comboBox_home_dist.Size = new System.Drawing.Size(222, 28);
            this.comboBox_home_dist.Sorted = true;
            this.comboBox_home_dist.TabIndex = 3;
            this.comboBox_home_dist.SelectedIndexChanged += new System.EventHandler(this.comboBox_home_dist_SelectedIndexChanged);
            // 
            // comboBox_home_area
            // 
            this.comboBox_home_area.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_home_area.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_home_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_home_area.FormattingEnabled = true;
            this.comboBox_home_area.Location = new System.Drawing.Point(728, 65);
            this.comboBox_home_area.Name = "comboBox_home_area";
            this.comboBox_home_area.Size = new System.Drawing.Size(186, 28);
            this.comboBox_home_area.TabIndex = 4;
            this.comboBox_home_area.SelectedIndexChanged += new System.EventHandler(this.comboBox_home_area_SelectedIndexChanged);
            // 
            // label_home_specialtiy
            // 
            this.label_home_specialtiy.AutoSize = true;
            this.label_home_specialtiy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_home_specialtiy.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home_specialtiy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_home_specialtiy.Location = new System.Drawing.Point(70, 23);
            this.label_home_specialtiy.Name = "label_home_specialtiy";
            this.label_home_specialtiy.Size = new System.Drawing.Size(110, 21);
            this.label_home_specialtiy.TabIndex = 5;
            this.label_home_specialtiy.Text = "Speciality";
            this.label_home_specialtiy.Click += new System.EventHandler(this.label_home_specialtiy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label_home_area
            // 
            this.label_home_area.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_home_area.AutoSize = true;
            this.label_home_area.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_home_area.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home_area.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_home_area.Location = new System.Drawing.Point(733, 25);
            this.label_home_area.Name = "label_home_area";
            this.label_home_area.Size = new System.Drawing.Size(59, 21);
            this.label_home_area.TabIndex = 7;
            this.label_home_area.Text = "Area";
            // 
            // label_home_dist
            // 
            this.label_home_dist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_home_dist.AutoSize = true;
            this.label_home_dist.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_home_dist.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home_dist.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_home_dist.Location = new System.Drawing.Point(391, 23);
            this.label_home_dist.Name = "label_home_dist";
            this.label_home_dist.Size = new System.Drawing.Size(84, 21);
            this.label_home_dist.TabIndex = 8;
            this.label_home_dist.Text = "District";
            // 
            // button_home_doctor
            // 
            this.button_home_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_home_doctor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_home_doctor.BackgroundImage = global::d_pad.Properties.Resources.images__1_1;
            this.button_home_doctor.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home_doctor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_home_doctor.Location = new System.Drawing.Point(74, 376);
            this.button_home_doctor.Name = "button_home_doctor";
            this.button_home_doctor.Size = new System.Drawing.Size(134, 40);
            this.button_home_doctor.TabIndex = 9;
            this.button_home_doctor.Text = "    Doctor";
            this.button_home_doctor.UseVisualStyleBackColor = false;
            this.button_home_doctor.Click += new System.EventHandler(this.button_home_doctor_Click);
            // 
            // button_home_staff
            // 
            this.button_home_staff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_home_staff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_home_staff.BackgroundImage = global::d_pad.Properties.Resources.Red_Cross_Nurse_Assistant_Training_e1376390911616;
            this.button_home_staff.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home_staff.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_home_staff.Location = new System.Drawing.Point(74, 467);
            this.button_home_staff.Name = "button_home_staff";
            this.button_home_staff.Size = new System.Drawing.Size(134, 40);
            this.button_home_staff.TabIndex = 10;
            this.button_home_staff.Text = "      Staff";
            this.button_home_staff.UseVisualStyleBackColor = false;
            this.button_home_staff.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView_docInfo
            // 
            this.dataGridView_docInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_docInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView_docInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_docInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView_docInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_docInfo.Location = new System.Drawing.Point(74, 187);
            this.dataGridView_docInfo.Name = "dataGridView_docInfo";
            this.dataGridView_docInfo.Size = new System.Drawing.Size(840, 134);
            this.dataGridView_docInfo.TabIndex = 11;
            this.dataGridView_docInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_docInfo_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(715, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Doctors In My Area";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(877, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::d_pad.Properties.Resources.Stethoscope_By_Computer_Keyboard411;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_docInfo);
            this.Controls.Add(this.button_home_staff);
            this.Controls.Add(this.button_home_doctor);
            this.Controls.Add(this.label_home_dist);
            this.Controls.Add(this.label_home_area);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_home_specialtiy);
            this.Controls.Add(this.comboBox_home_area);
            this.Controls.Add(this.comboBox_home_dist);
            this.Controls.Add(this.comboBox_home_specialty);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_docInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox_home_specialty;
        private System.Windows.Forms.ComboBox comboBox_home_dist;
        private System.Windows.Forms.ComboBox comboBox_home_area;
        private System.Windows.Forms.Label label_home_specialtiy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_home_area;
        private System.Windows.Forms.Label label_home_dist;
        private System.Windows.Forms.Button button_home_doctor;
        private System.Windows.Forms.Button button_home_staff;
        private System.Windows.Forms.DataGridView dataGridView_docInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

