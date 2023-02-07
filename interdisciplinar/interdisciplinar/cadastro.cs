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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        Conexaobd bd = new Conexaobd();
        string sql;

        public void Limpar()
        {
            txt_codigo.Clear();
            txtnome.Clear();
            txtsenha.Clear();
            txtuser.Clear();
        }

        public void listar()
        {
            sql = "select * from login";
            dtglistar.DataSource = bd.consultarTabelas(sql);
        }

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnconcluir_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show("Insira um usuário para proseguir!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtsenha.Text == "")
            {
                MessageBox.Show("Insira uma senha para proseguir!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtnome.Text == "")
            {
                MessageBox.Show("Insira o nome do Usuário!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                sql = string.Format("insert into login values(null,'{0}','{1}','{2}')",
                    txtnome.Text, txtuser.Text, txtsenha.Text);

                bd.AlterarTabelas(sql);
                MessageBox.Show("Usuario(a) cadastrado com sucesso!", "Cadastrar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                listar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = string.Format("update login set nome = '{1}', usuario = '{2}', senha = '{3}' where codigo = '{0}'"
                , txt_codigo.Text, txtnome.Text, txtuser.Text,txtsenha.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Alteração realizada com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from login where codigo = '{0}' or nome = '{1}' or usuario = '{2}'", txt_codigo.Text, txtnome.Text, txtuser.Text);
            buscar = bd.consultarTabelas(sql);
            if(buscar.Rows.Count > 0)
            {
                txt_codigo.Text = buscar.Rows[0]["codigo"].ToString();
                txtnome.Text = buscar.Rows[0]["nome"].ToString();
                txtuser.Text = buscar.Rows[0]["usuario"].ToString();
                txtsenha.Text = buscar.Rows[0]["senha"].ToString();

                listar();
            }

            else
            {
                MessageBox.Show("Usuário não enconhtrado!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            painel cadpainel = new painel();
            cadpainel.ShowDialog();
            this.Visible = true;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from login where codigo = '{0}'", txt_codigo.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Usuario(a) excluido com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            listar();
        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblusuário_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsenha_Click(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
