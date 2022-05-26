using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteGrup
{
    public class SuperAdministrador
    {
        public String Name { get; set; }
        public String SurName { get; set; }
        public String Password { get; set; }
        public String UserName { get; set; }

        public SuperAdministrador(String name, String surName, String password, String userName)
        {
            this.Name = name;
            this.SurName = surName;
            this.Password = password;
            this.UserName = userName;
        }
    }
}
