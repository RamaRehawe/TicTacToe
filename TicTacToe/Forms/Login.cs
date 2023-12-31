using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
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
        TicTacToeDbEntities dbEntities = new TicTacToeDbEntities();

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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameLoginTextBox.Text.Trim();
            string password = PassWordLoginTextBox.Text;

            var user = dbEntities.Players.FirstOrDefault(u=> u.PlayerName == username && u.Password == password);
            if (user != null)
            {
                try
                {
                    string formattedLastLogin = user.LastLogin.HasValue ? user.LastLogin.Value.ToString("yyyy-MM-dd") : "never";
                    MessageBox.Show($"Hello {user.PlayerName}. You have played {user.TotalGamesPlayed} games. You won: {user.Wins}, you lost: {user.Loses}, you tied: {user.Draws}. Last login for you was on {formattedLastLogin}.");
                    user.LastLogin = DateTime.Now;
                    dbEntities.SaveChanges();
                    this.Hide();
                    PlayingBoard playingBoard = new PlayingBoard(user.PlayerName);
                    playingBoard.FormClosed += (s, args) => this.Close();
                    playingBoard.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating last login date: {ex.Message}");
                }

            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

    }
}
