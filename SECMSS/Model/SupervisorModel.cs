using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SECMSS.Model
{

    class Supervisor : UserModel
    {
        public Supervisor() : base() { }

        public Supervisor(int userId, string name, int age, string email, string password, string role)
            : base(userId, name, age, email, password, role) { }

        public override void DisplayWelcomeMessage()
        {

            MessageBox.Show($"Hello, Supervisor {this.name}!\nCampus maintenance and task oversight is now active.", "Supervisor Dashboard");
        }

    }
}
