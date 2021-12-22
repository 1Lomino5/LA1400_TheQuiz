using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace _1400_Programm
{
    public partial class Form1 : Form
    {
        public int CorrectAnswer = 1;
        public int QuestionNumber = 1;
        public int totalQuestions;
        public int points = 2;
        public int WrongHint = 1;
        public int HintMode;
        

        public Form1()
        {
            InitializeComponent();
            AskQuestion(QuestionNumber); 
        }
        private void checkAnswer(int useranswer)
        {
            if (useranswer == CorrectAnswer)
            {
                QuestionNumber++;
                AskQuestion(QuestionNumber);
                points = points + 3;
                label3.Text = Convert.ToString(points);
            }
            else
            {
                QuestionNumber++;
                MessageBox.Show("Die richtigie Antwort wäre Nummer " + CorrectAnswer + " gewesen.");
                AskQuestion(QuestionNumber);
                points = points - 2;
                label3.Text = Convert.ToString(points);
            }

        }
        public void AskQuestion(int QueNumber)
        {
            switch (QueNumber)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Mops;
                    label1.Text = "Was ist das für ein Hund?";
                    button1.Text = "1. Golden Retriever";
                    button2.Text = "2. Bulldogge";
                    button3.Text = "3. Mops";
                    button4.Text = "4. Schäferhund";
                    CorrectAnswer = 3;
                    WrongHint = 1;
                    HintMode = 2;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Klippschliefer;
                    label1.Text = "Was ist das für ein Tier?";
                    button1.Text = "1. ein brauner Dachs";
                    button2.Text = "2. ein kleiner Panda";
                    button3.Text = "3. ein Tenrek";
                    button4.Text = "4. ein Klippschliefer";
                    CorrectAnswer = 4;
                    WrongHint = 3;
                    HintMode = 2;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.helsinki;
                    label1.Text = "Von welcher Stadt ist dies die Flagge?";
                    button1.Text = "1. von Helsinki";
                    button2.Text = "2. von Kopenhagen";
                    button3.Text = "3. von Oslo";
                    button4.Text = "4. von Reykjavík";
                    CorrectAnswer = 1;
                    WrongHint = 3;
                    HintMode = 1;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.Uganda5;
                    label1.Text = "Von welchem Land ist das die Flagge?";
                    button1.Text = "1. Borneo";
                    button2.Text = "2. Kampala";
                    button3.Text = "3. Uganda";
                    button4.Text = "4. Ruanda";
                    CorrectAnswer = 3;
                    WrongHint = 1;
                    HintMode = 2;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.HDMI;
                    label1.Text = "Was ist das für ein Kabel?";
                    button1.Text = "1. Displayport";
                    button2.Text = "2. VGA";
                    button3.Text = "3. USB C";
                    button4.Text = "4. HDMI";
                    CorrectAnswer = 4;
                    WrongHint = 1;
                    HintMode = 2;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.Trabant;
                    label1.Text = "Zu welcher Automarke gehört dieses Auto?";
                    button1.Text = "1. zu Audi";
                    button2.Text = "2. zu Trabant";
                    button3.Text = "3. zu Tata";
                    button4.Text = "4. zu Renault";
                    CorrectAnswer = 2;
                    WrongHint = 3;
                    HintMode = 1;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.Sui;
                    label1.Text = "Was macht diese Person hauptberuflich?";
                    button1.Text = "1. Ronaldo";
                    button2.Text = "2. Basketball spielen";
                    button3.Text = "3. Fussball spielen";
                    button4.Text = "4. Golfen";
                    CorrectAnswer = 3;
                    WrongHint = 1;
                    HintMode = 1;
                    break;

                case 8:
                    pictureBox1.Hide();
                    label1.Hide();
                    button1.Hide();
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    label2.Hide();
                    label3.Hide();
                    button5.Hide();
                    button6.Hide();
                    button7.Hide();

                    Form2 end = new Form2(this);
                    end.Show();
                    this.Hide();
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkAnswer(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            checkAnswer(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            checkAnswer(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            checkAnswer(4);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (points < 1)
            {
                MessageBox.Show("Joe, Sie haben zu wenig Punkte.");
            }
            else
            {
                if (HintMode == 1)
                {
                    MessageBox.Show("Die richtige Antwort ist entweder " + CorrectAnswer + " oder " + WrongHint);
                    points--;
                    label3.Text = Convert.ToString(points);
                }
                else
                {
                    MessageBox.Show("Die richtige Antwort ist entweder " + WrongHint + " oder " + CorrectAnswer);
                    points--;
                    label3.Text = Convert.ToString(points);
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (points < 1)
            {
                MessageBox.Show("Joe, Sie haben zu wenig Punkte.");
            }
            else
            {
                points--;
                QuestionNumber++;
                AskQuestion(QuestionNumber);
                label3.Text = Convert.ToString(points);
            }
        }

        public void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label1.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label2.Hide();
            label3.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            Form2 end = new Form2(this);
           
            end.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }  
    }
}
