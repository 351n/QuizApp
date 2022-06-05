using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class TextAnswer : Answer
    {
        string displayText;

        public TextAnswer(string displayText) {
            this.guid = Guid.NewGuid();
            this.displayText = displayText;
        }

        public string GetDisplayText() {
            return displayText;
        }
    }
}
