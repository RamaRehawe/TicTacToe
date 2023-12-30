using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        TicTacToeDbEntities dbEntities = new TicTacToeDbEntities();

        private void userNameSignUpTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passWordSignUpTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cPassWordSignUpTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void exiteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = userNameSignUpTextBox.Text.Trim();
            string password = passWordSignUpTextBox.Text;
            string cPassword = cPassWordSignUpTextBox.Text;
            

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(cPassword))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            if(password != cPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.");
                return;
            }
            if (dbEntities.Players.Any(u => u.PlayerName == username))
            {
                MessageBox.Show("Username already exists. Please choose a different one.");
                return;
            }

            Player newPlayer = new Player
            {
                PlayerName = username,
                Password = password,
                LastLogin = DateTime.Now
            };
            dbEntities.Players.Add(newPlayer);

            try
            {
                dbEntities.SaveChanges();
                MessageBox.Show("Registration successful!");
                this.Close();
            }catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during registration: {ex.Message}");
            }

        }
    }
}
