using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensopgave
{
    class User
    {
        private string _userName;
        public uint ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (_userName.All(Char.IsLetterOrDigit))
                    UserName = _userName;
                else
                    new Exception();
            }
        }

        public User(uint iD, string firstName, string lastName, string userName)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            _userName = userName;
        }
    }
}
