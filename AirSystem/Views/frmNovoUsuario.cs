using AirSystem.Models;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //TODO: Address e Address2 não são obrigatórios. Arrumar
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
                    if (tBoxPassword == tBoxConfirmPassword)
                    {
                        repository.adicionar(usuario);
                        MessageBox.Show("Os dados foram salvos.","Aviso",
                         MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("As senhas não conferem. Os dados não foram cadastrados.","Aviso",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            if (MessageBox.Show("Deseja fechar o formulário?", "Fechando Formulário",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //TODO: Fazer Input_Leave e Input_Enter
        private void Input_Leave(object sender, EventArgs e)
        {
            picBoxUserPhoto.Visible = false;
        }

        private void Input_Enter(object sender, EventArgs e)
        {
            /*TextBox tbx = sender as TextBox;
            if (tbx != null)
            {
                picBoxUserPhoto.Location = new Point(tbx.Location.X - 5, tbx.Location.Y - 5);
                picBoxUserPhoto.Size = new Size(tbx.Size.Width + 10, tbx.Size.Height + 10);
                picBoxUserPhoto.Visible = true;
            }
            else
            {

                DateTimePicker dtp = sender as DateTimePicker;

                if (dtp != null)
                {
                    picBoxUserPhoto.Location = new Point(dtp.Location.X - 5, dtp.Location.Y - 5);
                    picBoxUserPhoto.Size = new Size(dtp.Size.Width + 10, dtp.Size.Height + 10);
                    picBoxUserPhoto.Visible = true;
                }

            }*/
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Carregar a imagem selecionada no picturebox
                picBoxUserPhoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            picBoxUserPhoto.Image = null;
        }

       
    }
}
