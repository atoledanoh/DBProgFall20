using System;

namespace TrackerLibrary.DataAccess
{
    public class SqlFactory
    {
        public static Func<IDataConnection> TournamentRepoFunc { private get; set; }

        public static IDataConnection CreateTournamentRepo()
        {
            return TournamentRepoFunc();
        }
    }
}
