namespace Ballance {
    partial class F_Login {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p_LoginForms = new System.Windows.Forms.Panel();
            this.ll_NewAccount = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p_LoginForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 329);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ballance.Properties.Resources.balance_Logo_G2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // p_LoginForms
            // 
            this.p_LoginForms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p_LoginForms.Controls.Add(this.ll_NewAccount);
            this.p_LoginForms.Controls.Add(this.checkBox1);
            this.p_LoginForms.Controls.Add(this.btn_Cancel);
            this.p_LoginForms.Controls.Add(this.btn_login);
            this.p_LoginForms.Controls.Add(this.tb_password);
            this.p_LoginForms.Controls.Add(this.tb_user);
            this.p_LoginForms.Controls.Add(this.label2);
            this.p_LoginForms.Controls.Add(this.label1);
            this.p_LoginForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_LoginForms.Location = new System.Drawing.Point(235, 0);
            this.p_LoginForms.Name = "p_LoginForms";
            this.p_LoginForms.Size = new System.Drawing.Size(291, 329);
            this.p_LoginForms.TabIndex = 5;
            // 
            // ll_NewAccount
            // 
            this.ll_NewAccount.ActiveLinkColor = System.Drawing.Color.Black;
            this.ll_NewAccount.AutoSize = true;
            this.ll_NewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ll_NewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_NewAccount.LinkColor = System.Drawing.Color.Black;
            this.ll_NewAccount.Location = new System.Drawing.Point(214, 214);
            this.ll_NewAccount.Name = "ll_NewAccount";
            this.ll_NewAccount.Size = new System.Drawing.Size(63, 13);
            this.ll_NewAccount.TabIndex = 31;
            this.ll_NewAccount.TabStop = true;
            this.ll_NewAccount.Text = "Nova Conta";
            this.ll_NewAccount.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ll_NewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_NewAccount_LinkClicked_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(50, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Relembre-me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(33, 287);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(106, 31);
            this.btn_Cancel.TabIndex = 29;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(159, 287);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(106, 31);
            this.btn_login.TabIndex = 30;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(50, 163);
            this.tb_password.Margin = new System.Windows.Forms.Padding(5);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(188, 23);
            this.tb_password.TabIndex = 27;
            // 
            // tb_user
            // 
            this.tb_user.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(50, 101);
            this.tb_user.Margin = new System.Windows.Forms.Padding(5);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(188, 23);
            this.tb_user.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Usuário";
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(526, 329);
            this.Controls.Add(this.p_LoginForms);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p_LoginForms.ResumeLayout(false);
            this.p_LoginForms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel p_LoginForms;
        private System.Windows.Forms.LinkLabel ll_NewAccount;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

