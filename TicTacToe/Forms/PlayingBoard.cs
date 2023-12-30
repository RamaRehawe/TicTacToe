using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class PlayingBoard : Form
    {
        private int childFormNumber = 0;
        bool turn = true; // true = X turn , false = O turn
        int turnCount = 0;
        public PlayingBoard()
        {
            InitializeComponent();
        }

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
                b.Text = "X";
            else b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;

            CheckForWinner();
        }
        private void CheckForWinner()
        {
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
                    winner = "O";
                else winner = "X";

                MessageBox.Show(winner + " Wins!", "Yay");
            }
            else
            {
                if(turnCount == 9)
                {
                    MessageBox.Show("Draw!", "Bummer!");
                }
            }

        }// end CheckForWinner

        private void DisabelButtons()
        {
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }catch
            { }
        }

        private void newGaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
            try
            {
                foreach(Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }catch
            { }
        }
    }
}
