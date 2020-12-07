using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public void CreatePrize(PrizeModel model)
        {
            throw new NotImplementedException();
        }

        public void CreateTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public void CreateTournament(TournamentModel model)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetPersonAll()
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetTeamAll()
        {
            throw new NotImplementedException();
        }

        public List<TournamentModel> GetTournamentAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            throw new NotImplementedException();
        }
    }
}
