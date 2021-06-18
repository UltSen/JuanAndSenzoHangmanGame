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
    public partial class Question9 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question9()
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
            if (txtbxAns9.Text == "h")
            {
                lblLetter1.Text = "h";
                txtbxAns9.Text = "";
                correct++;
            }
            if (txtbxAns9.Text == "a")
            {
                lblLetter2.Text = "a";
                txtbxAns9.Text = "";
                correct++;
            }
            if (txtbxAns9.Text == "r")
            {
                lblLetter3.Text = "r";
                txtbxAns9.Text = "";
                correct++;
            }

            if (txtbxAns9.Text == "u")
            {
                lblLetter4.Text = "u";
                txtbxAns9.Text = "";
                correct++;
            }
            else
            {
                txtbxAns9.Text = "";
                wrong++;               
            }
            if (correct == 4)
            {
                correctSound.Play();
                MessageBox.Show("You are correct, the word is haru");
                correctSound.Stop();
                this.Hide();
                var question10 = new Question10();
                question10.Show();
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
        private void Question9_Load(object sender, EventArgs e)
        {
            lblHeading.Text = "What is the Japanese word for Spring?";
            lblLetter5.Hide();
            lblLetter6.Hide();
            lblLetter7.Hide();
        }
    }
}
