namespace AMS
{
    partial class ParticipantForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticipantForm));
            this.label_hello = new System.Windows.Forms.Label();
            this.label_currentEvent = new System.Windows.Forms.Label();
            this.Btn_attend = new System.Windows.Forms.Button();
            this.Btn_logout = new System.Windows.Forms.Button();
            this.label_currentDate = new System.Windows.Forms.Label();
            this.label_currentTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DataGridView_events = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Selection_attend = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_events)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.BackColor = System.Drawing.Color.Transparent;
            this.label_hello.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label_hello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.label_hello.Location = new System.Drawing.Point(16, 20);
            this.label_hello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(160, 24);
            this.label_hello.TabIndex = 0;
            this.label_hello.Text = "Hello, Student!";
            // 
            // label_currentEvent
            // 
            this.label_currentEvent.AutoSize = true;
            this.label_currentEvent.BackColor = System.Drawing.Color.Transparent;
            this.label_currentEvent.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label_currentEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.label_currentEvent.Location = new System.Drawing.Point(8, 199);
            this.label_currentEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_currentEvent.Name = "label_currentEvent";
            this.label_currentEvent.Size = new System.Drawing.Size(143, 22);
            this.label_currentEvent.TabIndex = 2;
            this.label_currentEvent.Text = "Current Class :";
            // 
            // Btn_attend
            // 
            this.Btn_attend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Btn_attend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_attend.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Btn_attend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.Btn_attend.Location = new System.Drawing.Point(466, 192);
            this.Btn_attend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_attend.MinimumSize = new System.Drawing.Size(60, 24);
            this.Btn_attend.Name = "Btn_attend";
            this.Btn_attend.Size = new System.Drawing.Size(94, 35);
            this.Btn_attend.TabIndex = 4;
            this.Btn_attend.Text = "Present";
            this.Btn_attend.UseVisualStyleBackColor = false;
            this.Btn_attend.Click += new System.EventHandler(this.Btn_attend_Click);
            // 
            // Btn_logout
            // 
            this.Btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_logout.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.Btn_logout.Location = new System.Drawing.Point(466, 90);
            this.Btn_logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_logout.Name = "Btn_logout";
            this.Btn_logout.Size = new System.Drawing.Size(94, 36);
            this.Btn_logout.TabIndex = 5;
            this.Btn_logout.Text = "Logout";
            this.Btn_logout.UseVisualStyleBackColor = false;
            this.Btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // label_currentDate
            // 
            this.label_currentDate.AutoSize = true;
            this.label_currentDate.BackColor = System.Drawing.Color.Transparent;
            this.label_currentDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_currentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label_currentDate.Location = new System.Drawing.Point(352, 30);
            this.label_currentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_currentDate.Name = "label_currentDate";
            this.label_currentDate.Size = new System.Drawing.Size(209, 19);
            this.label_currentDate.TabIndex = 6;
            this.label_currentDate.Text = "Wednesday, 3 January 2024";
            this.label_currentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_currentTime
            // 
            this.label_currentTime.AutoSize = true;
            this.label_currentTime.BackColor = System.Drawing.Color.Transparent;
            this.label_currentTime.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_currentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label_currentTime.Location = new System.Drawing.Point(462, 56);
            this.label_currentTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_currentTime.Name = "label_currentTime";
            this.label_currentTime.Size = new System.Drawing.Size(103, 19);
            this.label_currentTime.TabIndex = 7;
            this.label_currentTime.Text = "10:12:00 AM";
            this.label_currentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DataGridView_events
            // 
            this.DataGridView_events.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_events.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView_events.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.DataGridView_events.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView_events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_events.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.DataGridView_events.Location = new System.Drawing.Point(12, 263);
            this.DataGridView_events.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView_events.Name = "DataGridView_events";
            this.DataGridView_events.RowHeadersWidth = 62;
            this.DataGridView_events.RowTemplate.Height = 28;
            this.DataGridView_events.RowTemplate.ReadOnly = true;
            this.DataGridView_events.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_events.Size = new System.Drawing.Size(548, 208);
            this.DataGridView_events.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(9, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Previous Class :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AMS.Properties.Resources.Icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(20, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 161);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Selection_attend
            // 
            this.Selection_attend.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Selection_attend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.Selection_attend.FormattingEnabled = true;
            this.Selection_attend.Location = new System.Drawing.Point(155, 194);
            this.Selection_attend.Margin = new System.Windows.Forms.Padding(2);
            this.Selection_attend.Name = "Selection_attend";
            this.Selection_attend.Size = new System.Drawing.Size(306, 31);
            this.Selection_attend.TabIndex = 21;
            // 
            // ParticipantForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::AMS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 491);
            this.Controls.Add(this.Selection_attend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView_events);
            this.Controls.Add(this.label_currentTime);
            this.Controls.Add(this.label_currentDate);
            this.Controls.Add(this.Btn_logout);
            this.Controls.Add(this.Btn_attend);
            this.Controls.Add(this.label_currentEvent);
            this.Controls.Add(this.label_hello);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ParticipantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Manager System (Student)";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_events)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Label label_currentEvent;
        private System.Windows.Forms.Button Btn_attend;
        private System.Windows.Forms.Button Btn_logout;
        private System.Windows.Forms.Label label_currentDate;
        private System.Windows.Forms.Label label_currentTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView DataGridView_events;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Selection_attend;
    }
}