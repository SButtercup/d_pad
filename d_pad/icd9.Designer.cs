namespace d_pad
{
    partial class icd9
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
            this.button_closeICD9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_convertICD9 = new System.Windows.Forms.Button();
            this.button_searchicd9 = new System.Windows.Forms.Button();
            this.textBox_searchICD9 = new System.Windows.Forms.TextBox();
            this.listView_icd9 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_closeICD9
            // 
            this.button_closeICD9.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_closeICD9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_closeICD9.Location = new System.Drawing.Point(658, 135);
            this.button_closeICD9.Name = "button_closeICD9";
            this.button_closeICD9.Size = new System.Drawing.Size(174, 35);
            this.button_closeICD9.TabIndex = 15;
            this.button_closeICD9.Text = "Close";
            this.button_closeICD9.UseVisualStyleBackColor = true;
            this.button_closeICD9.Click += new System.EventHandler(this.button_closeICD9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(318, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search With Code";
            // 
            // button_convertICD9
            // 
            this.button_convertICD9.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_convertICD9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_convertICD9.Location = new System.Drawing.Point(658, 68);
            this.button_convertICD9.Name = "button_convertICD9";
            this.button_convertICD9.Size = new System.Drawing.Size(174, 61);
            this.button_convertICD9.TabIndex = 11;
            this.button_convertICD9.Text = "Convert Selected to ICD-10";
            this.button_convertICD9.UseVisualStyleBackColor = true;
            this.button_convertICD9.Click += new System.EventHandler(this.button_convertICD9_Click);
            // 
            // button_searchicd9
            // 
            this.button_searchicd9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_searchicd9.BackgroundImage = global::d_pad.Properties.Resources.download;
            this.button_searchicd9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_searchicd9.Location = new System.Drawing.Point(619, 24);
            this.button_searchicd9.Name = "button_searchicd9";
            this.button_searchicd9.Size = new System.Drawing.Size(39, 29);
            this.button_searchicd9.TabIndex = 10;
            this.button_searchicd9.UseVisualStyleBackColor = false;
            this.button_searchicd9.Click += new System.EventHandler(this.button_searchicd9_Click);
            // 
            // textBox_searchICD9
            // 
            this.textBox_searchICD9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_searchICD9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_searchICD9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchICD9.Location = new System.Drawing.Point(457, 27);
            this.textBox_searchICD9.Name = "textBox_searchICD9";
            this.textBox_searchICD9.Size = new System.Drawing.Size(156, 26);
            this.textBox_searchICD9.TabIndex = 9;
            // 
            // listView_icd9
            // 
            this.listView_icd9.BackgroundImage = global::d_pad.Properties.Resources._4140_blue_abstract21;
            this.listView_icd9.BackgroundImageTiled = true;
            this.listView_icd9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_icd9.CheckBoxes = true;
            this.listView_icd9.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView_icd9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_icd9.ForeColor = System.Drawing.Color.White;
            this.listView_icd9.GridLines = true;
            this.listView_icd9.Location = new System.Drawing.Point(12, 68);
            this.listView_icd9.Name = "listView_icd9";
            this.listView_icd9.Size = new System.Drawing.Size(646, 524);
            this.listView_icd9.TabIndex = 8;
            this.listView_icd9.UseCompatibleStateImageBehavior = false;
            this.listView_icd9.View = System.Windows.Forms.View.Details;
            this.listView_icd9.SelectedIndexChanged += new System.EventHandler(this.listView_icd9_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Code";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 577;
            // 
            // icd9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::d_pad.Properties.Resources._4140_blue_abstract;
            this.ClientSize = new System.Drawing.Size(844, 604);
            this.Controls.Add(this.button_closeICD9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_convertICD9);
            this.Controls.Add(this.button_searchicd9);
            this.Controls.Add(this.textBox_searchICD9);
            this.Controls.Add(this.listView_icd9);
            this.Name = "icd9";
            this.Text = "icd9";
            this.Load += new System.EventHandler(this.icd9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_closeICD9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_convertICD9;
        private System.Windows.Forms.Button button_searchicd9;
        private System.Windows.Forms.TextBox textBox_searchICD9;
        private System.Windows.Forms.ListView listView_icd9;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;

    }
}