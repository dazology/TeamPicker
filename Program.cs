using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FootballTeamGenerator
{
    static class Program
    {
        public static string C_PLAYERS_XML = Application.StartupPath + @"\Players.xml";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FootballTeamGenerator());
        }
    }
}