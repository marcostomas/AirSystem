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
    public partial class frmPrincipalAdmin : Form
    {
        public frmPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            new frmListarUsuarios().ShowDialog();
        }

        private void frmPrincipalAdmin_Load(object sender, EventArgs e)
        {
            if (frmLogin.language == 0)
            {
                btnListarUsuarios.Text = "Lista de Usuários";
                button2.Text = "Lista de Aviões";
                button3.Text = "Gerenciar Avião";
                button4.Text = "Gerenciar Companhia";
                button5.Text = "Gerenciar Relatórios";
            }
            else
            {
                btnListarUsuarios.Text = "User List";
                button2.Text = "Airplane List";
                button3.Text = "Manage Aircraft";
                button4.Text = "Manage Company";
                button5.Text = "Manage Reports";
            }
        }
    }
}
