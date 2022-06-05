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
    public partial class Creator : Form
    {
        public Creator() {
            InitializeComponent();

            AnswersPanel.Controls.Add(new TextAnswerInput());
            AnswersPanel.Controls.Add(new TextAnswerInput());
        }

        private void AddAnswerButton_Click(object sender, EventArgs e) {
            AnswersPanel.Controls.Add(new TextAnswerInput());
        }

        private void MenuButton_Click(object sender, EventArgs e) {
            Program.ShowMenu();

            Hide();
        }

        private void Creator_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
