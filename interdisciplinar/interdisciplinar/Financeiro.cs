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
    public partial class Financeiro : Form
    {
        public Financeiro()
        {
            InitializeComponent();
        }

        Conexaobd bd = new Conexaobd();
        string sql;
        DateTime emissao,vencimento;
        double valor;

        public void Limpar()
        {
            txt_codigo.Clear();
            txt_categoria.Clear();
            txt_titular.Clear();
            txtvalor.Clear();
            data_emissao.Text = DateTime.Now.ToString();
            data_vencimento.Text = DateTime.Now.ToString();
           txt_status.Clear();
        }

        public void listar()
        {
            sql = "select * from financeiro";
            dtglistar.DataSource = bd.consultarTabelas(sql);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            painel cadpainel = new painel();
            cadpainel.ShowDialog();
            this.Visible = true;
        }

        private void lblcategoria_Click(object sender, EventArgs e)
        {

        }

        private void lbltitular_Click(object sender, EventArgs e)
        {

        }

        private void lblemissao_Click(object sender, EventArgs e)
        {

        }

        private void Financeiro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            
            sql = string.Format("select * from financeiro where codigo = '{0}' or categoria = '{1}' or titular = '{2}' or emissao = '{3}' or data_vencimento = '{4}' or valor = '{5}' or status = '{6}'"
                , txt_codigo.Text, txt_categoria.Text, txt_titular.Text,data_emissao.Text,data_vencimento.Text,txtvalor.Text,txt_status.Text) ;
            buscar = bd.consultarTabelas(sql);
            if (buscar.Rows.Count > 0)
            {
                txt_codigo.Text = buscar.Rows[0]["codigo"].ToString();
                txt_categoria.Text = buscar.Rows[0]["categoria"].ToString();
                txt_titular.Text = buscar.Rows[0]["titular"].ToString();
                data_emissao.Text = buscar.Rows[0]["emissao"].ToString();
                data_vencimento.Text = buscar.Rows[0]["data_vencimento"].ToString();
                txtvalor.Text = buscar.Rows[0]["valor"].ToString();
                txt_status.Text = buscar.Rows[0]["status"].ToString();

                listar();
            }

            else
            {
                MessageBox.Show("Debito não enconhtrado!", "Debito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
            }
        }

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from financeiro where codigo = '{0}'", txt_codigo.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Debito excluido com sucesso!", "Debito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            listar();
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            sql = string.Format("update financeiro set categoria = '{1}', titular = '{2}', valor = '{3}', status = '{4}' where codigo = '{0}'"
                , txt_codigo.Text, txt_categoria.Text, txt_titular.Text, txtvalor.Text, txt_status.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Alteração realizada com sucesso!", "Debito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnconcluir_Click(object sender, EventArgs e)
        {
            if(txtvalor.Text == "")
            {
                MessageBox.Show("Por favor, insira um valor para prosseguir!", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_titular.Text == "")
            {
                MessageBox.Show("Por favor, insira o nome do Titular prosseguir!", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                valor = double.Parse(txtvalor.Text);
                emissao = DateTime.Parse(data_emissao.Text);
                vencimento = DateTime.Parse(data_vencimento.Text);


                sql = string.Format("insert into financeiro values(null,'{0}','{1}','{2}','{3}','{4}','{5}')",
                   txt_categoria.Text, txt_titular.Text, emissao.ToString("yyyy-MM-dd"), vencimento.ToString("yyyy-MM-dd"), valor.ToString("00.00"), txt_status.Text);


                bd.AlterarTabelas(sql);
                MessageBox.Show("Debito cadastrado com sucesso!", "Cadastrar Debito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                listar();
            }
        }
    }
}
