using Ballance.Controller;
using Ballance.Model;
using Ballance.Model.DataModels;
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
                tb_user.Clear();
                tb_password.Clear();
                tb_user.Focus();
            }

            var controller = new UserController(user, password);
            var access = controller.ReadUser();

            if (access == true) {
                MessageBox.Show("Logado");
            } else{
                MessageBox.Show("Dados incorretos");
                tb_user.Clear();
                tb_password.Clear();
                tb_user.Focus();
            }
        }

    }
}
