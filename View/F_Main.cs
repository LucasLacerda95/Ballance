using Ballance.View.Records;
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
    public partial class F_Main : Form {
        public F_AccountsRecords form = null;
        public F_CategoriesRecords form2 = null;
        public F_MenuStripRecords menuRecords = null;

        public F_Main() {
            InitializeComponent();
            
        }

        private void F_Main_Load(object sender, EventArgs e) {
            
        }


        private void btn_Registrantions_Click(object sender, EventArgs e) {
            displayMenuStripRecords();
            displayFormAccountsRecords();

        }

        private void btn_Transactions_Click(object sender, EventArgs e) {
            
        }

        private void displayFormAccountsRecords() {
            p_mainBody.Controls.Remove(this.form);
            this.form = new F_AccountsRecords();
            this.form.TopLevel = false;
            this.form.Visible = true;
            p_mainBody.Controls.Add(this.form);
        }


        public void displayCategoriesRecords() {
            p_mainBody.Controls.Remove(this.form);
            this.form2 = new F_CategoriesRecords();
            this.form2.TopLevel = false;
            this.form2.Visible = true; 
            p_mainBody.Controls.Add(this.form2);
        }

        private void displayMenuStripRecords() {
            p_mainHeader.Controls.Remove(this.form);
            this.menuRecords = new F_MenuStripRecords();
            this.menuRecords.TopLevel = false;
            this.menuRecords.Visible = true;
            p_mainHeader.Controls.Add(this.menuRecords);
        }

        private void btn_Logoff_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
