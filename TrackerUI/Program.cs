using System;
using System.Windows.Forms;
using TrackerLibrary.DataAccess;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlFactory.TournamentRepoFunc = (() => new SQLConnector());
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashScreen splashScreen = new SplashScreen();
            splashScreen.ShowDialog();
            Application.Run(new Login());
            Application.Run(new MainContainer());
        }
    }
}
