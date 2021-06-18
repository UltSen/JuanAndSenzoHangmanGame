using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace JuanAndSenzoHangmanGame
{
    public partial class Question12 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question12()
        {
            InitializeComponent();
            correctSound = new SoundPlayer(@"Sounds\Crowd_Exicted_Sound_Effect.wav");
            wrongSound = new SoundPlayer(@"Sounds\Wrong_Buzzer_-_Sound_Effect.wav");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtbxAns12.Text == "h")
            {
                lblLetter1.Text = "h";   
                txtbxAns12.Text = "";
                correct++;
            }
            if (txtbxAns12.Text == "i")
            {
                lblLetter2.Text = "i";
                txtbxAns12.Text = "";
                correct++;
            }
            if (txtbxAns12.Text == "t")
            {
                lblLetter3.Text = "t";
                txtbxAns12.Text = "";
                correct++;
            }
            if (txtbxAns12.Text == "o")
            {
                lblLetter4.Text = "o";
                txtbxAns12.Text = "";
                correct++;
            }
            else
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (correct == 4)
            {
                correctSound.Play();
                MessageBox.Show("You are correct, the word is hito");
                this.Hide();
                MessageBox.Show("Congradulations you beat the game!");
                correctSound.Stop();
                MessageBox.Show("We hope you play again to better your Japanese vocabulary!");
                Application.Exit();
            }
            if (wrong == 8)
            {
                wrongSound.Play();
                MessageBox.Show("Sorry you have been hung");
                wrongSound.Stop();
                lblLetter1.Text = "";
                lblLetter2.Text = "";
                lblLetter3.Text = "";
                lblLetter4.Text = "";
                lblLetter5.Text = "";
                lblLetter6.Text = "";
                lblLetter7.Text = "";
                wrong = 0;
            }

        }

        private void Question12_Load(object sender, EventArgs e)
        {
            lblHeading.Text = "What is the Japanese word for person?";
            lblLetter5.Hide();
            lblLetter6.Hide();
            lblLetter7.Hide();
        }
    }
}
