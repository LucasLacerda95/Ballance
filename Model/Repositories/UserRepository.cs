using Ballance.Model.DataModels;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Ballance.Model.Repositories {
    internal class UserRepository {

        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection)
            => _connection = connection;

        public User Get(string user) {
            var item = new User();

            try {
                var query = @"SELECT * FROM [User] WHERE [user_Name] = @exp";

                    item = _connection.QuerySingle<User>(query, new {
                    exp = $"{user}"
                });

                _connection.Close();
                return item;
            } catch(Exception ex) {
                
                return item;
            }
        }  
    }
}
