namespace AMS
{
    partial class InstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorForm));
            this.label_currentTime = new System.Windows.Forms.Label();
            this.label_currentDate = new System.Windows.Forms.Label();
            this.Btn_logout = new System.Windows.Forms.Button();
            this.label_hello = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.TimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.Input_eventName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_create = new System.Windows.Forms.Button();
            this.label_currentEvent = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Grid_eventsList = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Selection_attendHistory = new System.Windows.Forms.ComboBox();
            this.Grid_attendanceHistory = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_eventsList)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_attendanceHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_currentTime
            // 
            this.label_currentTime.AutoSize = true;
            this.label_currentTime.BackColor = System.Drawing.Color.Transparent;
            this.label_currentTime.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_currentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label_currentTime.Location = new System.Drawing.Point(462, 47);
            this.label_currentTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_currentTime.Name = "label_currentTime";
            this.label_currentTime.Size = new System.Drawing.Size(103, 19);
            this.label_currentTime.TabIndex = 17;
            this.label_currentTime.Text = "10:12:00 AM";
            this.label_currentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_currentDate
            // 
            this.label_currentDate.AutoSize = true;
            this.label_currentDate.BackColor = System.Drawing.Color.Transparent;
            this.label_currentDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_currentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label_currentDate.Location = new System.Drawing.Point(352, 21);
            this.label_currentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_currentDate.Name = "label_currentDate";
            this.label_currentDate.Size = new System.Drawing.Size(209, 19);
            this.label_currentDate.TabIndex = 16;
            this.label_currentDate.Text = "Wednesday, 3 January 2024";
            this.label_currentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_logout
            // 
            this.Btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_logout.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.Btn_logout.Location = new System.Drawing.Point(466, 82);
            this.Btn_logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_logout.Name = "Btn_logout";
            this.Btn_logout.Size = new System.Drawing.Size(94, 38);
            this.Btn_logout.TabIndex = 5;
            this.Btn_logout.Text = "Logout";
            this.Btn_logout.UseVisualStyleBackColor = false;
            this.Btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.BackColor = System.Drawing.Color.Transparent;
            this.label_hello.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label_hello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.label_hello.Location = new System.Drawing.Point(16, 21);
            this.label_hello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(175, 24);
            this.label_hello.TabIndex = 14;
            this.label_hello.Text = "Hello, Professor!";
            this.label_hello.Click += new System.EventHandler(this.label_hello_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabControl1.Location = new System.Drawing.Point(16, 124);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 343);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tabPage1.Controls.Add(this.TimePicker_end);
            this.tabPage1.Controls.Add(this.TimePicker_start);
            this.tabPage1.Controls.Add(this.Input_eventName);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Btn_create);
            this.tabPage1.Controls.Add(this.label_currentEvent);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(540, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Class.";
            // 
            // TimePicker_end
            // 
            this.TimePicker_end.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.TimePicker_end.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.TimePicker_end.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.TimePicker_end.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.TimePicker_end.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.TimePicker_end.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker_end.Location = new System.Drawing.Point(333, 116);
            this.TimePicker_end.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimePicker_end.MinimumSize = new System.Drawing.Size(162, 30);
            this.TimePicker_end.Name = "TimePicker_end";
            this.TimePicker_end.Size = new System.Drawing.Size(162, 30);
            this.TimePicker_end.TabIndex = 19;
            // 
            // TimePicker_start
            // 
            this.TimePicker_start.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.TimePicker_start.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.TimePicker_start.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.TimePicker_start.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.TimePicker_start.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.TimePicker_start.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker_start.Location = new System.Drawing.Point(126, 116);
            this.TimePicker_start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimePicker_start.MinimumSize = new System.Drawing.Size(162, 30);
            this.TimePicker_start.Name = "TimePicker_start";
            this.TimePicker_start.Size = new System.Drawing.Size(162, 30);
            this.TimePicker_start.TabIndex = 18;
            // 
            // Input_eventName
            // 
            this.Input_eventName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Input_eventName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.Input_eventName.Location = new System.Drawing.Point(126, 78);
            this.Input_eventName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Input_eventName.MinimumSize = new System.Drawing.Size(368, 30);
            this.Input_eventName.Name = "Input_eventName";
            this.Input_eventName.Size = new System.Drawing.Size(368, 24);
            this.Input_eventName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(110, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(110, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(305, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(35, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(35, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // Btn_create
            // 
            this.Btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_create.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Btn_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.Btn_create.Location = new System.Drawing.Point(348, 211);
            this.Btn_create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_create.MinimumSize = new System.Drawing.Size(114, 32);
            this.Btn_create.Name = "Btn_create";
            this.Btn_create.Size = new System.Drawing.Size(144, 50);
            this.Btn_create.TabIndex = 4;
            this.Btn_create.Text = "Create Class";
            this.Btn_create.UseVisualStyleBackColor = false;
            this.Btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // label_currentEvent
            // 
            this.label_currentEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_currentEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.label_currentEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_currentEvent.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label_currentEvent.Location = new System.Drawing.Point(0, 0);
            this.label_currentEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_currentEvent.Name = "label_currentEvent";
            this.label_currentEvent.Size = new System.Drawing.Size(542, 41);
            this.label_currentEvent.TabIndex = 5;
            this.label_currentEvent.Text = "Create a Class :";
            this.label_currentEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.tabPage2.Controls.Add(this.Grid_eventsList);
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(540, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List of Class.";
            // 
            // Grid_eventsList
            // 
            this.Grid_eventsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_eventsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_eventsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.Grid_eventsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_eventsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.Grid_eventsList.Location = new System.Drawing.Point(0, 40);
            this.Grid_eventsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grid_eventsList.Name = "Grid_eventsList";
            this.Grid_eventsList.RowHeadersWidth = 62;
            this.Grid_eventsList.RowTemplate.Height = 28;
            this.Grid_eventsList.Size = new System.Drawing.Size(544, 333);
            this.Grid_eventsList.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.Selection_attendHistory);
            this.tabPage4.Controls.Add(this.Grid_attendanceHistory);
            this.tabPage4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(540, 314);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Class History.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(126, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select a class";
            // 
            // Selection_attendHistory
            // 
            this.Selection_attendHistory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Selection_attendHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.Selection_attendHistory.FormattingEnabled = true;
            this.Selection_attendHistory.Location = new System.Drawing.Point(144, 8);
            this.Selection_attendHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Selection_attendHistory.Name = "Selection_attendHistory";
            this.Selection_attendHistory.Size = new System.Drawing.Size(165, 27);
            this.Selection_attendHistory.TabIndex = 18;
            this.Selection_attendHistory.SelectedIndexChanged += new System.EventHandler(this.Selection_attendHistory_SelectedIndexChanged);
            // 
            // Grid_attendanceHistory
            // 
            this.Grid_attendanceHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_attendanceHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_attendanceHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.Grid_attendanceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_attendanceHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.Grid_attendanceHistory.Location = new System.Drawing.Point(0, 40);
            this.Grid_attendanceHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grid_attendanceHistory.Name = "Grid_attendanceHistory";
            this.Grid_attendanceHistory.RowHeadersWidth = 62;
            this.Grid_attendanceHistory.RowTemplate.Height = 28;
            this.Grid_attendanceHistory.Size = new System.Drawing.Size(544, 333);
            this.Grid_attendanceHistory.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AMS.Properties.Resources.Icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 99);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // InstructorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.BackgroundImage = global::AMS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 485);
            this.Controls.Add(this.label_currentTime);
            this.Controls.Add(this.label_currentDate);
            this.Controls.Add(this.Btn_logout);
            this.Controls.Add(this.label_hello);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InstructorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Manager System (Professor)";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_eventsList)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_attendanceHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_currentTime;
        private System.Windows.Forms.Label label_currentDate;
        private System.Windows.Forms.Button Btn_logout;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_create;
        private System.Windows.Forms.Label label_currentEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Input_eventName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView Grid_eventsList;
        private System.Windows.Forms.DateTimePicker TimePicker_start;
        private System.Windows.Forms.DateTimePicker TimePicker_end;
        private System.Windows.Forms.DataGridView Grid_attendanceHistory;
        private System.Windows.Forms.ComboBox Selection_attendHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}