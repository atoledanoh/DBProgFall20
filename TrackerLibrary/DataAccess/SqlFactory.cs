using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
