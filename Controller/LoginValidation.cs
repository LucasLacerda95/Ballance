using Ballance.Model;
using Ballance.Model.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballance.Controller {
    internal class LoginValidation {

        public LoginValidation(string user, string password) {
            var _user = user;
            var _password = password;

            if(_user == "" || _password == "") {
                MessageBox.Show("Usuário ou senha inválidos!");
                return;
            }
        }

    }
}
