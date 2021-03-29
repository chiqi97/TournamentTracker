using System.Collections.Generic;
using System.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string TournamentsFile = "TournamentModels.csv";
        public const string PersonFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string PrizesFile = "PrizeModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";
        public static IDataConnection Connection { get; private set; } 

        public static void InitalizeConnections(DatabaseType db)
        {
            // Przyklad wczytania Enuma automatycznie 2 tab przy wczytywaniu switch 2 enter przy podawaniu parametru
            //switch (db)
            //{
            //    case DatabaseType.Sql:
            //        break;
            //    case DatabaseType.TextFile:
            //        break;
            //    default:
            //        break;
            //}
            if (db == DatabaseType.Sql)
            {
                // TODO - Set up the SQL connector properly

                SqlConnector sql = new SqlConnector();
                Connection = sql;


            }
           else if (db == DatabaseType.TextFile)
            {
                //TODO - create the text connection
                TextConnector text = new TextConnector();
                Connection = text;

            }
        }

        public static string CnnString(string name)
        {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppKeyLookup(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }


    }
}
