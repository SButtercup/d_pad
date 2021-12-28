namespace d_pad
{
    partial class FormDrug
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
            this.listView_drug = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_searchName_drug = new System.Windows.Forms.TextBox();
            this.button_drug_search = new System.Windows.Forms.Button();
            this.button_drug_ADD = new System.Windows.Forms.Button();
            this.button_drug_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_drug
            // 
            this.listView_drug.BackgroundImage = global::d_pad.Properties.Resources._4140_blue_abstract;
            this.listView_drug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_drug.CheckBoxes = true;
            this.listView_drug.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_drug.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_drug.ForeColor = System.Drawing.SystemColors.Info;
            this.listView_drug.GridLines = true;
            this.listView_drug.Location = new System.Drawing.Point(12, 49);
            this.listView_drug.Name = "listView_drug";
            this.listView_drug.Size = new System.Drawing.Size(883, 586);
            this.listView_drug.TabIndex = 0;
            this.listView_drug.UseCompatibleStateImageBehavior = false;
            this.listView_drug.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Brand Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 191;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Generic Name";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 198;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Theraputic Use";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 388;
            // 
            // textBox_searchName_drug
            // 
            this.textBox_searchName_drug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchName_drug.Location = new System.Drawing.Point(12, 12);
            this.textBox_searchName_drug.Name = "textBox_searchName_drug";
            this.textBox_searchName_drug.Size = new System.Drawing.Size(285, 26);
            this.textBox_searchName_drug.TabIndex = 1;
            // 
            // button_drug_search
            // 
            this.button_drug_search.BackgroundImage = global::d_pad.Properties.Resources.download1;
            this.button_drug_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_drug_search.Location = new System.Drawing.Point(303, 10);
            this.button_drug_search.Name = "button_drug_search";
            this.button_drug_search.Size = new System.Drawing.Size(42, 33);
            this.button_drug_search.TabIndex = 2;
            this.button_drug_search.UseVisualStyleBackColor = true;
            this.button_drug_search.Click += new System.EventHandler(this.button_drug_search_Click);
            // 
            // button_drug_ADD
            // 
            this.button_drug_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_drug_ADD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_drug_ADD.Location = new System.Drawing.Point(901, 49);
            this.button_drug_ADD.Name = "button_drug_ADD";
            this.button_drug_ADD.Size = new System.Drawing.Size(164, 60);
            this.button_drug_ADD.TabIndex = 3;
            this.button_drug_ADD.Text = "ADD TO FAVOURITES";
            this.button_drug_ADD.UseVisualStyleBackColor = true;
            this.button_drug_ADD.Click += new System.EventHandler(this.button_drug_ADD_Click);
            // 
            // button_drug_close
            // 
            this.button_drug_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_drug_close.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_drug_close.Location = new System.Drawing.Point(901, 124);
            this.button_drug_close.Name = "button_drug_close";
            this.button_drug_close.Size = new System.Drawing.Size(164, 40);
            this.button_drug_close.TabIndex = 4;
            this.button_drug_close.Text = "CLOSE";
            this.button_drug_close.UseVisualStyleBackColor = true;
            this.button_drug_close.Click += new System.EventHandler(this.button_drug_close_Click);
            // 
            // FormDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::d_pad.Properties.Resources._4140_blue_abstract3;
            this.ClientSize = new System.Drawing.Size(1068, 647);
            this.Controls.Add(this.button_drug_close);
            this.Controls.Add(this.button_drug_ADD);
            this.Controls.Add(this.button_drug_search);
            this.Controls.Add(this.textBox_searchName_drug);
            this.Controls.Add(this.listView_drug);
            this.Name = "FormDrug";
            this.Text = "FormDrug";
            this.Load += new System.EventHandler(this.FormDrug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_drug;
        private System.Windows.Forms.TextBox textBox_searchName_drug;
        private System.Windows.Forms.Button button_drug_search;
        private System.Windows.Forms.Button button_drug_ADD;
        private System.Windows.Forms.Button button_drug_close;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}