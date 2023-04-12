namespace BIBLIO
{
    partial class login
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
            Користкуувач = new Label();
            пароль = new Label();
            cbxUser = new ComboBox();
            txtPassword = new TextBox();
            btnOk = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // Користкуувач
            // 
            Користкуувач.AutoSize = true;
            Користкуувач.Location = new Point(63, 141);
            Користкуувач.Name = "Користкуувач";
            Користкуувач.Size = new Size(89, 20);
            Користкуувач.TabIndex = 0;
            Користкуувач.Text = "Користувач";
            Користкуувач.Click += label1_Click;
            // 
            // пароль
            // 
            пароль.AutoSize = true;
            пароль.Location = new Point(63, 227);
            пароль.Name = "пароль";
            пароль.Size = new Size(62, 20);
            пароль.TabIndex = 1;
            пароль.Text = "Пароль";
            пароль.Click += пароль_Click;
            // 
            // cbxUser
            // 
            cbxUser.FormattingEnabled = true;
            cbxUser.Location = new Point(263, 133);
            cbxUser.Name = "cbxUser";
            cbxUser.Size = new Size(151, 28);
            cbxUser.TabIndex = 3;
            cbxUser.SelectedIndexChanged += cbxUser_SelectedIndexChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(263, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(151, 27);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(169, 341);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ок";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(307, 341);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Cancel";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 450);
            Controls.Add(btnExit);
            Controls.Add(btnOk);
            Controls.Add(txtPassword);
            Controls.Add(cbxUser);
            Controls.Add(пароль);
            Controls.Add(Користкуувач);
            Name = "login";
            Text = "Авторизація";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Користкуувач;
        private Label пароль;
        private ComboBox cbxUser;
        private TextBox txtPassword;
        private Button btnOk;
        private Button btnExit;
    }
}