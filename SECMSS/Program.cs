using System;
using System.Windows.Forms;

namespace SECMSS
{
    static class Program
    {
        [STAThread] // This is required for Windows Forms to work
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // This line tells the app to open the Login Window first
            Application.Run(new LoginForm());
        }
    }
}