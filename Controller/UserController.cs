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
        public Boolean _access = false;
        



        public UserController(string userForm, string userNameForm, string emailForm, string passwordForm) {
            _user = userForm;
            _userName = userForm;
            _email = emailForm;
            _password = passwordForm;
        }

        public UserController(string user, string password) {
            _user = user;
            _password = password;//Veio do FOrm


            var repository = new UserRepository(connection);
            var item = repository.Get(_user);
            _access = ReadUser(item);
        }



        public Boolean ReadUser(User item) {//Verifica usuários para login


            if (item.user_Name == _user && item.PasswordHash == _password) {
                _access = true;
                return _access;
            }

            return _access;

        }

        public int CreateUser() {//Cadastra usuário
            var repository = new UserRepository(connection);
            var createUser = repository.Create(_user,_userName,_password,_email);

            return createUser;//Retorno de linhas afetadas no bd
        }
    }
}

