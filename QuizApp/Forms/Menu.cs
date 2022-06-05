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
    public partial class Menu : Form
    {
        public Menu() {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e) {
            Program.ShowQuiz();

            Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e) {
            MessageBox.Show("Setting currently not available.", "Not implemented yet!", MessageBoxButtons.OK);
        }

        private void creatorButton_Click(object sender, EventArgs e) {
            Program.ShowCreator();

            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
