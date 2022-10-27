namespace Ballance.View {
    partial class F_Main {
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
            this.p_mainMenu = new System.Windows.Forms.Panel();
            this.p_mainHeader = new System.Windows.Forms.Panel();
            this.p_mainBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.p_mainMenu.SuspendLayout();
            this.p_mainBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_mainMenu
            // 
            this.p_mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.p_mainMenu.Controls.Add(this.panel1);
            this.p_mainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_mainMenu.Location = new System.Drawing.Point(0, 0);
            this.p_mainMenu.Name = "p_mainMenu";
            this.p_mainMenu.Size = new System.Drawing.Size(168, 661);
            this.p_mainMenu.TabIndex = 0;
            // 
            // p_mainHeader
            // 
            this.p_mainHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p_mainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_mainHeader.Location = new System.Drawing.Point(168, 0);
            this.p_mainHeader.Name = "p_mainHeader";
            this.p_mainHeader.Size = new System.Drawing.Size(816, 46);
            this.p_mainHeader.TabIndex = 1;
            // 
            // p_mainBody
            // 
            this.p_mainBody.BackColor = System.Drawing.Color.White;
            this.p_mainBody.Controls.Add(this.label1);
            this.p_mainBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_mainBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_mainBody.Location = new System.Drawing.Point(168, 46);
            this.p_mainBody.Name = "p_mainBody";
            this.p_mainBody.Size = new System.Drawing.Size(816, 615);
            this.p_mainBody.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 83);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo !!";
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.p_mainBody);
            this.Controls.Add(this.p_mainHeader);
            this.Controls.Add(this.p_mainMenu);
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ballance";
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.p_mainMenu.ResumeLayout(false);
            this.p_mainBody.ResumeLayout(false);
            this.p_mainBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_mainMenu;
        private System.Windows.Forms.Panel p_mainHeader;
        private System.Windows.Forms.Panel p_mainBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}