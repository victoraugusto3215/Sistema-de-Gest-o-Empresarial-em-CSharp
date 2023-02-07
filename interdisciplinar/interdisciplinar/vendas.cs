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
    public partial class vendas : Form
    {
        public vendas()
        {
            InitializeComponent();
        }

        Conexaobd bd  = new Conexaobd();
        string sql;
        DateTime data;
        double valor;
   
        public void Limpar()
        {
            txt_codigo.Clear();
            txtnome.Clear();
            txt_codigocliente.Clear();
            txtvalor.Clear();
            cbxpagamento.SelectedIndex = -1;
            dtpdata.Text = DateTime.Now.ToString();
        }

        public void listar()
        {
            sql = "select * from vendas";
            dtglistar.DataSource = bd.consultarTabelas(sql);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            painel cadpainel = new painel();
            cadpainel.ShowDialog();
            this.Visible = true;
        }

        private void imgempresarial_Click(object sender, EventArgs e)
        {

        }

        private void vendas_Load(object sender, EventArgs e)
        {

        }

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnconcluir_Click(object sender, EventArgs e)
        {


            if (txt_codigocliente.Text == "")
            {
                MessageBox.Show("Por favor, insira o codigo do cliente para prosseguir!", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (txtvalor.Text == "")
            {
                MessageBox.Show("Por favor, insira um valor para prosseguir!", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtnome.Text == "")
            {
                MessageBox.Show("Por favor insira o nome da venda para proseguir!", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
            else
            {

                valor = double.Parse(txtvalor.Text);

                data = DateTime.Parse(dtpdata.Text);
                sql = string.Format("insert into vendas values(null,'{0}','{1}','{2}','{3}','{4}')",
                    txtnome.Text, valor.ToString("00.00"), data.ToString("yyyy-MM-dd"), txt_codigocliente.Text, cbxpagamento.Text);

                bd.AlterarTabelas(sql);
                MessageBox.Show("Venda cadastrada com sucesso!", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                listar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from vendas where nome = '{0}' or data_venda = '{1}' or codigo = '{2}'", txtnome.Text, data, txt_codigo.Text);
            buscar = bd.consultarTabelas(sql);
            if (buscar.Rows.Count > 0)
            {
                txtnome.Text = buscar.Rows[0]["nome"].ToString();
                dtpdata.Text = buscar.Rows[0]["data_venda"].ToString();
                txtvalor.Text = buscar.Rows[0]["valor"].ToString();
                txt_codigo.Text = buscar.Rows[0]["codigo"].ToString();
                cbxpagamento.Text = buscar.Rows[0]["forma_pagamendo"].ToString();

                listar();
            }

            else
            {
                MessageBox.Show("Venda não enconhtrada!", "Buscar Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = string.Format("update vendas set nome = '{1}', valor = '{2}',data_venda = '{3}', clientes_codigo = '{4}', forma_pagamendo = '{4}' where codigo = '{0}'"
                 , txt_codigo.Text, txtnome.Text, txtvalor.Text, dtpdata.Text,txt_codigocliente.Text,cbxpagamento.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Alteração realizada com sucesso!", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from vendas where codigo = '{0}'", txt_codigo.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Venda excluida com sucesso!", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            listar();
        }


        

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
