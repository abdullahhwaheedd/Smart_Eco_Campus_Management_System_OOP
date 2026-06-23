using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SECMSS.Model
{
    
    
        class Admin : UserModel
        {
            public Admin() : base() { }

            public Admin(int userId, string name, int age, string email, string password, string role)
                : base(userId, name, age, email, password, role) { }

        public override void DisplayWelcomeMessage()
        {
            MessageBox.Show($"Access Granted. Welcome Administrator {this.name}.", "Admin Security");
        }
    }

    }

