namespace StudentRating
{
    partial class FormAuthorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.pictureBoxEyeSlash = new System.Windows.Forms.PictureBox();
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.labelWithoutAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeSlash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(54, 115);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(69, 24);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Логин:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(136, 112);
            this.textBoxLogin.MaxLength = 50;
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(320, 35);
            this.textBoxLogin.TabIndex = 5;
            this.textBoxLogin.WordWrap = false;
            this.textBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLogin_KeyDown);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(42, 187);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(81, 24);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(136, 184);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(320, 35);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.WordWrap = false;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignIn.Location = new System.Drawing.Point(195, 250);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(163, 39);
            this.buttonSignIn.TabIndex = 10;
            this.buttonSignIn.Text = "Войти";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorization.Location = new System.Drawing.Point(192, 40);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(178, 31);
            this.labelAuthorization.TabIndex = 11;
            this.labelAuthorization.Text = "Авторизация";
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelForgotPassword.Location = new System.Drawing.Point(219, 321);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(114, 16);
            this.labelForgotPassword.TabIndex = 12;
            this.labelForgotPassword.Text = "Забыли пароль?";
            this.labelForgotPassword.Click += new System.EventHandler(this.labelForgotPassword_Click);
            // 
            // pictureBoxEyeSlash
            // 
            this.pictureBoxEyeSlash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEyeSlash.Image = global::StudentRating.Properties.Resources.eye_slash_icon;
            this.pictureBoxEyeSlash.Location = new System.Drawing.Point(479, 188);
            this.pictureBoxEyeSlash.Name = "pictureBoxEyeSlash";
            this.pictureBoxEyeSlash.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxEyeSlash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEyeSlash.TabIndex = 14;
            this.pictureBoxEyeSlash.TabStop = false;
            this.pictureBoxEyeSlash.Click += new System.EventHandler(this.pictureBoxEyeSlash_Click);
            // 
            // pictureBoxEye
            // 
            this.pictureBoxEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEye.Image = global::StudentRating.Properties.Resources.eye_icon;
            this.pictureBoxEye.Location = new System.Drawing.Point(479, 189);
            this.pictureBoxEye.Name = "pictureBoxEye";
            this.pictureBoxEye.Size = new System.Drawing.Size(27, 26);
            this.pictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEye.TabIndex = 15;
            this.pictureBoxEye.TabStop = false;
            this.pictureBoxEye.Click += new System.EventHandler(this.pictureBoxEye_Click);
            // 
            // labelWithoutAccount
            // 
            this.labelWithoutAccount.AutoSize = true;
            this.labelWithoutAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelWithoutAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWithoutAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelWithoutAccount.Location = new System.Drawing.Point(210, 357);
            this.labelWithoutAccount.Name = "labelWithoutAccount";
            this.labelWithoutAccount.Size = new System.Drawing.Size(132, 16);
            this.labelWithoutAccount.TabIndex = 16;
            this.labelWithoutAccount.Text = "Ещё нет аккаунта?";
            this.labelWithoutAccount.Click += new System.EventHandler(this.labelWithoutAccount_Click);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.labelWithoutAccount);
            this.Controls.Add(this.pictureBoxEye);
            this.Controls.Add(this.pictureBoxEyeSlash);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.labelAuthorization);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAuthorization";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuthorization_FormClosed);
            this.Load += new System.EventHandler(this.FormAuthorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeSlash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.PictureBox pictureBoxEyeSlash;
        private System.Windows.Forms.PictureBox pictureBoxEye;
        private System.Windows.Forms.Label labelWithoutAccount;
    }
}

