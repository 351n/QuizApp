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
    public partial class Summary : Form
    {
        public Summary() {
            InitializeComponent();
        }

        private void Summary_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void restartButton_Click(object sender, EventArgs e) {
            Program.ShowQuiz();

            Hide();
        }

        private void menuButton_Click(object sender, EventArgs e) {
            Program.ShowMenu();

            Hide();
        }
    }
}
