using System;
using System.Windows.Forms;

namespace CrudNube
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // Iniciar con el formulario de Login
        }
    }
}
