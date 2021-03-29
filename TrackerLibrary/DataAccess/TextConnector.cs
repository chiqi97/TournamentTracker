using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;


// 1 Load the text file *
//2  Convert the text to List <PrizeModel> *
// 3 Find the max ID *
// 4 Add the new record with the new ID(max+1) *
// 5 Convert the prizes to list<string>
// 6  Save the list<string> to the text file

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CompleteTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = new List<TournamentModel>();
            tournaments = GlobalConfig.TournamentsFile
               .FullFilePath().LoadFile().ConvertToTournamentModels();


            tournaments.Remove(model);

            tournaments.SaveToTournametFile();

            TournamentLogic.UpdateTournamentResults(model);
        }

        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> people = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            people.Add(model);
            people.SaveToPeopleFile();

            
        }

        public void CreatePrize(PrizeModel model)
        {
            // Przypisanie do nowej listy skonwertowanej listy z pliku PrizesFile=PrizeModels.csv
            //1, 2 Load The text file 
           List <PrizeModel> prizes= GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // ustaw w porzadku malejacym id, wez pierwsze z gory i dodaj do niego 1 i przypisz do current id
            // 3- find the max id
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            //4  Add the new record with the new id
            prizes.Add(model);

            //5 Convert the prizes to list <string> 
            // 6 - Save the list <string> to the file
            prizes.SaveToPrizeFile();

            
        }

        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = new List<TeamModel>();
            teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;

            }
            model.Id = currentId;
            teams.Add(model);
            teams.SaveToTeamFile();


            //List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //// ustaw w porzadku malejacym id, wez pierwsze z gory i dodaj do niego 1 i przypisz do current id
            //// 3- find the max id
            //int currentId = 1;
            //if (prizes.Count > 0)
            //{
            //    currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            //}
            //model.Id = currentId;
            ////4  Add the new record with the new id
            //prizes.Add(model);

            ////5 Convert the prizes to list <string> 
            //// 6 - Save the list <string> to the file
            //prizes.SaveToPrizeFile(PrizesFile);

            //return model;
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = new List<TournamentModel>();
            tournaments = GlobalConfig.TournamentsFile.FullFilePath().LoadFile().ConvertToTournamentModels();
            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            model.SaveRoundToFile();

            tournaments.Add(model);

            tournaments.SaveToTournametFile();

            TournamentLogic.UpdateTournamentResults(model);

        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> people = new List<PersonModel>();
            people = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();
            if (people.Count > 0)
            {
                return people;
            }
            return new List<PersonModel>();


        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> teams = new List<TeamModel>();
            teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();

            if (teams.Count > 0)
            {
                return teams;
            }
            return new List<TeamModel>();
        }

        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> allTournaments = GlobalConfig.TournamentsFile.FullFilePath().LoadFile().ConvertToTournamentModels();

            if (allTournaments.Count > 0)
            {
                return allTournaments;
            }
            return new List<TournamentModel>();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchup_ToFile();
        }
    }
}


