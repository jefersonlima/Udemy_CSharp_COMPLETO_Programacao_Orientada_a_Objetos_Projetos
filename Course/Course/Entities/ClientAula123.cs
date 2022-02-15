using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class ClientAula123
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public ClientAula123()
        {
        }

        public ClientAula123(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
