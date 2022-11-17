using Ballance.Controller;
using Ballance.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballance.View {
    public partial class F_NewAccount : Form {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // width of ellipse
          int nHeightEllipse // height of ellipse
      );


        public F_NewAccount() {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;//Trecho da internet para aplicar o border radius
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void F_NewAccount_Load(object sender, EventArgs e) {

        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e) {
            string user, userName, password, email;

            user = tb_user.Text;
            userName = tb_userName.Text;
            password = tb_password.Text;
            email = tb_email.Text;

            var controller = new UserController(user, userName, password, email);
            var rows = controller.CreateUser();

            if(rows > 0) {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                Close();
            } else {
                MessageBox.Show("Erro ao cadastrar usuário!");
            }
        }
    }
}
