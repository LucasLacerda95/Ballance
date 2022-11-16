using Ballance.Model.DataModels;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Ballance.Model.Repositories {
    internal class UserRepository {

        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection)
            => _connection = connection;

        internal User Get(string user) {
            var item = new User();

            try {
                var query = @"SELECT * FROM [User] WHERE [user_Name] = @exp";

                    item = _connection.QuerySingle<User>(query, new {
                    exp = $"{user}"
                });

                _connection.Close();
                return item;
            } catch(Exception ex) {
                MessageBox.Show($"{ex}");
                return item;
            }
        }  


        internal int Create(string userForm, string userNameForm, string passwordForm, string emailForm) {
            var user = new User();

            user.user_Name = userForm;
            user.Name = userNameForm;
            user.PasswordHash = passwordForm;
            user.Email = emailForm;

            try {
                var query = @"INSERT INTO [User] VALUES (@user_Name,@Name,@PasswordHash,@Email)";

                var rows = _connection.Execute(query, new {
                    user.user_Name,
                    user.Name,
                    user.PasswordHash,
                    user.Email
                });

                return rows;
            } catch (Exception ex) {
                MessageBox.Show($"{ex}");
                return 0;
            }

        }
    }
}
