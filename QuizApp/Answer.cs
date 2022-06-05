using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    abstract class Answer
    {
        protected Guid guid;

        internal Guid GetGuid() {
            return guid;
        }
    }
}
