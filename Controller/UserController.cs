using Ballance.Model;
using Ballance.Model.DataModels;
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
        string _user, _password, _userName, _email;
        

        public UserController(string user, string password) {
            _user = user;
            _password = password;
        }

        public UserController(string userForm, string userNameForm, string passwordForm, string emailForm) {
            _user = userForm;
            _userName = userForm;
            _password = passwordForm;
            _email = emailForm;
        }

        public Boolean ReadUser() {//Verifica usuários para login
            var repository = new UserRepository(connection);
            var userDb = repository.Get(_user);


            if (_password == userDb.PasswordHash)
                return true;

            return false;
        }

        public int CreateUser() {//Cadastra usuário
            var repository = new UserRepository(connection);
            var createUser = repository.Create(_user,_userName,_password,_email);

            return createUser;//Retorno de linhas afetadas no bd
        }
    }
}

