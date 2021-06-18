using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuanAndSenzoHangmanGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();          
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            var question1 = new Question1();
            question1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Type a letter in the box indicated.");
            MessageBox.Show("Press submit to make your guess.");
            MessageBox.Show("You will proceed to the next word if you get the whole word.");
            MessageBox.Show("If you however make 8 incorrect guesses you lose!");
            MessageBox.Show("Simple right? Now go learn something and guess away!");
        }
    }
}
