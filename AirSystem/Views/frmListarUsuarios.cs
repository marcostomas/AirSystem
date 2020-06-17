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
    public partial class frmListarUsuarios : Form
    {
        UsuarioRepository repository = new UsuarioRepository();
        Usuario usuario = new Usuario();

        public frmListarUsuarios()
        {
            InitializeComponent();
        }

        private void frmListarUsuarios_Load(object sender, EventArgs e)
        {

            if (frmLogin.language == 0)
            {
                //Labels
                lblNameFilter.Text = "Nome:";
                lblName.Text = "Nome:";
                lblSurname.Text = "Sobrenome:";
                lblAddress.Text = "Endereço:";
                lblNumber.Text = "Número:";
                lblBirth.Text = "Data de Nascimento:";
                lblUser.Text = "Usuário:";
                lblPassword.Text = "Senha:";
                lblConfirmPassword.Text = "Confirmar Senha:";

                //Botões
                btnChangePicture.Text = "Alterar Foto";
                btnDeletePicture.Text = "Deletar Foto";
                btnAdd.Text = "Adicionar Usuário";
                btnEditUser.Text = "Alterar Usuário";
                btnDeleteUser.Text = "Deletar Usuário";
            }
            else
            {
                //Labels
                lblNameFilter.Text = "Name:";
                lblName.Text = "Name:";
                lblSurname.Text = "Surname:";
                lblAddress.Text = "Address:";
                lblNumber.Text = "Number:";
                lblBirth.Text = "Birth Date:";
                lblUser.Text = "User:";
                lblPassword.Text = "Password:";
                lblConfirmPassword.Text = "Confirm Password:";

                //Botões
                btnChangePicture.Text = "Change Photo";
                btnDeletePicture.Text = "Delete Photo";
                btnAdd.Text = "Add User";
                btnEditUser.Text = "Edit User";
                btnDeleteUser.Text = "Delete User";
            }
            carregaLista();
        }

        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repository.buscarTodos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario
            {
                admin = false,
                name = textBoxName.Text,
                surname = textBoxSurname.Text,
                address = textBoxAddress.Text,
                address2 = textBoxNumber.Text,
                username = textBoxUser.Text,
                password = textBoxPassword.Text

            };

            if (textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                //repository.adicionar(usuario);
                usuarios.Add(usuario);
                MessageBox.Show("Os dados foram salvos.", "Aviso",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("As senhas não conferem. Os dados não foram cadastrados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];

            string Nome = linha.Cells[1].Value.ToString();
            string Sobrenome = linha.Cells[2].Value.ToString();
            string Endereco = linha.Cells[3].Value.ToString();
            string DataNascimento = linha.Cells[4].Value.ToString();
            string Usuario = linha.Cells[6].Value.ToString();
            string Senha = linha.Cells[7].Value.ToString();
            string Numero = linha.Cells[5].Value.ToString();

            int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());

            usuario.ID = codigo;
            usuario.name = Nome;
            usuario.surname = Sobrenome;
            usuario.address = Endereco;
            usuario.birthDate = Convert.ToDateTime(DataNascimento);
            usuario.address2 = Numero;
            usuario.username = Usuario;
            usuario.password = Senha;


            textBoxName.Text = usuario.name;
            textBoxSurname.Text = usuario.surname;
            textBoxAddress.Text = usuario.address;
            dateTimePicker1.Value = usuario.birthDate;
            textBoxNumber.Text = usuario.address2.ToString();
            textBoxUser.Text = usuario.username;
            textBoxPassword.Text = usuario.password;
        }

        private void btnChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnDeletePicture_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (frmLogin.language == 1)
            {
                DialogResult dr = MessageBox.Show("Deleting user. There's no back. Select Sim to Confirm", "Warning"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(usuario.ID.ToString());

                    repository.deletar(ID);

                    carregaLista();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Excluindo o usuário. Esta ação é permanente. Selecione Sim para confirmar?", "Atenção"
                       , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(usuario.ID.ToString());

                    repository.deletar(ID);

                    carregaLista();
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            new frmNovoUsuario(usuario).ShowDialog();

            carregaLista();
        }
    }
}
