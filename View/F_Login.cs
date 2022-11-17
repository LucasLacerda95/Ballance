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
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace Ballance {
    public partial class F_Login : Form {

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

        public F_Login() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;//Trecho da internet para aplicar o border radius
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }


        private void ll_NewAccount_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e) {
            var f_NewAccount = new F_NewAccount();
            f_NewAccount.ShowDialog();
            //p_LoginForms.Controls.Add(f_NewAccount);
        }


        private void btn_login_Click(object sender, EventArgs e) {
            string user = tb_user.Text;
            string password = tb_password.Text;


            var controller = new UserController(user, password);
            var access = controller._access;

            if (access == true) {

                var form = new F_Main();
                form.Closed += (s, args) => this.Close();
                form.Show();//Depois entender este método do stackoverflow

            } else {
                MessageBox.Show("Dados de acesso inválidos.", "Oops..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_password.Clear();
                tb_password.Focus();
            }
        }


        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
