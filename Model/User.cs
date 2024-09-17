using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2307sb2.Model
{
    public class User
    {
        public User(string name, string email, string password, DateTime date)
        {
            Name = name;
            Email = email;
            Password = password;
            Date = date;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Email} - {Password} - {Date.ToString()}";
        }
    }
}
