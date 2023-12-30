namespace TicTacToe
{
    partial class Login
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
            this.UserNameLoginTextBox = new System.Windows.Forms.TextBox();
            this.PassWordLoginTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passWordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SignUpClickLink = new System.Windows.Forms.LinkLabel();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameLoginTextBox
            // 
            this.UserNameLoginTextBox.Location = new System.Drawing.Point(179, 42);
            this.UserNameLoginTextBox.Name = "UserNameLoginTextBox";
            this.UserNameLoginTextBox.Size = new System.Drawing.Size(313, 24);
            this.UserNameLoginTextBox.TabIndex = 0;
            // 
            // PassWordLoginTextBox
            // 
            this.PassWordLoginTextBox.Location = new System.Drawing.Point(179, 95);
            this.PassWordLoginTextBox.Name = "PassWordLoginTextBox";
            this.PassWordLoginTextBox.Size = new System.Drawing.Size(313, 24);
            this.PassWordLoginTextBox.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(92, 41);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(85, 21);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Username";
            // 
            // passWordLabel
            // 
            this.passWordLabel.AutoSize = true;
            this.passWordLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordLabel.Location = new System.Drawing.Point(92, 94);
            this.passWordLabel.Name = "passWordLabel";
            this.passWordLabel.Size = new System.Drawing.Size(81, 21);
            this.passWordLabel.TabIndex = 3;
            this.passWordLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginButton.Location = new System.Drawing.Point(96, 138);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(396, 44);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // SignUpClickLink
            // 
            this.SignUpClickLink.AutoSize = true;
            this.SignUpClickLink.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpClickLink.Location = new System.Drawing.Point(331, 240);
            this.SignUpClickLink.Name = "SignUpClickLink";
            this.SignUpClickLink.Size = new System.Drawing.Size(72, 21);
            this.SignUpClickLink.TabIndex = 5;
            this.SignUpClickLink.TabStop = true;
            this.SignUpClickLink.Text = "SIGN UP";
            this.SignUpClickLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpClickLink_LinkClicked);
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.Location = new System.Drawing.Point(199, 243);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(126, 18);
            this.signUpLabel.TabIndex = 6;
            this.signUpLabel.Text = "Need an account?";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(96, 188);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(396, 40);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 294);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.SignUpClickLink);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passWordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.PassWordLoginTextBox);
            this.Controls.Add(this.UserNameLoginTextBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameLoginTextBox;
        private System.Windows.Forms.TextBox PassWordLoginTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passWordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel SignUpClickLink;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Button exitButton;
    }
}