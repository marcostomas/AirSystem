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
    public partial class frmPrincipalUser : Form
    {
        public frmPrincipalUser()
        {
            InitializeComponent();
        }

        private void frmPrincipalUser_Load(object sender, EventArgs e)
        {
            if (frmLogin.language == 0)
            {
                button1.Text = "Lista de Aviões";
                button2.Text = "Gerenciar Companhia";
                button3.Text = "Gerenciar Avião";
                button4.Text = "Gerenciar Relatórios";
            }
            else
            {
                button1.Text = "Airplane List";
                button2.Text = "Manage Company";
                button3.Text = "Manage Aircraft";
                button4.Text = "Manage Reports";
            }
        }
    }
}
