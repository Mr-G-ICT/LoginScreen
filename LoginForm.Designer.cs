namespace LoginScreen___Game
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SigninButton = new System.Windows.Forms.Button();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SignupGroup = new System.Windows.Forms.GroupBox();
            this.SignUpFinalButton = new System.Windows.Forms.Button();
            this.LoginGroup = new System.Windows.Forms.GroupBox();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.SignupGroup.SuspendLayout();
            this.LoginGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(183, 51);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(235, 51);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(435, 46);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(232, 60);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(435, 155);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(232, 60);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(197, 155);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(220, 51);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // SigninButton
            // 
            this.SigninButton.AllowDrop = true;
            this.SigninButton.AutoEllipsis = true;
            this.SigninButton.BackColor = System.Drawing.SystemColors.Control;
            this.SigninButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SigninButton.FlatAppearance.BorderSize = 3;
            this.SigninButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.SigninButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.SigninButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigninButton.Location = new System.Drawing.Point(45, 1057);
            this.SigninButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.SigninButton.Name = "SigninButton";
            this.SigninButton.Size = new System.Drawing.Size(330, 148);
            this.SigninButton.TabIndex = 4;
            this.SigninButton.Text = "Signin";
            this.SigninButton.UseVisualStyleBackColor = false;
            this.SigninButton.Click += new System.EventHandler(this.SigninButton_Click);
            // 
            // NewUserButton
            // 
            this.NewUserButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUserButton.Location = new System.Drawing.Point(489, 1057);
            this.NewUserButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(330, 148);
            this.NewUserButton.TabIndex = 5;
            this.NewUserButton.Text = "Sign up";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(838, 229);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(112, 39);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.Text = "label1";
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextbox.Location = new System.Drawing.Point(435, 174);
            this.FirstNameTextbox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(232, 60);
            this.FirstNameTextbox.TabIndex = 8;
            this.FirstNameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(183, 174);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(224, 51);
            this.FirstNameLabel.TabIndex = 7;
            this.FirstNameLabel.Text = "Firstname";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(19, 69);
            this.ConfirmPasswordLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(398, 51);
            this.ConfirmPasswordLabel.TabIndex = 9;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(435, 62);
            this.ConfirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(232, 60);
            this.ConfirmPasswordTextBox.TabIndex = 10;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(435, 298);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(232, 60);
            this.EmailTextBox.TabIndex = 11;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(185, 298);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(137, 51);
            this.EmailLabel.TabIndex = 12;
            this.EmailLabel.Text = "Email";
            // 
            // SignupGroup
            // 
            this.SignupGroup.Controls.Add(this.SignUpFinalButton);
            this.SignupGroup.Controls.Add(this.EmailLabel);
            this.SignupGroup.Controls.Add(this.EmailTextBox);
            this.SignupGroup.Controls.Add(this.ConfirmPasswordTextBox);
            this.SignupGroup.Controls.Add(this.ConfirmPasswordLabel);
            this.SignupGroup.Controls.Add(this.FirstNameTextbox);
            this.SignupGroup.Controls.Add(this.FirstNameLabel);
            this.SignupGroup.Location = new System.Drawing.Point(45, 395);
            this.SignupGroup.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.SignupGroup.Name = "SignupGroup";
            this.SignupGroup.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.SignupGroup.Size = new System.Drawing.Size(774, 553);
            this.SignupGroup.TabIndex = 13;
            this.SignupGroup.TabStop = false;
            // 
            // SignUpFinalButton
            // 
            this.SignUpFinalButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFinalButton.Location = new System.Drawing.Point(221, 442);
            this.SignUpFinalButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.SignUpFinalButton.Name = "SignUpFinalButton";
            this.SignUpFinalButton.Size = new System.Drawing.Size(264, 67);
            this.SignUpFinalButton.TabIndex = 13;
            this.SignUpFinalButton.Text = "Sign Me Up!";
            this.SignUpFinalButton.UseVisualStyleBackColor = true;
            this.SignUpFinalButton.Click += new System.EventHandler(this.SignUpFinalButton_Click);
            // 
            // LoginGroup
            // 
            this.LoginGroup.Controls.Add(this.UsernameTextBox);
            this.LoginGroup.Controls.Add(this.UsernameLabel);
            this.LoginGroup.Controls.Add(this.PasswordLabel);
            this.LoginGroup.Controls.Add(this.PasswordTextBox);
            this.LoginGroup.Location = new System.Drawing.Point(45, 183);
            this.LoginGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginGroup.Name = "LoginGroup";
            this.LoginGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginGroup.Size = new System.Drawing.Size(774, 224);
            this.LoginGroup.TabIndex = 14;
            this.LoginGroup.TabStop = false;
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Location = new System.Drawing.Point(62, 60);
            this.ProjectNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(195, 37);
            this.ProjectNameLabel.TabIndex = 15;
            this.ProjectNameLabel.Text = "Welcome to ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1995, 1455);
            this.Controls.Add(this.ProjectNameLabel);
            this.Controls.Add(this.LoginGroup);
            this.Controls.Add(this.SignupGroup);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.NewUserButton);
            this.Controls.Add(this.SigninButton);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "LoginForm";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.SignupGroup.ResumeLayout(false);
            this.SignupGroup.PerformLayout();
            this.LoginGroup.ResumeLayout(false);
            this.LoginGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button SigninButton;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.GroupBox SignupGroup;
        private System.Windows.Forms.Button SignUpFinalButton;
        private System.Windows.Forms.GroupBox LoginGroup;
        private System.Windows.Forms.Label ProjectNameLabel;
    }
}

