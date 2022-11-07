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

        public F_Main() {
            InitializeComponent();
        }

        private void F_Main_Load(object sender, EventArgs e) {
            

        }

        private F_AccountsRecords fRecords = null;
        private void btn_Registrantions_Click(object sender, EventArgs e) {

           this.fRecords = new F_AccountsRecords();
           this.fRecords.TopLevel = false;
           this.fRecords.Visible = true;
            this.fRecords.Width = p_mainBody.Width;
            this.fRecords.Height = p_mainBody.Height;
            p_mainBody.Controls.Add(this.fRecords);
        }

        private void btn_Logoff_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
