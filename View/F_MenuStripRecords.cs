using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ballance.View {
    public partial class F_MenuStripRecords : Form {
        F_Main f_Main;
        Form form;

        public F_MenuStripRecords(F_Main f) {
            InitializeComponent();

            f_Main = f;
        }

        public void ms_RegistrationMenu_Click(object sender, EventArgs e) {
            f_Main.CloseForm(this.form);
            this.form = new F_AccountsRecords();//Instancia o formulário
            f_Main.DisplayForm(form, f_Main.p_mainBody);
        }

        public void ms_CategoriesMenu_Click(object sender, EventArgs e) {
            f_Main.CloseForm(this.form);
            this.form = new F_CategoriesRecords();
            f_Main.DisplayForm(form, f_Main.p_mainBody);
        }

        private void ms_UsersMenu_Click(object sender, EventArgs e) {

        }
    }
}
