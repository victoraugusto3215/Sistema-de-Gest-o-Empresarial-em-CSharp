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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        Conexaobd bd = new Conexaobd();
        string sql, usuario, senha;
        DateTime data;

        public void listar()
        {
            sql = "select * from login";
        }

        public void Limpar()
        {
            txtusuario.Clear();
            txtsenha.Clear();
        }

        private void btnconcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                usuario = txtusuario.Text;
                senha = txtsenha.Text;



                DataTable buscar = new DataTable();
                sql = string.Format("select * from login where usuario = '{0}' and senha = '{1}'", txtusuario.Text, txtsenha.Text);
                buscar = bd.consultarTabelas(sql);
                if (buscar.Rows.Count > 0)
                {
                    this.Visible = false;
                    painel cadpainel = new painel();
                    cadpainel.ShowDialog();
                    this.Visible = true;
                }

                else
                {
                    MessageBox.Show("Usuário não enconhtrado!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpar();
                }

            }
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void imgempresarial_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 cadcadastro= new Form1();
            cadcadastro.ShowDialog();
            this.Visible = true;
        }

        private void btnconcluir_Click(object sender, EventArgs e)
        {
            usuario = txtusuario.Text;
            senha = txtsenha.Text;

           

            DataTable buscar = new DataTable();
            sql = string.Format("select * from login where usuario = '{0}' and senha = '{1}'", txtusuario.Text, txtsenha.Text);
            buscar = bd.consultarTabelas(sql);
            if (buscar.Rows.Count > 0)
            {
                this.Visible = false;
                painel cadpainel = new painel();
                cadpainel.ShowDialog();
                this.Visible = true;
            }

            else
            {
                MessageBox.Show("Usuário não enconhtrado!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
            }


            




            // this.Visible = false;
            //painel cadpainel = new painel();
            //cadpainel.ShowDialog();
            //this.Visible = true;
        }

        private void login_Load(object sender, EventArgs e)
        {
            

           


        }
    }
}
