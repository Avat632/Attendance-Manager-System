namespace AMS
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label_currentTime = new System.Windows.Forms.Label();
            this.label_currentDate = new System.Windows.Forms.Label();
            this.Btn_logout = new System.Windows.Forms.Button();
            this.label_hello = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxUserRole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_createUser = new System.Windows.Forms.Button();
            this.label_currentEvent = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Selection_roles = new System.Windows.Forms.ComboBox();
            this.Grid_usersList = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid_eventsList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_usersList)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_eventsList)).BeginInit();
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
            this.label_currentTime.TabIndex = 12;
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
            this.label_currentDate.TabIndex = 11;
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
            this.Btn_logout.TabIndex = 10;
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
            this.label_hello.Size = new System.Drawing.Size(145, 24);
            this.label_hello.TabIndex = 9;
            this.label_hello.Text = "Hello, Admin!";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.tabControl1.Size = new System.Drawing.Size(548, 323);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.comboBoxUserRole);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxPassword);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Btn_createUser);
            this.tabPage1.Controls.Add(this.label_currentEvent);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(540, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add User.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label7.Location = new System.Drawing.Point(108, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = ":";
            // 
            // comboBoxUserRole
            // 
            this.comboBoxUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.comboBoxUserRole.FormattingEnabled = true;
            this.comboBoxUserRole.Location = new System.Drawing.Point(126, 200);
            this.comboBoxUserRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxUserRole.Name = "comboBoxUserRole";
            this.comboBoxUserRole.Size = new System.Drawing.Size(156, 24);
            this.comboBoxUserRole.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label6.Location = new System.Drawing.Point(35, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label5.Location = new System.Drawing.Point(35, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.textBoxPassword.Location = new System.Drawing.Point(126, 159);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassword.MinimumSize = new System.Drawing.Size(368, 30);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(370, 24);
            this.textBoxPassword.TabIndex = 19;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.textBoxEmail.Location = new System.Drawing.Point(126, 119);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEmail.MinimumSize = new System.Drawing.Size(368, 30);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(370, 24);
            this.textBoxEmail.TabIndex = 18;
            // 
            // textBoxName
            // 
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.textBoxName.Location = new System.Drawing.Point(126, 78);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.MinimumSize = new System.Drawing.Size(368, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(370, 24);
            this.textBoxName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label10.Location = new System.Drawing.Point(108, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label9.Location = new System.Drawing.Point(108, 118);
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
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label8.Location = new System.Drawing.Point(108, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label4.Location = new System.Drawing.Point(35, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(35, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // Btn_createUser
            // 
            this.Btn_createUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Btn_createUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_createUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Btn_createUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.Btn_createUser.Location = new System.Drawing.Point(350, 225);
            this.Btn_createUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_createUser.MinimumSize = new System.Drawing.Size(114, 32);
            this.Btn_createUser.Name = "Btn_createUser";
            this.Btn_createUser.Size = new System.Drawing.Size(144, 50);
            this.Btn_createUser.TabIndex = 4;
            this.Btn_createUser.Text = "Create User";
            this.Btn_createUser.UseVisualStyleBackColor = false;
            this.Btn_createUser.Click += new System.EventHandler(this.Btn_createUser_Click);
            // 
            // label_currentEvent
            // 
            this.label_currentEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.label_currentEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_currentEvent.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label_currentEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label_currentEvent.Location = new System.Drawing.Point(0, 0);
            this.label_currentEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_currentEvent.Name = "label_currentEvent";
            this.label_currentEvent.Size = new System.Drawing.Size(542, 41);
            this.label_currentEvent.TabIndex = 5;
            this.label_currentEvent.Text = "Create a User :";
            this.label_currentEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.Selection_roles);
            this.tabPage2.Controls.Add(this.Grid_usersList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(540, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List of Users.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label11.Location = new System.Drawing.Point(109, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = ":";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label12.Location = new System.Drawing.Point(4, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "Select role";
            // 
            // Selection_roles
            // 
            this.Selection_roles.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Selection_roles.FormattingEnabled = true;
            this.Selection_roles.Location = new System.Drawing.Point(128, 7);
            this.Selection_roles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Selection_roles.Name = "Selection_roles";
            this.Selection_roles.Size = new System.Drawing.Size(156, 26);
            this.Selection_roles.TabIndex = 21;
            this.Selection_roles.SelectedIndexChanged += new System.EventHandler(this.Selection_roles_SelectedIndexChanged);
            // 
            // Grid_usersList
            // 
            this.Grid_usersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_usersList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_usersList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.Grid_usersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_usersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.Grid_usersList.Location = new System.Drawing.Point(0, 37);
            this.Grid_usersList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grid_usersList.Name = "Grid_usersList";
            this.Grid_usersList.RowHeadersWidth = 62;
            this.Grid_usersList.RowTemplate.Height = 28;
            this.Grid_usersList.Size = new System.Drawing.Size(544, 300);
            this.Grid_usersList.TabIndex = 0;
            this.Grid_usersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_usersList_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.Grid_eventsList);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(540, 294);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "List of Classes.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "All Classes :";
            // 
            // Grid_eventsList
            // 
            this.Grid_eventsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_eventsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_eventsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.Grid_eventsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_eventsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.Grid_eventsList.Location = new System.Drawing.Point(0, 37);
            this.Grid_eventsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grid_eventsList.Name = "Grid_eventsList";
            this.Grid_eventsList.RowHeadersWidth = 62;
            this.Grid_eventsList.RowTemplate.Height = 28;
            this.Grid_eventsList.Size = new System.Drawing.Size(544, 335);
            this.Grid_eventsList.TabIndex = 1;
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
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::AMS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 469);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_currentTime);
            this.Controls.Add(this.label_currentDate);
            this.Controls.Add(this.Btn_logout);
            this.Controls.Add(this.label_hello);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Manager System (Admin)";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_usersList)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_eventsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_currentTime;
        private System.Windows.Forms.Label label_currentDate;
        private System.Windows.Forms.Button Btn_logout;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_createUser;
        private System.Windows.Forms.Label label_currentEvent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Grid_usersList;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grid_eventsList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxUserRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Selection_roles;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}