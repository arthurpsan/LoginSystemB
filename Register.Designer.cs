namespace SistemaLoginB
{
    partial class RegisterUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            pnlRegister = new Panel();
            groupBox1 = new GroupBox();
            chkAdmin = new CheckBox();
            btnSave = new Button();
            txtRepeatPassword = new TextBox();
            txtPassword = new TextBox();
            txtName = new TextBox();
            txtUser = new TextBox();
            lblPasswordRepeat = new Label();
            lblPassword = new Label();
            lblUser = new Label();
            lblName = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRegister
            // 
            pnlRegister.Location = new Point(12, 12);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(776, 187);
            pnlRegister.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAdmin);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtRepeatPassword);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(lblPasswordRepeat);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(lblUser);
            groupBox1.Controls.Add(lblName);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 184);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register";
            // 
            // chkAdmin
            // 
            chkAdmin.AutoSize = true;
            chkAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkAdmin.Location = new Point(149, 151);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(80, 25);
            chkAdmin.TabIndex = 9;
            chkAdmin.Text = "Admin";
            chkAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(235, 148);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(529, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Font = new Font("Segoe UI", 12F);
            txtRepeatPassword.Location = new Point(149, 116);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.Size = new Size(615, 29);
            txtRepeatPassword.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(149, 81);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(615, 29);
            txtPassword.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(149, 11);
            txtName.Name = "txtName";
            txtName.Size = new Size(615, 29);
            txtName.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F);
            txtUser.Location = new Point(149, 46);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(615, 29);
            txtUser.TabIndex = 4;
            // 
            // lblPasswordRepeat
            // 
            lblPasswordRepeat.AutoSize = true;
            lblPasswordRepeat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPasswordRepeat.Location = new Point(0, 119);
            lblPasswordRepeat.Name = "lblPasswordRepeat";
            lblPasswordRepeat.RightToLeft = RightToLeft.No;
            lblPasswordRepeat.Size = new Size(143, 21);
            lblPasswordRepeat.TabIndex = 3;
            lblPasswordRepeat.Text = "Repeat Password:";
            lblPasswordRepeat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPassword.Location = new Point(57, 84);
            lblPassword.Name = "lblPassword";
            lblPassword.RightToLeft = RightToLeft.No;
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUser.Location = new Point(94, 54);
            lblUser.Name = "lblUser";
            lblUser.RightToLeft = RightToLeft.No;
            lblUser.Size = new Size(49, 21);
            lblUser.TabIndex = 1;
            lblUser.Text = "User:";
            lblUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblName.Location = new Point(83, 19);
            lblName.Name = "lblName";
            lblName.RightToLeft = RightToLeft.No;
            lblName.Size = new Size(60, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 211);
            Controls.Add(groupBox1);
            Controls.Add(pnlRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegisterScreen";
            ShowIcon = false;
            Text = "Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRegister;
        private GroupBox groupBox1;
        private TextBox txtName;
        private TextBox txtUser;
        private Label lblPasswordRepeat;
        private Label lblPassword;
        private Label lblUser;
        private Label lblName;
        private TextBox txtRepeatPassword;
        private TextBox txtPassword;
        private CheckBox chkAdmin;
        private Button btnSave;
    }
}