using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteGrup
{
    public class Administrador
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Password { get; set; }

        public String UserName { get; set; }

        public Administrador() { }
        public Administrador(String name, String surname, String password, String username) {
            this.Name = name;
            this.Surname = surname;
            this.Password = password;
            this.UserName = username;
        }

    }
}
