using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    abstract class Answerable
    {
        Guid guid;
        protected IEnumerable<Answer> answers;

        public abstract bool CheckAnswer(Answer answer);
    }
}
