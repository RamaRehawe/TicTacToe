using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TicTacToe
{
    public partial class PlayingBoard : Form
    {
        private string currentPlayerName;
        private int childFormNumber = 0;
        bool turn = true; // true = X turn , false = O turn
        int turnCount = 0;
        public PlayingBoard(string playerName)
        {
            InitializeComponent();
            currentPlayerName = playerName;
        }
        TicTacToeDbEntities dbEntities = new TicTacToeDbEntities();

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Rama", "Tic Tac Toe About");
        }

        private void exiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                player2Label.ForeColor = Color.Red;
                player2Label.Font = new Font(player2Label.Font, FontStyle.Bold);

                player1Lable.ForeColor = Color.Black;
                player1Lable.Font = new Font(player1Lable.Font, FontStyle.Regular);
            }
            else
            {
                b.Text = "O";
                player1Lable.ForeColor = Color.Red;
                player1Lable.Font = new Font(player1Lable.Font, FontStyle.Bold);

                player2Label.ForeColor = Color.Black;
                player2Label.Font = new Font(player2Label.Font, FontStyle.Regular);
            }
            turn = !turn;
            b.Enabled = false;
            turnCount++;

            CheckForWinner();
        }
        private void CheckForWinner()
        {
            var player = dbEntities.Players.FirstOrDefault(u=> u.PlayerName == currentPlayerName);
            bool IsThereAWinner = false;

            // horizantel winner
            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled)
                IsThereAWinner = true;
            else if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled)
                IsThereAWinner = true;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled)
                IsThereAWinner = true;

            // vertical winner
            else if (A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled)
                IsThereAWinner = true;
            else if (A2.Text == B2.Text && B2.Text == C2.Text && !A2.Enabled)
                IsThereAWinner = true;
            else if (A3.Text == B3.Text && B3.Text == C3.Text && !A3.Enabled)
                IsThereAWinner = true;

            // Diagonal Winner
            else if (A1.Text == B2.Text && B2.Text == C3.Text && !A1.Enabled)
                IsThereAWinner = true;
            else if (A3.Text == B2.Text && B2.Text == C1.Text && !A3.Enabled)
                IsThereAWinner = true;

            if (IsThereAWinner)
            {
                DisabelButtons();
                string winner = "";
                if (turn)
                {
                    winner = "Player 2";
                    player.Loses++;
                }
                else
                {
                    winner = "Player 1";
                    player.Wins++;
                }
                if(winner == "Player 1")
                    MessageBox.Show("Congratulations " + currentPlayerName + " You Win", "Yay");
                else
                    MessageBox.Show("Game Over " + currentPlayerName + " You Lost", "Bummer");
                player.TotalGamesPlayed++;
                try
                {
                    dbEntities.SaveChanges();
                }catch
                { }
            }
            else
            {
                if(turnCount == 9)
                {
                    
                    player.Draws++;
                    player.TotalGamesPlayed++;
                    try
                    {
                        dbEntities.SaveChanges();
                    }
                    catch
                    { }
                    this.Hide();
                    Draw draw = new Draw(currentPlayerName);
                    draw.FormClosed += (s, args) => this.Close();
                    draw.Show();
                }
            }

        }// end CheckForWinner

        private void DisabelButtons()
        {
            try
            {

                foreach (Control c in Controls)
                {
                    if(c is Button b)
                        b.Enabled = false;
                }
            }catch
            { }
        }

        private void newGaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayingBoard_Load(sender, e);
            turn = true;
            turnCount = 0;
            try
            {
                foreach(Control c in Controls)
                {
                    if(c is Button b)
                    {
                        b.Enabled = true;
                        b.Text = "";

                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine($"Exception in newGaToolStripMenuItem_Click: {ex.Message}");
            }
        }

        private void PlayingBoard_Load(object sender, EventArgs e)
        {
            player1Lable.ForeColor = Color.Red;
            player1Lable.Font = new Font(player1Lable.Font, FontStyle.Bold);

            player2Label.ForeColor = Color.Black;
            player2Label.Font = new Font(player2Label.Font, FontStyle.Regular);
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();
            var topPlayers = dbEntities.Players
                .OrderByDescending(p=> p.Wins)
                .Take(10)
                .Select(p=> new
                {
                    PlayerName = p.PlayerName,
                    Wins = p.Wins,
                    Loses = p.Loses,
                    Draws = p.Draws,
                    LastLogin = p.LastLogin
                }).ToList();
            DataTable leaderboardData = new DataTable();
            leaderboardData.Columns.Add("PlayerName");
            leaderboardData.Columns.Add("Wins");
            leaderboardData.Columns.Add("Loses");
            leaderboardData.Columns.Add("Ties");
            leaderboardData.Columns.Add("LastLogin", typeof(DateTime));

            foreach(var player in topPlayers)
            {
                leaderboardData.Rows.Add(player.PlayerName, player.Wins, 
                    player.Loses, player.Draws, 
                    player.LastLogin.HasValue ? player.LastLogin.Value.ToShortDateString() : "");
            }
            leaderboard.PopulateLeaderboard(leaderboardData);
            leaderboard.ShowDialog();
        }
    }
}
