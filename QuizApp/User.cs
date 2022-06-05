using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class User
    {
        Guid guid;
        string displayName;

        private User() { }

        public User(string displayName) {
            this.guid = Guid.NewGuid();
            this.displayName = displayName;
        }

        public User(Guid guid, string displayName) {
            this.guid = guid;
            this.displayName = displayName;
        }
    }
}
