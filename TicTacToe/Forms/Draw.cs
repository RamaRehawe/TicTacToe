using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.Forms
{
    public partial class Draw : Form
    {
        private string username;
        public Draw(string userName)
        {
            InitializeComponent();
            username = userName;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayingBoard playingBoard = new PlayingBoard(username);
            playingBoard.FormClosed += (s, args) => this.Close();
            playingBoard.Show();

        }
    }
}
