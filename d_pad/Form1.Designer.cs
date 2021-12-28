namespace d_pad
{
    partial class Form1
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
            this.listBox_billform = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_billform
            // 
            this.listBox_billform.FormattingEnabled = true;
            this.listBox_billform.Location = new System.Drawing.Point(12, 59);
            this.listBox_billform.Name = "listBox_billform";
            this.listBox_billform.Size = new System.Drawing.Size(498, 251);
            this.listBox_billform.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 315);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(248, 33);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(191, 20);
            this.textBox_id.TabIndex = 3;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(445, 37);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(65, 16);
            this.label_id.TabIndex = 4;
            this.label_id.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bill of";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(392, 361);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(118, 23);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Total and Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount";
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(12, 361);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(127, 23);
            this.button_print.TabIndex = 8;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 396);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox_billform);
            this.Name = "Form1";
            this.Text = "Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_billform;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_print;
    }
}