using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery_.Model
{
    [Serializable]
   public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public User()
        {
        }

        public User(string login, string pass, string name, string surname)
        {
            Login = login;
            Password = pass;
            Name = name;
            SurName = surname;
        }
    }
}
