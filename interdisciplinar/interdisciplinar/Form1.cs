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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conexaobd bd = new Conexaobd();
        string sql;

        public void Limpar()
        {
           
            txtnome.Clear();
            txtsenha.Clear();
            txtuser.Clear();
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsenha_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

                this.Visible = false;
                login cadlogin = new login();
                cadlogin.ShowDialog();
                this.Visible = true;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login cadlogin = new login();
            cadlogin.ShowDialog();
            this.Visible = true;
        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void lblusuário_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
