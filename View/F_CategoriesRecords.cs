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
    public partial class F_CategoriesRecords : Form {
        public F_CategoriesRecords() {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e) {
            var f_AddCategory = new F_AddCategoryRecords {
                StartPosition = FormStartPosition.CenterParent
            };
            f_AddCategory.ShowDialog();
        }
    }
}
