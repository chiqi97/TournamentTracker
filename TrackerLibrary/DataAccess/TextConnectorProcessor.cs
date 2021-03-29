using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
            public static string FullFilePath(this string fileName) //PrizeModels.csv nazwa pliku
        {
            // c:\data\TournamentTracker\PrizeModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }
        // Load file- 1
        public static List<string> LoadFile (this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();

            }
            return File.ReadAllLines(file).ToList();
        }
        //2  Convert the text to list <prizeModel>
        public static List<PrizeModel> ConvertToPrizeModels (this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (var line in lines)
            {
                string[] cols = line.Split('^');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
                


            }
            return output;


        }
        //5 Convert the prizes to list <string> 
        // 6 - Save the list <string> to the file
        public static void SaveToPrizeFile(this List <PrizeModel> models)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models )
            {
                lines.Add($"{ p.Id}^{ p.PlaceNumber}^{ p.PlaceName}^{ p.PrizeAmount}^{ p.PrizePercentage}");
            }
            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);

        }

        //CreateTeamForm Add Member 

        public static void SaveToPeopleFile (this List<PersonModel> models)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                lines.Add($"{ p.Id}^{ p.FirstName}^{ p.LastName}^{ p.EmailAddress}^{ p.CellphoneNumber}");
            }
            File.WriteAllLines(GlobalConfig.PersonFile.FullFilePath(), lines);

        }

       public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach(var line in lines)
            {
                string[] cols = line.Split('^');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);

            }
            return output;

        }

        public static List<TeamModel> ConvertToTeamModels( this List<string> lines)
        {
            //id^ team name^ list of ids separated by the pipe
            // 3^ Tim's Team^ 1|3|5(id each person)
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split('^');
                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];
               
                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;


        }

        public static void SaveToTeamFile(this List<TeamModel> models)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel t in models)
            {
                lines.Add($"{ t.Id }^{ t.TeamName }^{ ConvertPeopleListToString(t.TeamMembers) }");
            }
            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);

        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";
            //2|5| 
            if (people.Count == 0)
            {
                return "";
            }

            foreach (PersonModel p in people)
            {
                output += $"{ p.Id }|";

            }
            // usun ostatnia kreske pionowa
            output = output.Substring(0, output.Length - 1);

            return output;

        }

        public static List<TournamentModel>ConvertToTournamentModels(
            this List<string> lines)
        {
            //id^ TournamentName^ EntryFee^(id|id|id - EnteredTeams)^(id|id|id - Prizes)^(Rounds - id^id^id|id^id^id|id^id^id)

            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();

            foreach (string line in lines)
            {
                TournamentModel t = new TournamentModel();
                string[] cols = line.Split('^');
                t.Id = int.Parse(cols[0]);
                t.TournamentName = cols[1];
                t.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');
                foreach ( string id in teamIds)
                {
                    t.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());

                }

                if (cols[4].Length>0)
                {
                    string[] prizesId = cols[4].Split('|');


                    foreach (string id in prizesId)
                    {

                        t.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    } 
                }

                //TODO Capture Rounds infromation
                string[] rounds = cols[5].Split('|');


                foreach (string round in rounds)
                {
                    string[] msText = round.Split('&');
                    List<MatchupModel> ms = new List<MatchupModel>();
                    foreach (string matchupModelTextId in msText)
                    {

                        if (matchupModelTextId.Length > 0)
                        {
                            ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).FirstOrDefault());
                        }


                    }
                    t.Rounds.Add(ms);
                }

                output.Add(t);
            }



            return output;

        }


       public static void SaveToTournametFile (this List<TournamentModel> model)
        {
            List<string> lines = new List<string>();
            
            foreach(TournamentModel t in model)
            {
                lines.Add($@"{ t.Id }^"+
                    $"{ t.TournamentName }^"+
                   $"{ t.EntryFee }^" +
                    $"{ ConvertTeamModelListToString(t.EnteredTeams) }^"+
                    $"{ ConvertPrizeModelListToString(t.Prizes) }^"+
                        $"{ ConvertRoundListToString(t.Rounds) }");
            }

            File.WriteAllLines(GlobalConfig.TournamentsFile.FullFilePath(), lines);

        }

        public static void SaveRoundToFile(this TournamentModel model)
        {
            //Loop through each Round
            //Loop through each Matchup
            // Get the id for the new matchup and save the record
            // Loop through each entry^ get the id and save it
            foreach (List<MatchupModel> round in model.Rounds)
            {

                foreach (MatchupModel matchup in round)
                {
                    //Load all of the matchups from file
                    //Get the top id and add one
                    //store the id
                    //save the matchup record

                    matchup.SaveMatchupToFile();

                }

            }

        }

        public static void SaveMatchupToFile(this MatchupModel matchup)
        {

            //List<TournamentModel> tournaments = new List<TournamentModel>();
            //tournaments = TournamentsFile.FullFilePath().LoadFile().ConvertToTournamentModels
            //    (TeamFile^
            //    PersonFile^
            //    PrizesFile);

            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();

            int currentId = 1;

            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id+1;
            }
            matchup.Id = currentId;

            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile();
            }

            List<string> lines = new List<string>();
            //id=0^ entrie=1(pipe delimited by id)^ winner =2^ matchupRound=3
            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id}^{""}^{winner}^{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);


            //save to file
            lines = new List<string>();
            //id=0^ entrie=1(pipe delimited by id)^ winner =2^ matchupRound=3
            foreach (MatchupModel m in matchups)
            {
                string winner= "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id}^{ConvertListMatchupEntryToString(m.Entries)}^{winner}^{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void UpdateMatchup_ToFile(this MatchupModel matchup)
        {


            

                //List<TournamentModel> tournaments = new List<TournamentModel>();
                //tournaments = TournamentsFile.FullFilePath().LoadFile().ConvertToTournamentModels
                //    (TeamFile^
                //    PersonFile^
                //    PrizesFile);

            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();
            MatchupModel oldMatchup= new MatchupModel(); 

            foreach (MatchupModel m in matchups)
            {
                if (m.Id == matchup.Id)
                {
                    oldMatchup = m;

                }
            }
            matchups.Remove(oldMatchup);

            matchups.Add(matchup);


                foreach (MatchupEntryModel entry in matchup.Entries)
                {
                    entry.UpdateEntryToFile();
                }

                List<string> lines = new List<string>();
                //id=0^ entrie=1(pipe delimited by id)^ winner =2^ matchupRound=3
                foreach (MatchupModel m in matchups)
                {
                    string winner = "";
                    if (m.Winner != null)
                    {
                        winner = m.Winner.Id.ToString();
                    }
                    lines.Add($"{m.Id}^{""}^{winner}^{m.MatchupRound}");
                }
                File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);


                //save to file
                lines = new List<string>();
                //id=0^ entrie=1(pipe delimited by id)^ winner =2^ matchupRound=3
                foreach (MatchupModel m in matchups)
                {
                    string winner = "";
                    if (m.Winner != null)
                    {
                        winner = m.Winner.Id.ToString();
                    }
                    lines.Add($"{m.Id}^{ConvertListMatchupEntryToString(m.Entries)}^{winner}^{m.MatchupRound}");
                }
                File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
            
        }

        private static string ConvertListMatchupEntryToString(List<MatchupEntryModel> entries)
        {
            string output = "";
            if (entries.Count == 0)
            {
                return output;
            }
            foreach (MatchupEntryModel e in entries)
            {
                output += $"{e.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static void SaveEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int currentId = 1;
            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }
            entry.Id = currentId;
            entries.Add(entry);

            List<string> lines = new List<string>();
            foreach (MatchupEntryModel e in entries) 
            {
                string parent = "";
                if(e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                   teamCompeting= e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id}^{teamCompeting}^{e.Score}^{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
            //save to file

        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();


            foreach (string line in lines)
            {
                MatchupEntryModel model = new MatchupEntryModel();
                string[] cols = line.Split('^');

                model.Id = int.Parse(cols[0]);

                if (cols[1].Length == 0)
                {
                    model.TeamCompeting = null;
                }
                else
                {
                    model.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                }


                model.Score = double.Parse(cols[2]);

                int parentId = 0;
                if (int.TryParse(cols[3],out parentId))
                {
                    model.ParentMatchup = LookupMatchupById(parentId);
                }
                else
                {
                    model.ParentMatchup = null;
                }

                // model.ParentMatchup= 

                output.Add(model);
            }
            return output;
        }

        private static MatchupModel LookupMatchupById(int id)
        {
            List<string> Matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach(string matchup in Matchups)
            {
                string[] cols = matchup.Split('^');

                if (cols[0] == id.ToString())
                {

                    List<string> matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModel().First();


                }


            }




            return null;



        }

        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModel(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output= new List<MatchupEntryModel>();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchupEntries = new List<string>();
         

            foreach (string id in ids)
            {

                foreach (string entry in entries)
                {
                    string[] cols = entry.Split('^');
                    if (cols[0] == id)
                    {
                        matchupEntries.Add(entry);
                    }

                }


            }
            output = matchupEntries.ConvertToMatchupEntryModels();

            return output;
        }
        private static TeamModel LookupTeamById(int id)
        {
            List<string> Teams = new List<string>();
            Teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();


            foreach (string team in Teams)
            {
                string[] cols = team.Split('^');
                if (cols[0] == id.ToString())
                {
                    List<string> foundTeams = new List<string>();
                    foundTeams.Add(team);
                    return foundTeams.ConvertToTeamModels().First();
                }



            }

            return null;




            //return Teams.Where(x => x.Id == id).First();


        }
        public static List<MatchupModel> ConvertToMatchupModel(this List<string> lines)
        {
            //id=0^ entrie=1(pipe delimited by id)^ winner =2^ matchupRound=3
            List<MatchupModel> matchups = new List<MatchupModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split('^');

                MatchupModel m = new MatchupModel();
                m.Id = int.Parse(cols[0]);

                m.Entries = ConvertStringToMatchupEntryModel(cols[1]);


                if (cols[2].Length > 0)
                {
                    m.Winner = LookupTeamById(int.Parse(cols[2]));
                }
                else
                {
                    m.Winner=null;
                }



                m.MatchupRound = int.Parse(cols[3]);
                matchups.Add(m);
            }

            return matchups;
        }



        private static string ConvertTeamModelListToString(List<TeamModel> teams)
        {
            string output = "";
            if (teams.Count == 0)
            {
                return output;
            }
            foreach (TeamModel t in teams)
            {

                output += $"{ t.Id }|";
               

            }

            output = output.Substring(0, output.Length - 1);
            return output;

        }

        private static string ConvertPrizeModelListToString (List<PrizeModel> prizes)
        {
            // Rounds - id^id^id|id^id^id
            string output = "";
            if (prizes.Count == 0)
            {
                return output;
            }
            foreach (PrizeModel p in prizes)
            {
                output += $"{ p.Id }|";
            }
            output = output.Substring(0, output.Length -1 );
            return output;
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";
            if (rounds.Count == 0)
            {
                return output;
            }
            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ ConverMatchupListToString (r) }|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConverMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";
            if(matchups.Count==0)
            {
                return output;
            }
            foreach (MatchupModel m in matchups)
            {
                if (m != null)
                {
                    output += $"{m.Id}&";
                }

            }
            if (output.Length > 0)
            {
                output = output.Substring(0, output.Length - 1);
            }

            return output;


        }


        public static void UpdateEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            MatchupEntryModel oldEntry = new MatchupEntryModel();

            foreach (MatchupEntryModel me in entries)
            {

                if (me.Id == entry.Id)
                {
                    oldEntry = me;
                }
            }
            entries.Remove(oldEntry);

            entries.Add(entry);




            List<string> lines = new List<string>();
            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id}^{teamCompeting}^{e.Score}^{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

    }
}
