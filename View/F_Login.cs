using Ballance.Controller;
using Ballance.Model;
using Ballance.Model.DataModels;
using Ballance.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Ballance {
    public partial class F_Login : Form {
        //F_Main formMain;
        

        public F_Login() {
            InitializeComponent();

            //formMain = form;//Recebendo formulário da tela principal para manipulá-lo
        }


        private void btn_login_Click(object sender, EventArgs e) {
            string user = tb_user.Text;
            string password = tb_password.Text;


            var controller = new UserController(user, password);
            var access = controller.ReadUser();

            if (access == true) {

                this.Hide();
                var form = new F_Main();
                form.Closed += (s, args) => this.Close();
                form.Show();//Depois entender este método do stackoverflow

            } else {
                MessageBox.Show("Dados de acesso inválidos.", "Oops..", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                tb_user.Clear();
                tb_password.Clear();
                tb_user.Focus();
            }
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
