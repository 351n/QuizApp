﻿using System;
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

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CreateMenu());
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
    }
}
