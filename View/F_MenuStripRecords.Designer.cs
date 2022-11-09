namespace Ballance.View {
    partial class F_MenuStripRecords {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ms_RegistrationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_CategoriesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_RegistrationMenu,
            this.ms_CategoriesMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(309, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ms_RegistrationMenu
            // 
            this.ms_RegistrationMenu.Name = "ms_RegistrationMenu";
            this.ms_RegistrationMenu.Size = new System.Drawing.Size(56, 22);
            this.ms_RegistrationMenu.Text = "Contas";
            this.ms_RegistrationMenu.Click += new System.EventHandler(this.ms_RegistrationMenu_Click);
            // 
            // ms_CategoriesMenu
            // 
            this.ms_CategoriesMenu.Name = "ms_CategoriesMenu";
            this.ms_CategoriesMenu.Size = new System.Drawing.Size(75, 22);
            this.ms_CategoriesMenu.Text = "Categorias";
            this.ms_CategoriesMenu.Click += new System.EventHandler(this.ms_CategoriesMenu_Click);
            // 
            // F_MenuStripRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 36);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_MenuStripRecords";
            this.Text = "F_MenuStripRecords";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ms_RegistrationMenu;
        private System.Windows.Forms.ToolStripMenuItem ms_CategoriesMenu;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}