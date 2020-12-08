using System.Collections.Generic;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreatePrize(PrizeModel model);
        void CreatePerson(PersonModel model);
        void CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        void UpdateMatchup(MatchupModel model);
        List<PersonModel> GetPersonAll();
        List<PersonModel> GetPersonSearch(PersonModel model);
        List<TeamModel> GetTeamAll();
        List<TournamentModel> GetTournamentAll();
        List<PrizeModel> GetPrizeAll();
        void DeleltePrize(PrizeModel model);

        void UpdatePrize(PrizeModel model);
    }
}
