namespace TicTacToe
{
    partial class SignUp
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
            this.registerButton = new System.Windows.Forms.Button();
            this.userNameSignUpTextBox = new System.Windows.Forms.TextBox();
            this.passWordSignUpTextBox = new System.Windows.Forms.TextBox();
            this.cPassWordSignUpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exiteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(51, 257);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(426, 42);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // userNameSignUpTextBox
            // 
            this.userNameSignUpTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.userNameSignUpTextBox.Location = new System.Drawing.Point(185, 57);
            this.userNameSignUpTextBox.Name = "userNameSignUpTextBox";
            this.userNameSignUpTextBox.Size = new System.Drawing.Size(292, 24);
            this.userNameSignUpTextBox.TabIndex = 1;
            this.userNameSignUpTextBox.TextChanged += new System.EventHandler(this.userNameSignUpTextBox_TextChanged);
            // 
            // passWordSignUpTextBox
            // 
            this.passWordSignUpTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.passWordSignUpTextBox.Location = new System.Drawing.Point(185, 123);
            this.passWordSignUpTextBox.Name = "passWordSignUpTextBox";
            this.passWordSignUpTextBox.PasswordChar = '*';
            this.passWordSignUpTextBox.Size = new System.Drawing.Size(292, 24);
            this.passWordSignUpTextBox.TabIndex = 1;
            this.passWordSignUpTextBox.TextChanged += new System.EventHandler(this.passWordSignUpTextBox_TextChanged);
            // 
            // cPassWordSignUpTextBox
            // 
            this.cPassWordSignUpTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cPassWordSignUpTextBox.Location = new System.Drawing.Point(185, 192);
            this.cPassWordSignUpTextBox.Name = "cPassWordSignUpTextBox";
            this.cPassWordSignUpTextBox.PasswordChar = '*';
            this.cPassWordSignUpTextBox.Size = new System.Drawing.Size(292, 24);
            this.cPassWordSignUpTextBox.TabIndex = 1;
            this.cPassWordSignUpTextBox.TextChanged += new System.EventHandler(this.cPassWordSignUpTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password";
            // 
            // exiteButton
            // 
            this.exiteButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exiteButton.Location = new System.Drawing.Point(51, 314);
            this.exiteButton.Name = "exiteButton";
            this.exiteButton.Size = new System.Drawing.Size(426, 42);
            this.exiteButton.TabIndex = 5;
            this.exiteButton.Text = "Exit";
            this.exiteButton.UseVisualStyleBackColor = true;
            this.exiteButton.Click += new System.EventHandler(this.exiteButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 389);
            this.ControlBox = false;
            this.Controls.Add(this.exiteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cPassWordSignUpTextBox);
            this.Controls.Add(this.passWordSignUpTextBox);
            this.Controls.Add(this.userNameSignUpTextBox);
            this.Controls.Add(this.registerButton);
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox userNameSignUpTextBox;
        private System.Windows.Forms.TextBox passWordSignUpTextBox;
        private System.Windows.Forms.TextBox cPassWordSignUpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exiteButton;
    }
}

