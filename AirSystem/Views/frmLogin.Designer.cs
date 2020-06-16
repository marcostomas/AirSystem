namespace AirSystem.Views
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.picBoxUserLock = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.tBoxUser = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cBoxLanguage = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEnterUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxUserLock
            // 
            this.picBoxUserLock.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUserLock.Image")));
            this.picBoxUserLock.Location = new System.Drawing.Point(30, 28);
            this.picBoxUserLock.Name = "picBoxUserLock";
            this.picBoxUserLock.Size = new System.Drawing.Size(374, 396);
            this.picBoxUserLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxUserLock.TabIndex = 0;
            this.picBoxUserLock.TabStop = false;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(453, 75);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(323, 93);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 1;
            this.picBoxLogo.TabStop = false;
            // 
            // tBoxUser
            // 
            this.tBoxUser.Location = new System.Drawing.Point(453, 230);
            this.tBoxUser.Name = "tBoxUser";
            this.tBoxUser.Size = new System.Drawing.Size(323, 20);
            this.tBoxUser.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(453, 301);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(321, 20);
            this.tBoxPassword.TabIndex = 3;
            this.tBoxPassword.UseSystemPasswordChar = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(458, 209);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 18);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Usuário";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(458, 280);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(50, 18);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Senha";
            // 
            // cBoxLanguage
            // 
            this.cBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLanguage.FormattingEnabled = true;
            this.cBoxLanguage.Items.AddRange(new object[] {
            "Português (PT-BR)",
            "English (EN-US)"});
            this.cBoxLanguage.Location = new System.Drawing.Point(457, 362);
            this.cBoxLanguage.Name = "cBoxLanguage";
            this.cBoxLanguage.Size = new System.Drawing.Size(193, 21);
            this.cBoxLanguage.TabIndex = 7;
            // 
            // btnEnter
            // 
            this.btnEnter.ForeColor = System.Drawing.Color.Black;
            this.btnEnter.Location = new System.Drawing.Point(458, 410);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Entrar Admin";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(712, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnNewUser.Location = new System.Drawing.Point(712, 360);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(85, 23);
            this.btnNewUser.TabIndex = 10;
            this.btnNewUser.Text = "Novo Usuário";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Location = new System.Drawing.Point(458, 341);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(52, 18);
            this.lblLanguage.TabIndex = 11;
            this.lblLanguage.Text = "Idioma";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(699, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 19);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEnterUser
            // 
            this.btnEnterUser.ForeColor = System.Drawing.Color.Black;
            this.btnEnterUser.Location = new System.Drawing.Point(566, 410);
            this.btnEnterUser.Name = "btnEnterUser";
            this.btnEnterUser.Size = new System.Drawing.Size(84, 23);
            this.btnEnterUser.TabIndex = 12;
            this.btnEnterUser.Text = "Entrar Usuário";
            this.btnEnterUser.UseVisualStyleBackColor = true;
            this.btnEnterUser.Click += new System.EventHandler(this.btnEnterUser_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.btnEnterUser);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cBoxLanguage);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxUser);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.picBoxUserLock);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - AirSystem";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxUserLock;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.TextBox tBoxUser;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cBoxLanguage;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEnterUser;
    }
}