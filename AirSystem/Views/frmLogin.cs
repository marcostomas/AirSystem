using AirSystem.Models;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmLogin : Form
    {
        UsuarioRepository usuarios = new UsuarioRepository();
        public static int language;
        
        public frmLogin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            language = cBoxLanguage.SelectedIndex;
            new frmNovoUsuario().ShowDialog();
        }

        /*public bool isAdmin(usuarios)
        {
            usuario = usuarios;
            
            if()
            {
                return true;
            }

            return false;
        }*/

        private void btnEnter_Click(object sender, EventArgs e)
        {
            language = cBoxLanguage.SelectedIndex;
            new frmPrincipalAdmin().ShowDialog();
            //List<Usuario> usuariosBuscados = usuarios.buscarTodos();

            //TODO: Fazer o If Puxar do Banco de Dados. E validar, pelo nome, se é admin ou não            
            /*if (tBoxUser.Equals(usuariosBuscados.name)&& isAdmin())
            {
                MessageBox.Show($"Bem Vindo, {usuariosBuscados.name}", "Entrada");
                new frmPrincipalAdmin().ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show($"Bem Vindo, {usuariosBuscados.name}", "Entrada");
                new frmPrincipalUser().ShowDialog();
                this.Close();
            }*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {          
                this.Close();
                Application.Exit();           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnEnterUser_Click(object sender, EventArgs e)
        {
            language = cBoxLanguage.SelectedIndex;
            new frmPrincipalUser().ShowDialog();
        }
    }
}
