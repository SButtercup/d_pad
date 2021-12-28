namespace d_pad
{
    partial class EventsManager
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
            this.listView_events = new System.Windows.Forms.ListView();
            this.button_event_add = new System.Windows.Forms.Button();
            this.button_event_delete = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_event = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_events
            // 
            this.listView_events.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_events.Location = new System.Drawing.Point(12, 28);
            this.listView_events.Name = "listView_events";
            this.listView_events.Size = new System.Drawing.Size(440, 177);
            this.listView_events.TabIndex = 0;
            this.listView_events.UseCompatibleStateImageBehavior = false;
            this.listView_events.View = System.Windows.Forms.View.Details;
            this.listView_events.SelectedIndexChanged += new System.EventHandler(this.listView_events_SelectedIndexChanged);
            // 
            // button_event_add
            // 
            this.button_event_add.Location = new System.Drawing.Point(565, 153);
            this.button_event_add.Name = "button_event_add";
            this.button_event_add.Size = new System.Drawing.Size(75, 23);
            this.button_event_add.TabIndex = 1;
            this.button_event_add.Text = "add";
            this.button_event_add.UseVisualStyleBackColor = true;
            this.button_event_add.Click += new System.EventHandler(this.button_event_add_Click);
            // 
            // button_event_delete
            // 
            this.button_event_delete.Location = new System.Drawing.Point(565, 182);
            this.button_event_delete.Name = "button_event_delete";
            this.button_event_delete.Size = new System.Drawing.Size(75, 23);
            this.button_event_delete.TabIndex = 2;
            this.button_event_delete.Text = "delete";
            this.button_event_delete.UseVisualStyleBackColor = true;
            this.button_event_delete.Click += new System.EventHandler(this.button_event_delete_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event";
            this.columnHeader1.Width = 376;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "date";
            this.columnHeader3.Width = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // textBox_event
            // 
            this.textBox_event.Location = new System.Drawing.Point(461, 44);
            this.textBox_event.Name = "textBox_event";
            this.textBox_event.Size = new System.Drawing.Size(179, 20);
            this.textBox_event.TabIndex = 4;
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(461, 93);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(179, 20);
            this.textBox_time.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Event";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time";
            // 
            // EventsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(652, 223);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.textBox_event);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_event_delete);
            this.Controls.Add(this.button_event_add);
            this.Controls.Add(this.listView_events);
            this.Name = "EventsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventsManager";
            this.Load += new System.EventHandler(this.EventsManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_events;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button_event_add;
        private System.Windows.Forms.Button button_event_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_event;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}