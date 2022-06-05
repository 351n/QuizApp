using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Quiz : Form
    {
        SingleAnswerQuestion question;

        public Quiz() {
            InitializeComponent();
        }

        private void summaryButton_Click(object sender, EventArgs e) {
            Program.ShowSummary();

            Hide();
        }

        private void Quiz_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void Quiz_Load(object sender, EventArgs e) {
            List<TextAnswer> answers = new List<TextAnswer>();
            answers.Add(new TextAnswer("First answer"));
            answers.Add(new TextAnswer("Second answer"));
            answers.Add(new TextAnswer("Third answer"));

            question = new SingleAnswerQuestion("This is placeholder question.", answers, answers.First());

            QuestionLabel.Text = question.GetDisplayText();

            foreach(TextAnswer a in answers) {
                Button button = new Button();
                button.Text = a.GetDisplayText();
                button.Click += AnswerClick;
                button.Tag = a.GetGuid();

                AnswersPanel.Controls.Add(button);
            }
        }

        private void AnswerClick(object sender, EventArgs e) {
            Button button = (sender as Button);
            Guid answerGuid = Guid.Parse(button.Tag.ToString());
            MessageBox.Show($"{button.Text} clicked. This is {question.CheckAnswer(answerGuid)} answer. {answerGuid} == {answerGuid}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
