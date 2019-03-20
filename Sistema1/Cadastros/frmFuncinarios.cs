using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastros
{
    public partial class frmFuncinarios : Form
    {
        public frmFuncinarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbnSolteiro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SalvarFuncinario(string nome, string estadoCivil)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema1\\funcinarios.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine();
            arquivo.WriteLine("Cadastro de Funcionário");
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("Estado Civil: " + estadoCivil);
            arquivo.WriteLine("_______________________________________________");
            arquivo.WriteLine();
            arquivo.Close();
            MessageBox.Show("Funcinário salvo com sucesso!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparFuncinario()
        {
            txtNome.Clear();
            rdbCasado.Checked = false;
            rdbSolteiro.Checked = false;
        }
             
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome, estadoCivil;
            nome = txtNome.Text;
            if (rdbCasado.Checked == true)
            {
                estadoCivil = "Casado(a)";
            }else if(rdbSolteiro.Checked == true)
            {
                estadoCivil = "Solteiro(a)";
            }
            else
            {
                MessageBox.Show("Escolha um estado civil");
                return;
            }
            SalvarFuncinario(nome, estadoCivil);
            LimparFuncinario();
        }
    }
}
