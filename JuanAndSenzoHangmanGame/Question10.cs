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
    public partial class Question10 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question10()
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
            if (txtbxAns10.Text == "s")
            {
                lblLetter1.Text = "s";
                txtbxAns10.Text = "";
                correct++;
            }
            if (txtbxAns10.Text == "u")
            {
                lblLetter2.Text = "u";
                txtbxAns10.Text = "";
                correct++;
            }
            if (txtbxAns10.Text == "g")
            {
                lblLetter3.Text = "g";
                txtbxAns10.Text = "";
                correct++;
            }
            if (txtbxAns10.Text == "o")
            {
                lblLetter4.Text = "o";
                txtbxAns10.Text = "";
                correct++;
            }
            if (txtbxAns10.Text == "i")
            {
                lblLetter5.Text = "i";
                txtbxAns10.Text = "";
                correct++;
            }
            else
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (correct == 5)
            {
                correctSound.Play();
                MessageBox.Show("You are correct, the word is sugoi");
                correctSound.Stop();
                this.Hide();
                var question11 = new Question11();
                question11.Show();
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

        private void Question10_Load(object sender, EventArgs e)
        {
            lblHeading.Text = "What is the Japanese word for amazing?";
            lblLetter6.Hide();
            lblLetter7.Hide();
        }
    }
}
