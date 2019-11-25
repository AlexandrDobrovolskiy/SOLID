using System;

namespace s
{
    class Salary {}

    // This employee may have many reasons to change (e.g. change full name composition logic)
    class WrongEmployee {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        // ...Other Employee related methods

        public string getFullName(bool skipMiddle = false) {
            return $"{FirstName} {MiddleName} {LastName}";
        }

    }

    // This employee has only one reason to change
    class RightEmployee {
        public Name Name { get; set; }
    }

    class Name {
        
        public string First { get; set; }
        public string Last { get; set; }
        public string Middle { get; set; }

        public string getFull(bool skipMiddle = false) {
            return $"{First} {Middle} {Last}";
        }
    }
}
