using AirSystem.Models;
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
        public frmLogin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            new frmNovoUsuario().ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            /*if (tBoxUser.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite o usuário.", "Erro");
            }
            else
            {
                MessageBox.Show("Bem Vindo", "Entrada");
                new frmPrincipalAdmin().ShowDialog();

            }*/

            Usuario usuario = new Usuario();

            //TODO: Fazer o If Puxar do Banco de Dados. E validar, pelo nome, se é admin ou não            
            if (tBoxUser.Text == usuario.name)
            {
                MessageBox.Show($"Bem Vindo, {usuario.name}", "Entrada");
                new frmPrincipalAdmin().ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show($"Bem Vindo, {usuario.name}", "Entrada");
                new frmPrincipalUser().ShowDialog();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {          
                this.Close();
                Application.Exit();           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
