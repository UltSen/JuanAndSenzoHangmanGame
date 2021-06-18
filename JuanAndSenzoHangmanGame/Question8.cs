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
    public partial class Question8 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question8()
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
            if (txtbxAns8.Text == "n")
            {
                lblLetter1.Text = "n";
                txtbxAns8.Text = "";
                correct++;
            }
            if (txtbxAns8.Text == "a")
            {
                lblLetter2.Text = "a";                
                txtbxAns8.Text = "";
                correct++;
            }
            if (txtbxAns8.Text == "t")
            {
                lblLetter3.Text = "t";
                txtbxAns8.Text = "";
                correct++;
            }

            if (txtbxAns8.Text == "s")
            {
                lblLetter4.Text = "s";
                txtbxAns8.Text = "";
                correct++;
            }
            if (txtbxAns8.Text == "u")
            {
                lblLetter5.Text = "u";
                txtbxAns8.Text = "";
                correct++;
            }
            else
            {
                txtbxAns8.Text = "";
                wrong++;    
            }
            if (correct == 5)
            {
                correctSound.Play();
                MessageBox.Show("You are correct, the word is natsu");
                correctSound.Stop();
                this.Hide();
                var question9 = new Question9();
                question9.Show();
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

        private void Question8_Load(object sender, EventArgs e)
        {
            lblHeading.Text = "What is the Japanese word for Summer?";
            lblLetter6.Hide();
            lblLetter7.Hide();
        }
    }
}
