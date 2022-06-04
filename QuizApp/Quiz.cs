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
    }
}
