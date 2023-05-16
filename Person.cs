using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Person
    {
        private String name;
        private String email;
        private String password;
        private String type;

        private static Person instance = null;

       private Person(string name, string email, string password, string type)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.type = type;
        }

        private Person()
        {
            email = null;
            password = null;
            name = null;
            type = null;
        }

        public static Person getInstance()
        {
            return instance;
        }

        public static void setInstance(string name, string email, string password, string type)
        {
            if (instance == null)
            {
                instance=new Person(name, email, password, type); 
            } else
            {
                instance.email= email;
                instance.name = name;
                instance.password = password;
                instance.type = type;
            }
        }

        public static void logout()
        {
            instance = null;
        }



        public String getEmail()
        {
            return email;
        }

        public String getPassword()
        {
            return password;
        }

        public String getName()
        {
            return name;
        }


        public String getType()
        {
            return this.type;
        }
    }
}
