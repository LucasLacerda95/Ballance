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
    public partial class F_Main : Form {

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


        public F_Main() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;//Trecho da internet para aplicar o border radius
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void F_Main_Load(object sender, EventArgs e) {
            
        }


        private void btn_Registrantions_Click(object sender, EventArgs e) {
            var menuStripRecords = new F_MenuStripRecords(this);
            DisplayForm(menuStripRecords, p_mainHeader);//Carrega o Menu Strip da tela de Cadastros
        }



        private void btn_Logoff_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void DisplayForm(Form form, Panel panel) {//Abre um novo formulário passando o painel e form
            panel.Controls.Remove(form);
            form.TopLevel = false;
            form.Visible = true;
            panel.Controls.Add(form);
        }

        public void CloseForm(Form form) {//Fecha o formulário para que o painel possa ser populado novamente
            p_mainBody.Controls.Remove(form);
        }

        private void btn_Transactions_Click(object sender, EventArgs e) {
            var f_NewRelease = new F_NewRelease();
            DisplayForm(f_NewRelease, p_mainBody);
        }
    }
}
