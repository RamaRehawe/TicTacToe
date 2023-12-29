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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        //TicTacToeDbEntities db = new TicTacToeDbEntities();
        
        private void userNameSignUpTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passWordSignUpTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cPassWordSignUpTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
