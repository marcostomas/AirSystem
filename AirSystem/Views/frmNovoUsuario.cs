using AirSystem.Models;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmNovoUsuario : Form
    {
        private Usuario usuario = null;

        public frmNovoUsuario()
        {
            InitializeComponent();
        }

        public frmNovoUsuario(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }

        private void frmNovoUsuario_Load(object sender, EventArgs e)
        {

            if (frmLogin.language == 0)
            {
                lblName.Text = "Nome";
                lblSurname.Text = "Sobrenome";
                lblAddress.Text = "Endereço";
                lblAddress2.Text = "Número";
                lblBirth.Text = "Data de Nascimento";
                lblUser.Text = "Usuário";
                lblPassword.Text = "Senha";
                lblConfirmPassword.Text = "Confirmar Senha";
                btnChange.Text = "Alterar";
                btnDelete.Text = "Deletar";
                checkBoxAdmin.Text = "É Admin";
                btnSignUp.Text = "Cadastrar";
            }
            else
            {
                lblName.Text = "Name";
                lblSurname.Text = "Surname";
                lblAddress.Text = "Address";
                lblAddress2.Text = "Number";
                lblBirth.Text = "Birth Date";
                lblUser.Text = "User";
                lblPassword.Text = "Password";
                lblConfirmPassword.Text = "Confirm Password";
                btnChange.Text = "Change";
                btnDelete.Text = "Delete";
                checkBoxAdmin.Text = "It's Admin";
                btnSignUp.Text = "Sign Up";
            }
            
            
            if(usuario != null)
            {
                tBoxName.Text = usuario.name;
                tBoxSurname.Text = usuario.surname;
                tBoxAddress.Text = usuario.address;
                tBoxAddressNumber.Text = usuario.address2;
                tBoxUser.Text = usuario.username;
                tBoxPassword.Text = usuario.password;
            }
        }
        private bool isPasswordRight (string password)
        {
            if(password.Length >= 8)
            {
                string pattern = "[a-z]{1,}";

                if(Regex.IsMatch(password, pattern))
                {
                    pattern = "[A-Z]{1,}";

                    if(Regex.IsMatch(password, pattern))
                    {
                        pattern = "[0-9]{1,}";

                        if(Regex.IsMatch(password, pattern))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!Utils.temCamposVazio(this))
            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    Usuario usuario = new Usuario
                    {
                        //Se estiver marcado, admin é verdadeiro
                        admin = checkBoxAdmin.Checked ? true : false,
                        name = tBoxName.Text,
                        surname = tBoxSurname.Text,
                        address = tBoxAddress.Text,
                        address2 = tBoxAddressNumber.Text,
                        username = tBoxUser.Text,
                        password = tBoxPassword.Text
                    };

                    if (tBoxPassword.Text == tBoxConfirmPassword.Text && isPasswordRight(tBoxPassword.Text))
                    {
                        repository.adicionar(usuario);
                        MessageBox.Show("Os dados foram salvos.", "Aviso",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if(tBoxPassword.Text == tBoxConfirmPassword.Text)
                        {
                            MessageBox.Show("As senhas não atendem aos padrões de ter, no mínimo," +
                                "8 caracteres com, pelo menos: 1 Letra Minúscula, 1 Letra Maiúscula e 1 Número." +
                                "Os dados não foram cadastrados.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (isPasswordRight(tBoxPassword.Text))
                        {
                            MessageBox.Show("As senhas não conferem, mas atendem aos requisitos. " +
                                "Verifique e tente novamente. Os dados não foram cadastrados.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("As senhas não conferem e não atendem aos padrões de ter, no mínimo," +
                                "8 caracteres com, pelo menos: 1 Letra Minúscula, 1 Letra Maiúscula e 1 Número." +
                                "Os dados não foram cadastrados.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    this.usuario.name = tBoxName.Text;
                    this.usuario.surname = tBoxSurname.Text;
                    this.usuario.address = tBoxAddress.Text;
                    this.usuario.address2 = tBoxAddressNumber.Text;
                    this.usuario.username = tBoxUser.Text;
                    this.usuario.password = tBoxPassword.Text;

                    repository.editar(usuario);
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("Os campos obrigatórios não foram preenchidos",
                                "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }

        }

        private void frmNovoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(frmLogin.language == 0)
            {
                if (MessageBox.Show("Deseja fechar o formulário?", "Fechando Formulário",
                MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                if (MessageBox.Show("Do you want close this form?", "Closing Form",
                MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }
                
        private void Input_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.BackColor = Color.LightYellow;
                if (txt.Text == "")
                {
                    txt.Text = "Digite - " + txt.AccessibleName;
                }
            }
        }

        private void Input_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.BackColor = Color.White;
                string value = txt.Text;
                if (value.Substring(0,3) == "Digite - ")
                {
                    txt.Text = "";
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picBoxUserPhoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            picBoxUserPhoto.Image = null;
        }
    }
}
