using Ballance.Controller;
using Ballance.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ballance {
    public partial class F_Login : Form {
        public F_Login() {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e) {
            string user = tb_user.Text;
            string password = tb_password.Text;

            if (user == "" || password == "") {
                MessageBox.Show("Usuário ou senha inválidos !");
                return;
            }

            var userController = new LoginController(user, password);
            

            
        }

    }
}
