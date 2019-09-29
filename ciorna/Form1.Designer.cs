namespace ciorna
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.backToLogin = new System.Windows.Forms.Label();
            this.NameReg = new System.Windows.Forms.TextBox();
            this.Pass2Reg = new System.Windows.Forms.TextBox();
            this.Pass1Reg = new System.Windows.Forms.TextBox();
            this.EmailReg = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.exitRegister = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackgroundImage = global::ciorna.Properties.Resources.login;
            this.panelLogin.Controls.Add(this.panelRegister);
            this.panelLogin.Controls.Add(this.register);
            this.panelLogin.Controls.Add(this.Exit);
            this.panelLogin.Controls.Add(this.Login);
            this.panelLogin.Controls.Add(this.passwordBox);
            this.panelLogin.Controls.Add(this.emailBox);
            this.panelLogin.Location = new System.Drawing.Point(-1, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1090, 583);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panelLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panelLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panelRegister
            // 
            this.panelRegister.BackgroundImage = global::ciorna.Properties.Resources.register;
            this.panelRegister.Controls.Add(this.backToLogin);
            this.panelRegister.Controls.Add(this.NameReg);
            this.panelRegister.Controls.Add(this.Pass2Reg);
            this.panelRegister.Controls.Add(this.Pass1Reg);
            this.panelRegister.Controls.Add(this.EmailReg);
            this.panelRegister.Controls.Add(this.registerButton);
            this.panelRegister.Controls.Add(this.exitRegister);
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(1086, 600);
            this.panelRegister.TabIndex = 5;
            this.panelRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRegister_MouseDown);
            this.panelRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRegister_MouseMove);
            this.panelRegister.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelRegister_MouseUp);
            // 
            // backToLogin
            // 
            this.backToLogin.AutoSize = true;
            this.backToLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLogin.ForeColor = System.Drawing.Color.SaddleBrown;
            this.backToLogin.Location = new System.Drawing.Point(515, 482);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(47, 19);
            this.backToLogin.TabIndex = 6;
            this.backToLogin.Text = "Înapoi";
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // NameReg
            // 
            this.NameReg.Location = new System.Drawing.Point(446, 375);
            this.NameReg.MaxLength = 30;
            this.NameReg.Name = "NameReg";
            this.NameReg.Size = new System.Drawing.Size(227, 20);
            this.NameReg.TabIndex = 5;
            // 
            // Pass2Reg
            // 
            this.Pass2Reg.Location = new System.Drawing.Point(446, 284);
            this.Pass2Reg.MaxLength = 50;
            this.Pass2Reg.Name = "Pass2Reg";
            this.Pass2Reg.PasswordChar = '*';
            this.Pass2Reg.Size = new System.Drawing.Size(227, 20);
            this.Pass2Reg.TabIndex = 4;
            // 
            // Pass1Reg
            // 
            this.Pass1Reg.Location = new System.Drawing.Point(446, 246);
            this.Pass1Reg.MaxLength = 50;
            this.Pass1Reg.Name = "Pass1Reg";
            this.Pass1Reg.PasswordChar = '*';
            this.Pass1Reg.Size = new System.Drawing.Size(227, 20);
            this.Pass1Reg.TabIndex = 3;
            // 
            // EmailReg
            // 
            this.EmailReg.Location = new System.Drawing.Point(446, 189);
            this.EmailReg.MaxLength = 50;
            this.EmailReg.Name = "EmailReg";
            this.EmailReg.Size = new System.Drawing.Size(227, 20);
            this.EmailReg.TabIndex = 2;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Location = new System.Drawing.Point(437, 433);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(218, 34);
            this.registerButton.TabIndex = 1;
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitRegister
            // 
            this.exitRegister.BackColor = System.Drawing.Color.Transparent;
            this.exitRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitRegister.Location = new System.Drawing.Point(1032, 19);
            this.exitRegister.Name = "exitRegister";
            this.exitRegister.Size = new System.Drawing.Size(35, 37);
            this.exitRegister.TabIndex = 0;
            this.exitRegister.UseVisualStyleBackColor = false;
            this.exitRegister.Click += new System.EventHandler(this.exitRegister_Click);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.SaddleBrown;
            this.register.Location = new System.Drawing.Point(502, 448);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(77, 19);
            this.register.TabIndex = 4;
            this.register.Text = "Înregistrare";
            this.register.MouseClick += new System.Windows.Forms.MouseEventHandler(this.register_MouseClick);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Location = new System.Drawing.Point(1032, 19);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 37);
            this.Exit.TabIndex = 3;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Location = new System.Drawing.Point(437, 378);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(211, 38);
            this.Login.TabIndex = 2;
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(449, 304);
            this.passwordBox.MaxLength = 50;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(227, 20);
            this.passwordBox.TabIndex = 1;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(449, 249);
            this.emailBox.MaxLength = 50;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(227, 20);
            this.emailBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 579);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Ciorna";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button exitRegister;
        private System.Windows.Forms.TextBox NameReg;
        private System.Windows.Forms.TextBox Pass2Reg;
        private System.Windows.Forms.TextBox Pass1Reg;
        private System.Windows.Forms.TextBox EmailReg;
        private System.Windows.Forms.Label backToLogin;
    }
}

