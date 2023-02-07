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
    public partial class funcionarios : Form
    {
        public funcionarios()
        {
            InitializeComponent();
        }


        Conexaobd bd = new Conexaobd();
        string sql;
        DateTime data;


        public void limpar()
        {
            txtcidade.Clear();
            txtcpf.Clear();
            txtemail.Clear();
            txtendereço.Clear();
            txtnome.Clear();
            txtnumero.Clear();
            txttelefone.Clear();
            txtuf.Clear();
            cbxsexo.SelectedIndex = -1;
            dtpdata.Text = DateTime.Now.ToString();


        }

        public void listar()
        {
            sql = "select * from funcionarios";
            dtglistar.DataSource = bd.consultarTabelas(sql);
        }

    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            painel cadpainel = new painel();
            cadpainel.ShowDialog();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            painel cadpainel = new painel();
            cadpainel.ShowDialog();
            this.Visible = true;
        }

        private void funcionarios_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from funcionarios where cpf ='{0}'", txtcpf.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Dados do Funcionário excluído com sucesso!!", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            listar();
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcpf.Text == "")
            {
                MessageBox.Show("Insira o CPF para proseguir!", "Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtnome.Text == "")
            {
                MessageBox.Show("Insira o nome para proseguir!", "Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtsetor.Text == "")
            {
                MessageBox.Show("Insira o setor para proseguir!", "Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                data = DateTime.Parse(dtpdata.Text);

                sql = string.Format("insert into funcionarios values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')"
                    , txtnome.Text, txtcpf.Text, data.ToString("yyyy-MM-dd"), txtendereço.Text, txtnumero.Text, txtcidade.Text, txtuf.Text, cbxsexo.Text, txtsetor.Text, txtemail.Text, txttelefone.Text);
                bd.AlterarTabelas(sql);
                MessageBox.Show("Funcionario inserido com sucesso!!!", "Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
                listar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from funcionarios where nome = '{0}' or cpf = '{1}'", txtnome.Text, txtcpf.Text);
            buscar = bd.consultarTabelas(sql);
            if (buscar.Rows.Count > 0)
            {
                txtnome.Text = buscar.Rows[0]["nome"].ToString();
                txtcpf.Text = buscar.Rows[0]["cpf"].ToString();
                dtpdata.Text = buscar.Rows[0]["data_nascimento"].ToString();
                txtendereço.Text = buscar.Rows[0]["endereco"].ToString();
                txtnumero.Text = buscar.Rows[0]["numero"].ToString();
                txtcidade.Text = buscar.Rows[0]["cidade"].ToString();
                txtuf.Text = buscar.Rows[0]["uf"].ToString();
                cbxsexo.Text = buscar.Rows[0]["sexo"].ToString();
                txtemail.Text = buscar.Rows[0]["email"].ToString();
                txttelefone.Text = buscar.Rows[0]["telefone"].ToString();

                listar();
            }
            else
            {
                MessageBox.Show("Cliente não está cadastrado no sistema !!!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data = DateTime.Parse(dtpdata.Text);
            sql = string.Format("update funcionarios set nome='{0}',data_nascimento='{2}',endereco='{3}',numero='{4}',cidade='{5}',uf ='{6}',sexo='{7}',setor='{8}',email='{9}',telefone='{10}' where cpf = '{1}'"
          , txtnome.Text, txtcpf.Text, data.ToString("yyyy-MM-dd"), txtendereço.Text, txtnumero.Text, txtcidade.Text, txtuf.Text, cbxsexo.Text, txtsetor.Text, txtemail.Text, txttelefone.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Funcionário alterado com sucesso!!", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            listar();
        }

        private void imgempresarial_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            painel cadpainel = new painel();
            cadpainel.ShowDialog();
            this.Visible = true;
        }

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
