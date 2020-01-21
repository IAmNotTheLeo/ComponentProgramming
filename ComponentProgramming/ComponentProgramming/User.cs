using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentProgramming
{
    class User
    {
        private string username;
        private string state;

        public User(string username, string state) 
        {
            this.username = username;
            this.state = state;
        }

        public static bool LoginValidation()
        {
            // Check in the DB if user exists and return
            return true;
        }
    }
}
