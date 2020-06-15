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
        public frmListarUsuarios()
        {
            InitializeComponent();
        }

        private void frmListarUsuarios_Load(object sender, EventArgs e)
        {

            if (frmLogin.language == 0)
            {
                //Labels
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
            //Define o número de colunas
            dataGridView1.ColumnCount = 3;
            
            //Define se os header estão visíveis
            dataGridView1.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];

            int ID = Convert.ToInt32(linha.Cells[0].Value.ToString());
            string Nome = linha.Cells[1].Value.ToString();
            string Sobrenome = linha.Cells[2].Value.ToString();

            Usuario usuario = new Usuario
            {
                ID = ID,
                name = Nome,
                surname = Sobrenome,
            };

            //TODO: Corrigir. Não chamr a tela
            new frmNovoUsuario(usuario).ShowDialog();
            //chama o método para carregar o datagrid
            carregaLista();
        }
    }
}
