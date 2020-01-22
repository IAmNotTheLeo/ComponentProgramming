using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentProgramming
{
    class User
    {
        private String username;
        private String state;
        private int numberID;
        private String fullName;
        private String address;
        private int phoneNumber;
        private DateTime dateJoined;

        public User()
        {

        }
        public User(string username, string state) 
        {
            this.username = username;
            this.state = state;
        }
        public User(int numberID, String fullName, String address, int phoneNumber, DateTime dateJoined)
        {
            this.numberID = numberID;
            this.fullName = fullName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.dateJoined = dateJoined;

        }

        public static bool LoginValidation()
        {
            // Check in the DB if user exists and return
            return true;
        }
    }
}
