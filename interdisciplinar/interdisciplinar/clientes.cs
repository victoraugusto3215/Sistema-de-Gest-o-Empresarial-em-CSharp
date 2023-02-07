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
    public partial class clientes : Form
    {
        public clientes()
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
            sql = "select * from clientes";
            dtglistar.DataSource = bd.consultarTabelas(sql);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            painel cadpainel = new painel();
            cadpainel.ShowDialog();
            this.Visible = true;
        }

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientes_Load(object sender, EventArgs e)
        {

        }

        private void txtcpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from clientes where nome = '{0}' or cpf = '{1}'",  txtnome.Text, txtcpf.Text);
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

            }
            else
            {
                MessageBox.Show("Cliente não está cadastrado no sistema !!!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcpf.Text == "")
            {
                MessageBox.Show("Insira o CPF para proseguir!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtnome.Text == "")
            {
                MessageBox.Show("Insira o nome para proseguir!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtendereço.Text == "")
            {
                MessageBox.Show("Insira o Endereço para proseguir!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                data = DateTime.Parse(dtpdata.Text);

                sql = string.Format("insert into clientes values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')"
                    , txtnome.Text, txtcpf.Text, data.ToString("yyyy-MM-dd"), txtendereço.Text, txtnumero.Text, txtcidade.Text, txtuf.Text, cbxsexo.Text, txtemail.Text, txttelefone.Text);
                bd.AlterarTabelas(sql);
                MessageBox.Show("Cliente inserido com sucesso!!!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
                listar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data = DateTime.Parse(dtpdata.Text);
            sql = string.Format("update clientes set nome='{0}',uf ='{2}',data_nascimento='{3}',sexo='{4}',cidade='{5}',endereco='{6}',numero='{7}',email='{8}',telefone='{9}' where cpf = '{1}'"
          , txtnome.Text, txtcpf.Text, txtuf, data.ToString("yyyy-MM-dd"), cbxsexo.Text, txtcidade.Text, txtendereço.Text, txtnumero.Text, txtemail.Text, txttelefone.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Cliente alterado com sucesso!!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from clientes where cpf ='{0}'", txtcpf.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Dados do Cliente excluído com sucesso!!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            listar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void imgempresarial_Click(object sender, EventArgs e)
        {

        }

        private void dtglistar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltelefone_Click(object sender, EventArgs e)
        {

        }

        private void txtendereço_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnumero_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            painel cadpainel = new painel();
            cadpainel.ShowDialog();
            this.Visible = true;
        }
    }
}
