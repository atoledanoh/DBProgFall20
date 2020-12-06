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
        public PersonModel CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        //TODO - Wire up the CreatePrize for the text file
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
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
    }
}
