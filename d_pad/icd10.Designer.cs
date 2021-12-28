namespace d_pad
{
    partial class icd10
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
            this.listView_icd10 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_searchicd10 = new System.Windows.Forms.Button();
            this.button_convert = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_icd10_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_icd10
            // 
            this.listView_icd10.BackgroundImage = global::d_pad.Properties.Resources._4140_blue_abstract22;
            this.listView_icd10.BackgroundImageTiled = true;
            this.listView_icd10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_icd10.CheckBoxes = true;
            this.listView_icd10.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_icd10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_icd10.ForeColor = System.Drawing.SystemColors.Info;
            this.listView_icd10.FullRowSelect = true;
            this.listView_icd10.GridLines = true;
            this.listView_icd10.Location = new System.Drawing.Point(18, 84);
            this.listView_icd10.Margin = new System.Windows.Forms.Padding(4);
            this.listView_icd10.Name = "listView_icd10";
            this.listView_icd10.Size = new System.Drawing.Size(700, 513);
            this.listView_icd10.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_icd10.TabIndex = 0;
            this.listView_icd10.UseCompatibleStateImageBehavior = false;
            this.listView_icd10.View = System.Windows.Forms.View.Details;
            this.listView_icd10.SelectedIndexChanged += new System.EventHandler(this.listView_icd10_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 587;
            // 
            // textBox_search
            // 
            this.textBox_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(404, 50);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(263, 26);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // button_searchicd10
            // 
            this.button_searchicd10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_searchicd10.BackgroundImage = global::d_pad.Properties.Resources.download;
            this.button_searchicd10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_searchicd10.Location = new System.Drawing.Point(675, 43);
            this.button_searchicd10.Margin = new System.Windows.Forms.Padding(4);
            this.button_searchicd10.Name = "button_searchicd10";
            this.button_searchicd10.Size = new System.Drawing.Size(43, 39);
            this.button_searchicd10.TabIndex = 2;
            this.button_searchicd10.UseVisualStyleBackColor = false;
            this.button_searchicd10.Click += new System.EventHandler(this.button_searchicd10_Click);
            // 
            // button_convert
            // 
            this.button_convert.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_convert.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_convert.Location = new System.Drawing.Point(726, 181);
            this.button_convert.Margin = new System.Windows.Forms.Padding(4);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(175, 61);
            this.button_convert.TabIndex = 3;
            this.button_convert.Text = "Convert Selected to ICD-9";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_add.Location = new System.Drawing.Point(726, 114);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(175, 59);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add Selected to Favourites";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // comboBox_icd10_search
            // 
            this.comboBox_icd10_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_icd10_search.FormattingEnabled = true;
            this.comboBox_icd10_search.Items.AddRange(new object[] {
            "ICD-10 Code",
            "Name"});
            this.comboBox_icd10_search.Location = new System.Drawing.Point(18, 42);
            this.comboBox_icd10_search.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_icd10_search.Name = "comboBox_icd10_search";
            this.comboBox_icd10_search.Size = new System.Drawing.Size(169, 28);
            this.comboBox_icd10_search.TabIndex = 6;
            this.comboBox_icd10_search.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(198, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search With Code or Name";
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_close.Location = new System.Drawing.Point(726, 310);
            this.button_close.Margin = new System.Windows.Forms.Padding(4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(175, 36);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // icd10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::d_pad.Properties.Resources._4140_blue_abstract;
            this.ClientSize = new System.Drawing.Size(908, 602);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.comboBox_icd10_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.button_searchicd10);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.listView_icd10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "icd10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "icd10";
            this.Load += new System.EventHandler(this.icd10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_icd10;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_searchicd10;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_icd10_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}