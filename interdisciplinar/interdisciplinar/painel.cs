using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interdisciplinar
{
    public partial class painel : Form
    {
        public painel()
        {
            InitializeComponent();
        }

        private void btnfuncionários_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            funcionarios cadfuncionarios = new funcionarios();
            cadfuncionarios.ShowDialog();
            this.Visible = true;
        }

        private void btnfinanceiro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Financeiro cadfinanceiro = new Financeiro();
            cadfinanceiro.ShowDialog();
            this.Visible = true;
        }

        private void btnvendas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            vendas cadvendas = new vendas();
            cadvendas.ShowDialog();
            this.Visible = true;
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            clientes cadclientes = new clientes();
            cadclientes.ShowDialog();
            this.Visible = true;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login cadlogin = new login();
            cadlogin.ShowDialog();
            this.Visible = true;
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cadastro cadcadastro = new cadastro();
            cadcadastro.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            funcionarios cadfuncionarios = new funcionarios();
            cadfuncionarios.ShowDialog();
            this.Visible = true;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Financeiro cadfinanceiro = new Financeiro();
            cadfinanceiro.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            vendas cadvendas = new vendas();
            cadvendas.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            clientes cadclientes = new clientes();
            cadclientes.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cadastro cadcadastro = new cadastro();
            cadcadastro.ShowDialog();
            this.Visible = true;
        }

        private void imgempresarial_Click(object sender, EventArgs e)
        {

        }
    }
}
