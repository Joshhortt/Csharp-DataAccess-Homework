// Data Access - HOMEWORK - 02 - SQLite
// Build a small database using Sqlite, attach it to a C# project (Console or WinForms),
// and then wire ir up, to read from and write to the database.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PeopleForm());
        }
    }
}
