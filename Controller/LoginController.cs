using Ballance.Model;
using Ballance.Model.DataModels;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballance.Controller {
    public class LoginController {
        private string _user, _password;

        public LoginController() {
           
        }

        public void getUserForm(string user, string password) {
            _user = user;
            _password = password;
        }

        public string setUserForm() {
            return _user;
        }
    }
}
