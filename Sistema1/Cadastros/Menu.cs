using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastros
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnFuncinario_Click(object sender, EventArgs e)
        {
            frmFuncinarios fFuncinarios = new frmFuncinarios();
            fFuncinarios.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes fClientes = new frmClientes();
            fClientes.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
