namespace AirSystem.Views
{
    partial class frmNovoUsuario
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxAddress = new System.Windows.Forms.TextBox();
            this.tBoxUser = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.tBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.tBoxSurname = new System.Windows.Forms.TextBox();
            this.tBoxAddressNumber = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.picBoxUserPhoto = new System.Windows.Forms.PictureBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(24, 79);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Endereço:";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(25, 116);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(104, 13);
            this.lblBirth.TabIndex = 2;
            this.lblBirth.Text = "Data de Nascimento";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(25, 157);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuário";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 196);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(38, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Senha";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(22, 235);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(85, 13);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Confirmar Senha";
            // 
            // tBoxName
            // 
            this.tBoxName.AccessibleName = "Nome";
            this.tBoxName.Location = new System.Drawing.Point(80, 38);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(172, 20);
            this.tBoxName.TabIndex = 6;
            this.tBoxName.Enter += new System.EventHandler(this.Input_Enter);
            this.tBoxName.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // tBoxAddress
            // 
            this.tBoxAddress.AccessibleName = "Endereço";
            this.tBoxAddress.Location = new System.Drawing.Point(92, 76);
            this.tBoxAddress.Name = "tBoxAddress";
            this.tBoxAddress.Size = new System.Drawing.Size(260, 20);
            this.tBoxAddress.TabIndex = 7;
            this.tBoxAddress.Enter += new System.EventHandler(this.Input_Enter);
            this.tBoxAddress.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // tBoxUser
            // 
            this.tBoxUser.AccessibleName = "Usuário";
            this.tBoxUser.Location = new System.Drawing.Point(162, 154);
            this.tBoxUser.Name = "tBoxUser";
            this.tBoxUser.Size = new System.Drawing.Size(212, 20);
            this.tBoxUser.TabIndex = 9;
            this.tBoxUser.Enter += new System.EventHandler(this.Input_Enter);
            this.tBoxUser.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.AccessibleName = "";
            this.tBoxPassword.Location = new System.Drawing.Point(162, 193);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(212, 20);
            this.tBoxPassword.TabIndex = 10;
            this.tBoxPassword.UseSystemPasswordChar = true;
            // 
            // tBoxConfirmPassword
            // 
            this.tBoxConfirmPassword.AccessibleName = "";
            this.tBoxConfirmPassword.Location = new System.Drawing.Point(162, 232);
            this.tBoxConfirmPassword.Name = "tBoxConfirmPassword";
            this.tBoxConfirmPassword.Size = new System.Drawing.Size(212, 20);
            this.tBoxConfirmPassword.TabIndex = 11;
            this.tBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // tBoxSurname
            // 
            this.tBoxSurname.AccessibleName = "Sobrenome";
            this.tBoxSurname.Location = new System.Drawing.Point(365, 38);
            this.tBoxSurname.Name = "tBoxSurname";
            this.tBoxSurname.Size = new System.Drawing.Size(195, 20);
            this.tBoxSurname.TabIndex = 12;
            this.tBoxSurname.Enter += new System.EventHandler(this.Input_Enter);
            this.tBoxSurname.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // tBoxAddressNumber
            // 
            this.tBoxAddressNumber.AccessibleName = "Número de Residência";
            this.tBoxAddressNumber.Location = new System.Drawing.Point(434, 76);
            this.tBoxAddressNumber.Name = "tBoxAddressNumber";
            this.tBoxAddressNumber.Size = new System.Drawing.Size(126, 20);
            this.tBoxAddressNumber.TabIndex = 13;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(162, 350);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(212, 32);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "Cadastrar";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // picBoxUserPhoto
            // 
            this.picBoxUserPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxUserPhoto.Location = new System.Drawing.Point(590, 48);
            this.picBoxUserPhoto.Name = "picBoxUserPhoto";
            this.picBoxUserPhoto.Size = new System.Drawing.Size(188, 160);
            this.picBoxUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUserPhoto.TabIndex = 15;
            this.picBoxUserPhoto.TabStop = false;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(590, 228);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 25);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Alterar";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(701, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 27);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(590, 277);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(65, 17);
            this.checkBoxAdmin.TabIndex = 18;
            this.checkBoxAdmin.Text = "É Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Checked = false;
            this.dateTimeBirth.Location = new System.Drawing.Point(162, 110);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(212, 20);
            this.dateTimeBirth.TabIndex = 19;
            this.dateTimeBirth.Enter += new System.EventHandler(this.Input_Enter);
            this.dateTimeBirth.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(288, 41);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 13);
            this.lblSurname.TabIndex = 20;
            this.lblSurname.Text = "Sobrenome:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(381, 79);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(47, 13);
            this.lblAddress2.TabIndex = 21;
            this.lblAddress2.Text = "Número:";
            // 
            // frmNovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.dateTimeBirth);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.picBoxUserPhoto);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.tBoxAddressNumber);
            this.Controls.Add(this.tBoxSurname);
            this.Controls.Add(this.tBoxConfirmPassword);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxUser);
            this.Controls.Add(this.tBoxAddress);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Name = "frmNovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário - AirSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNovoUsuario_FormClosing);
            this.Load += new System.EventHandler(this.frmNovoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxAddress;
        private System.Windows.Forms.TextBox tBoxUser;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.TextBox tBoxConfirmPassword;
        private System.Windows.Forms.TextBox tBoxSurname;
        private System.Windows.Forms.TextBox tBoxAddressNumber;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox picBoxUserPhoto;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAddress2;
    }
}