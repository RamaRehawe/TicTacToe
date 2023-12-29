using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // Subscribe to the LinkLabel's LinkClicked event

            
        }

        private void SignUpClickLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp formSignUp = new SignUp();
            formSignUp.FormClosed += (s, args) => this.Close(); // Close the main form when FormSignUp is closed
            formSignUp.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
