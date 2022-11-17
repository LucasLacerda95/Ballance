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


        internal User Get(string userForm) {

       
            try {
                var query = @"SELECT * FROM [User] WHERE [user_Name] = @user";

                var item = _connection.QuerySingle<User>(query, new {
                    user = $"{userForm}"
                });
                //_connection.Close();


                return item;
                
            } catch(Exception ex) {
                MessageBox.Show($"{ex}");
                return null;
            }
        }  


        internal int Create(string userForm, string userNameForm, string emailForm, string passwordForm) {
            var user = new User();

            user.user_Name = userForm;
            user.Name = userNameForm;
            user.Email = emailForm;
            user.PasswordHash = passwordForm;

            try {
                var query = @"
                    INSERT INTO [User]  ([user_Name],[Name],[Email],[PasswordHash]) 
                    VALUES (@user_Name,@Name,@Email,@PasswordHash)";

                var rows = _connection.Execute(query, new {
                    user.user_Name,
                    user.Name,
                    user.Email,
                    user.PasswordHash
                });

                return rows;

            } catch (Exception ex) {
                MessageBox.Show($"{ex}");
                return 0;
            }

        }
    }
}
