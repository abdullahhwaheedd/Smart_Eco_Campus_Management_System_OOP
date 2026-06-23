using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SECMSS.Model
{
    
  
        public abstract class UserModel
        {
            protected int userId;
            protected string name;
            protected int age;
            protected string email;
            protected string password;
            protected string role;
        

            public UserModel(int userId, string name, int age, string email, string password, string role)
            {
                this.userId = userId;
                this.name = name;
                this.age = age;
                this.email = email;
                this.password = password;
                this.role = role;
            }
        public UserModel()
        {
            
        }
        public int UserId
            {
                get { return userId; }
                set { userId = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            public string Role
            {
                get { return role; }
                set { role = value; }
            }
      
        public virtual void  DisplayWelcomeMessage()
        {
            MessageBox.Show("Welcome to the Smart Eco Campus Management System", "System Info");
        }
    }

    }

