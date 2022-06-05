using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    static class Program
    {
        static Menu menuForm;
        static Quiz quizForm;
        static Summary summaryForm;
        static Creator creatorForm;
        static User user;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CreateMenu());

            user = new User("DemoUser");
        }

        static Menu CreateMenu() {
            if(menuForm == null) {
                menuForm = new Menu();
            }

            return menuForm;
        }

        internal static void ShowMenu() {
            menuForm.Show();
        }

        internal static void ShowQuiz() {
            if(quizForm == null) {
                quizForm = new Quiz();
            }

            quizForm.Show();
        }

        internal static void ShowSummary() {
            if(summaryForm == null) {
                summaryForm = new Summary();
            }

            summaryForm.Show();
        }

        internal static void ShowCreator() {
            if(creatorForm == null) {
                creatorForm = new Creator();
            }

            creatorForm.Show();
        }
    }
}
