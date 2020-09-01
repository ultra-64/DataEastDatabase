using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DEFormUI
{
    class DataAccess
    {
        public List<Game> FullList(string title)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DataEastDatabaseDB")))
            {
                var output = connection.Query<Game>("dbo.full_list").ToList();
                return output;
            }
        }

        public List<Game> GameByDate(string title)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DataEastDatabaseDB")))
            {
                var output = connection.Query<Game>("dbo.GameByDate").ToList();
                return output;
            }
        }
        public List<Game> GameByHardware(string title)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DataEastDatabaseDB")))
            {
                var output = connection.Query<Game>("dbo.GameByHardware").ToList();
                return output;
            }
        }
        public List<Game> GameByGenre(string title)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DataEastDatabaseDB")))
            {
                var output = connection.Query<Game>("dbo.GameByGenre").ToList();
                return output;
            }
        }
    }
}
