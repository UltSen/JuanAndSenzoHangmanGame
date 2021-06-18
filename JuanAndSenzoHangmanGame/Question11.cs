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
    public partial class Question11 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question11()
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
            if (txtbxAns11.Text == "t")
            {
                lblLetter1.Text = "t";
                lblLetter3.Text = "t";
                txtbxAns11.Text = "";
                correct++;
            }
            if (txtbxAns11.Text == "a")
            {
                lblLetter2.Text = "a";
                lblLetter4.Text = "a";
                lblLetter6.Text = "a";
                txtbxAns11.Text = "";
                correct++;
            }
            if (txtbxAns11.Text == "k")
            {   
                lblLetter5.Text = "k";
                txtbxAns11.Text = "";
                correct++;
            }
            if (txtbxAns11.Text == "u")
            {
                lblLetter7.Text = "u";
                txtbxAns11.Text = "";
                correct++;
            }           
            else
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (correct == 4)
            {
                correctSound.Play();
                MessageBox.Show("You are correct, the word is tatakau");
                correctSound.Stop();
                this.Hide();
                var question12 = new Question12();
                question12.Show(); ;
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

        private void Question11_Load(object sender, EventArgs e)
        {
            lblHeading.Text = "What is the Japanese word for fight?";
        }
    }
}