using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentProgramming.Models
{
    class Admin
    {
        private String username;
        private String state;

        public Admin(String username, String state)
        {
            this.username = username;
            this.state = state;
        }
    }
}
