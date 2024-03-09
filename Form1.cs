using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Quiz : Form
    {
        int i = 0, j = 1;

        Question[] ques;
        int currentQuesIndex;
        int totalPoints;

        public Quiz()
        {
            InitializeComponent();
            but_restart.Visible = false;
            ques = new Question[]
            {
                new Question
                {
                    Text = "What is the capital of France?",
                    Choices = new string[] { "Berlin", "Paris", "Madrid", "Rome" },
                    CorrectChoiceIndex = 1,
                    Points = 20
                },

                new Question
                {
                    Text = "What is the most populous city in France?",
                    Choices = new string[] { "Paris", "Marseille", "Lyon", "Toulouse" },
                    CorrectChoiceIndex = 0,
                    Points = 20
                },

                new Question
                {
                    Text = "What is the official language of France?",
                    Choices = new string[] { "French", "English", "German", "Spanish" },
                    CorrectChoiceIndex = 0,
                    Points = 20
                },

                new Question
                {
                    Text = "What is the national flower of France?",
                    Choices = new string[] {  "Rose", "Tulip", "Lily of the valley", "Daisy" },
                    CorrectChoiceIndex = 2,
                    Points = 20
                },

                new Question
                {
                    Text = "What is the national dish of France?",
                    Choices = new string[] {  "Beef Bourguignon", "Crêpes", "Quiche Lorraine", "Ratatouille" },
                    CorrectChoiceIndex = 1,
                    Points = 20
                }
            };
            currentQuesIndex = 0;
            totalPoints = 0;
        }

        private void DisplayQuestion()
        {
            if (currentQuesIndex < ques.Length)
            {
                Question currentQuestion = ques[currentQuesIndex];
                txt_ques.Text = currentQuestion.Text;

                rdb_option1.Text = currentQuestion.Choices[0];
                rdb_option2.Text = currentQuestion.Choices[1];
                rdb_option3.Text = currentQuestion.Choices[2];
                rdb_option4.Text = currentQuestion.Choices[3];
            }
            else
            {
                timer.Enabled = false;
                but_restart.Visible = true;
                txt_ques.Text = "Quiz Finished!";
                txt_points.Text = totalPoints.ToString();
                but_next.Visible = false;
            }

            rdb_option1.Checked = false;
            rdb_option2.Checked = false;
            rdb_option3.Checked = false;
            rdb_option4.Checked = false;
        }

        private void but_start_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            but_start.Enabled = false;
            DisplayQuestion();

        }

        private void but_next_Click(object sender, EventArgs e)
        {
            i = 0;
            j += 1;
            calculatePoints();
            currentQuesIndex++;
            DisplayQuestion();
        }

        void calculatePoints()
        {
            Question currentQuestion = ques[currentQuesIndex];
            int selectedChoiceIndex = -1;

            if (rdb_option1.Checked) selectedChoiceIndex = 0;
            else if (rdb_option2.Checked) selectedChoiceIndex = 1;
            else if (rdb_option3.Checked) selectedChoiceIndex = 2;
            else if (rdb_option4.Checked) selectedChoiceIndex = 3;

            if (selectedChoiceIndex == currentQuestion.CorrectChoiceIndex)
            {
                totalPoints += currentQuestion.Points;

                switch (currentQuesIndex)
                {
                    case 0:
                        but_ques1.BackColor = Color.Green;
                        break;
                    case 1:
                        but_ques2.BackColor = Color.Green;
                        break;
                    case 2:
                        but_ques3.BackColor = Color.Green;
                        break;
                    case 3:
                        but_ques4.BackColor = Color.Green;
                        break;
                    case 4:
                        but_ques5.BackColor = Color.Green;
                        break;
                }
            }
            else
            {
                switch (currentQuesIndex)
                {
                    case 0:
                        but_ques1.BackColor = Color.Red;
                        break;
                    case 1:
                        but_ques2.BackColor = Color.Red;
                        break;
                    case 2:
                        but_ques3.BackColor = Color.Red;
                        break;
                    case 3:
                        but_ques4.BackColor = Color.Red;
                        break;
                    case 4:
                        but_ques5.BackColor = Color.Red;
                        break;
                }
            }
        }

        private void but_restart_Click(object sender, EventArgs e)
        {
            but_restart.Visible = false;
            timer.Enabled = true;
            txt_points.Clear();
            txt_ques.Clear();
            rdb_option1.Checked = false;
            rdb_option2.Checked = false;
            rdb_option3.Checked = false;
            rdb_option4.Checked = false;
            but_ques1.BackColor = Color.LightGray;
            but_ques2.BackColor = Color.LightGray;
            but_ques3.BackColor = Color.LightGray;
            but_ques4.BackColor = Color.LightGray;
            but_ques5.BackColor = Color.LightGray;
            currentQuesIndex = 0;
            totalPoints = 0;
            i = 0;
            j = 1;
            DisplayQuestion();
            but_next.Visible = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            i += 1;
            if (i <= 60)
            {
                txt_sec.Text = i.ToString();
                txt_min.Text = j.ToString();
            }
            else
            {
                j += 1;
                txt_sec.Text = j.ToString();
                calculatePoints();
                currentQuesIndex++;
                DisplayQuestion();
                i = 0;
            }
        }
    }

    public class Question
    {
        public string Text;
        public string[] Choices;
        public int CorrectChoiceIndex;
        public int Points;
    }
}