namespace SistemaLoginB
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            grpLogin = new GroupBox();
            lblAlert = new Label();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            lblPassword = new Label();
            lblUser = new Label();
            panel1.SuspendLayout();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(grpLogin);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(lblAlert);
            grpLogin.Controls.Add(txtPassword);
            grpLogin.Controls.Add(txtUser);
            grpLogin.Controls.Add(lblPassword);
            grpLogin.Controls.Add(lblUser);
            grpLogin.Location = new Point(3, 3);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(770, 420);
            grpLogin.TabIndex = 0;
            grpLogin.TabStop = false;
            grpLogin.Text = "Login";
            // 
            // lblAlert
            // 
            lblAlert.AutoSize = true;
            lblAlert.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAlert.ForeColor = Color.IndianRed;
            lblAlert.Location = new Point(6, 131);
            lblAlert.Name = "lblAlert";
            lblAlert.Size = new Size(142, 21);
            lblAlert.TabIndex = 4;
            lblAlert.Text = "Invalid Credential";
            lblAlert.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(6, 99);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(758, 29);
            txtPassword.TabIndex = 3;
            txtPassword.KeyUp += txtPassword_KeyUp;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(6, 43);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(758, 29);
            txtUser.TabIndex = 2;
            txtUser.Click += txtUser_Click;
            txtUser.KeyUp += txtUser_KeyUp;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(6, 75);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(6, 19);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(49, 21);
            lblUser.TabIndex = 0;
            lblUser.Text = "User:";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginScreen";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Login Screen";
            Load += LoginScreen_Load;
            panel1.ResumeLayout(false);
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox grpLogin;
        private Label lblUser;
        private Label lblAlert;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Label lblPassword;
    }
}
