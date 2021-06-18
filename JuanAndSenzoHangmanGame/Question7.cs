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
    public partial class Question7 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question7()
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
            if (txtbxAns7.Text == "s")
            {
                lblLetter1.Text = "s";
                txtbxAns7.Text = "";
                correct++;
            }
            if (txtbxAns7.Text == "h")
            {
                lblLetter2.Text = "h";               
                txtbxAns7.Text = "";
                correct++;
            }
            if (txtbxAns7.Text == "u")
            {
                lblLetter3.Text = "u";
                lblLetter6.Text = "u";
                lblLetter7.Text = "u";
                txtbxAns7.Text = "";
                correct++;
            }

            if (txtbxAns7.Text == "k")
            {
                lblLetter4.Text = "k";
                txtbxAns7.Text = "";
                correct++;
            }
            if (txtbxAns7.Text == "y")
            {
                lblLetter5.Text = "y";
                txtbxAns7.Text = "";
                correct++;
            }
            else
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (correct == 5)
            {
                correctSound.Play();
                MessageBox.Show("You are correct, the word is shukyuu");
                correctSound.Stop();
                this.Hide();
                var question8 = new Question8();
                question8.Show(); 
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

        private void Question7_Load(object sender, EventArgs e)
        {
            lblHeading.Text = "What is the Japanese word for football?";           
        }
    }
}
