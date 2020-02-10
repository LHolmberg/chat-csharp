namespace Chat
{
    partial class MainMenu
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateAccUsername = new System.Windows.Forms.TextBox();
            this.CreateAccPassword = new System.Windows.Forms.TextBox();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateAccPort = new System.Windows.Forms.TextBox();
            this.CreateAccIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(326, 276);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(141, 36);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.AccessibleDescription = "";
            this.UsernameTxt.Location = new System.Drawing.Point(326, 197);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(141, 22);
            this.UsernameTxt.TabIndex = 1;
            this.UsernameTxt.Text = "Username";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(326, 225);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(141, 22);
            this.PasswordTxt.TabIndex = 2;
            this.PasswordTxt.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dont have an account? Create one here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreateAccUsername
            // 
            this.CreateAccUsername.AccessibleDescription = "";
            this.CreateAccUsername.Location = new System.Drawing.Point(326, 141);
            this.CreateAccUsername.Name = "CreateAccUsername";
            this.CreateAccUsername.Size = new System.Drawing.Size(141, 22);
            this.CreateAccUsername.TabIndex = 4;
            this.CreateAccUsername.Text = "Username";
            this.CreateAccUsername.Visible = false;
            this.CreateAccUsername.TextChanged += new System.EventHandler(this.CreateAccUsername_TextChanged);
            // 
            // CreateAccPassword
            // 
            this.CreateAccPassword.Location = new System.Drawing.Point(326, 169);
            this.CreateAccPassword.Name = "CreateAccPassword";
            this.CreateAccPassword.Size = new System.Drawing.Size(141, 22);
            this.CreateAccPassword.TabIndex = 5;
            this.CreateAccPassword.Text = "Password";
            this.CreateAccPassword.Visible = false;
            // 
            // CreateAccount
            // 
            this.CreateAccount.Location = new System.Drawing.Point(326, 276);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(141, 36);
            this.CreateAccount.TabIndex = 6;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Visible = false;
            this.CreateAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(40, 33);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(101, 42);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "There is no created account with that information, please create a new one";
            this.label2.Visible = false;
            // 
            // CreateAccPort
            // 
            this.CreateAccPort.AccessibleDescription = "";
            this.CreateAccPort.Location = new System.Drawing.Point(326, 225);
            this.CreateAccPort.Name = "CreateAccPort";
            this.CreateAccPort.Size = new System.Drawing.Size(141, 22);
            this.CreateAccPort.TabIndex = 9;
            this.CreateAccPort.Text = "Port";
            this.CreateAccPort.Visible = false;
            // 
            // CreateAccIP
            // 
            this.CreateAccIP.AccessibleDescription = "";
            this.CreateAccIP.Location = new System.Drawing.Point(326, 197);
            this.CreateAccIP.Name = "CreateAccIP";
            this.CreateAccIP.Size = new System.Drawing.Size(141, 22);
            this.CreateAccIP.TabIndex = 10;
            this.CreateAccIP.Text = "IP-Address";
            this.CreateAccIP.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateAccIP);
            this.Controls.Add(this.CreateAccPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.CreateAccPassword);
            this.Controls.Add(this.CreateAccUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.LoginBtn);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreateAccUsername;
        private System.Windows.Forms.TextBox CreateAccPassword;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CreateAccPort;
        private System.Windows.Forms.TextBox CreateAccIP;
    }
}