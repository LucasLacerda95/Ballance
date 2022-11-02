using Ballance.Model;
using Ballance.Model.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballance.Controller {
    internal class UserController {

        SqlConnection connection = DataAcess.ConnectionDB();
        string _user;
        string _password;

        public UserController(string user, string password) {
            _user = user;
            _password = password;
        }

        public Boolean ReadUser() {

            var repository = new UserRepository(connection);
            var userDb = repository.Get(_user);


            if (_password == userDb.PasswordHash)
                return true;
            
            return false;
        }
    }
}

