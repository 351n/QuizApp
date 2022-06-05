using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class SingleAnswerQuestion : Answerable
    {
        string displayText;        
        Answer correctAnswer;

        private SingleAnswerQuestion() {}

        public SingleAnswerQuestion(string displayText, IEnumerable<Answer> answers, Answer correctAnswer) {
            this.displayText = displayText;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
        }
        public bool CheckAnswer(Guid guid) {
            return correctAnswer.GetGuid() == guid;
        }

        public override bool CheckAnswer(Answer answer) {
            return correctAnswer.GetGuid() == answer.GetGuid();
        }

        internal string GetDisplayText() {
            return displayText;
        }
    }
}
