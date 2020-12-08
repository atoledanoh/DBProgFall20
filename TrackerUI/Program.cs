using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
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

            //Application.Run(new MainContainer());

            SplashScreen splashScreen = new SplashScreen();
            splashScreen.ShowDialog();

            Application.Run(new MainContainer());
        }
    }
}
