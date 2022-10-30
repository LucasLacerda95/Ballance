using Ballance.Model.DataModels;
using Ballance.Model.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Ballance.Model {
    internal class DataAcess {

        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Ballance;User ID=sa;Password=zulu_2020#;Encrypt=false";
        
        private static SqlConnection ConnectionDB() {
            var connection = new SqlConnection(CONNECTION_STRING);

            connection.Open();
            return connection;
        }

        public static void ReadUsers(SqlConnection connection) {

            var repository = new UserRepository(connection);
            var users = repository.Get();

        }
    }
}
