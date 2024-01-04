namespace AMS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label_login = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.input_email = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.Btn_login = new System.Windows.Forms.Button();
            this.Check_showPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_login.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.label_login.Location = new System.Drawing.Point(364, 255);
            this.label_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(169, 33);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Let\'s Login!";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label_email.Location = new System.Drawing.Point(53, 54);
            this.label_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(54, 19);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.label_password.Location = new System.Drawing.Point(53, 128);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(82, 19);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password:";
            // 
            // input_email
            // 
            this.input_email.Font = new System.Drawing.Font("Tahoma", 11F);
            this.input_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.input_email.Location = new System.Drawing.Point(56, 80);
            this.input_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(176, 25);
            this.input_email.TabIndex = 1;
            // 
            // input_password
            // 
            this.input_password.Font = new System.Drawing.Font("Tahoma", 11F);
            this.input_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.input_password.Location = new System.Drawing.Point(56, 154);
            this.input_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(176, 25);
            this.input_password.TabIndex = 2;
            this.input_password.TextChanged += new System.EventHandler(this.input_password_TextChanged);
            // 
            // Btn_login
            // 
            this.Btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_login.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.Btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.Btn_login.Location = new System.Drawing.Point(56, 232);
            this.Btn_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(174, 45);
            this.Btn_login.TabIndex = 4;
            this.Btn_login.Text = "Login";
            this.Btn_login.UseVisualStyleBackColor = false;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Check_showPass
            // 
            this.Check_showPass.AutoSize = true;
            this.Check_showPass.BackColor = System.Drawing.Color.Transparent;
            this.Check_showPass.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Check_showPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.Check_showPass.Location = new System.Drawing.Point(56, 184);
            this.Check_showPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Check_showPass.Name = "Check_showPass";
            this.Check_showPass.Size = new System.Drawing.Size(112, 18);
            this.Check_showPass.TabIndex = 3;
            this.Check_showPass.Text = "Show Password";
            this.Check_showPass.UseVisualStyleBackColor = false;
            this.Check_showPass.CheckedChanged += new System.EventHandler(this.Check_showPass_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(371, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "WELCOME!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.pictureBox2.Location = new System.Drawing.Point(298, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(5, 316);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AMS.Properties.Resources.Icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(322, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 218);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.BackgroundImage = global::AMS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 340);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Check_showPass);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_login);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Manager System";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.CheckBox Check_showPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

