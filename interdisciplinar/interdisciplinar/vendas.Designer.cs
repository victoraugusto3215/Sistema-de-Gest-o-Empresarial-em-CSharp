
namespace interdisciplinar
{
    partial class vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendas));
            this.lblnome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblpagamento = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txt_codigocliente = new System.Windows.Forms.TextBox();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.cbxpagamento = new System.Windows.Forms.ComboBox();
            this.btnconcluir = new System.Windows.Forms.Button();
            this.imgempresarial = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgempresarial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(61, 48);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(60, 123);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(82, 13);
            this.lbldata.TabIndex = 2;
            this.lbldata.Text = "Data da Venda:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(61, 165);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(93, 13);
            this.lblcodigo.TabIndex = 3;
            this.lblcodigo.Text = "Código do Cliente:";
            // 
            // lblpagamento
            // 
            this.lblpagamento.AutoSize = true;
            this.lblpagamento.Location = new System.Drawing.Point(60, 208);
            this.lblpagamento.Name = "lblpagamento";
            this.lblpagamento.Size = new System.Drawing.Size(111, 13);
            this.lblpagamento.TabIndex = 4;
            this.lblpagamento.Text = "Forma de Pagamento:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(170, 45);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(247, 20);
            this.txtnome.TabIndex = 5;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(170, 83);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(247, 20);
            this.txtvalor.TabIndex = 6;
            // 
            // txt_codigocliente
            // 
            this.txt_codigocliente.Location = new System.Drawing.Point(170, 162);
            this.txt_codigocliente.Name = "txt_codigocliente";
            this.txt_codigocliente.Size = new System.Drawing.Size(251, 20);
            this.txt_codigocliente.TabIndex = 7;
            // 
            // dtpdata
            // 
            this.dtpdata.Location = new System.Drawing.Point(170, 117);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(251, 20);
            this.dtpdata.TabIndex = 8;
            // 
            // cbxpagamento
            // 
            this.cbxpagamento.FormattingEnabled = true;
            this.cbxpagamento.Items.AddRange(new object[] {
            "",
            "Crédito",
            "Débito",
            "Pix",
            "Dinheiro"});
            this.cbxpagamento.Location = new System.Drawing.Point(170, 200);
            this.cbxpagamento.Name = "cbxpagamento";
            this.cbxpagamento.Size = new System.Drawing.Size(251, 21);
            this.cbxpagamento.TabIndex = 9;
            // 
            // btnconcluir
            // 
            this.btnconcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnconcluir.Image")));
            this.btnconcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconcluir.Location = new System.Drawing.Point(72, 408);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(93, 47);
            this.btnconcluir.TabIndex = 23;
            this.btnconcluir.Text = "Adicionar";
            this.btnconcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconcluir.UseVisualStyleBackColor = true;
            this.btnconcluir.Click += new System.EventHandler(this.btnconcluir_Click);
            // 
            // imgempresarial
            // 
            this.imgempresarial.Image = ((System.Drawing.Image)(resources.GetObject("imgempresarial.Image")));
            this.imgempresarial.Location = new System.Drawing.Point(523, 5);
            this.imgempresarial.Name = "imgempresarial";
            this.imgempresarial.Size = new System.Drawing.Size(199, 176);
            this.imgempresarial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgempresarial.TabIndex = 24;
            this.imgempresarial.TabStop = false;
            this.imgempresarial.Click += new System.EventHandler(this.imgempresarial_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(204, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 47);
            this.button1.TabIndex = 58;
            this.button1.Text = "Deletar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(349, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 47);
            this.button2.TabIndex = 59;
            this.button2.Text = "Editar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtglistar
            // 
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.Location = new System.Drawing.Point(63, 243);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.Size = new System.Drawing.Size(659, 150);
            this.dtglistar.TabIndex = 60;
            this.dtglistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistar_CellContentClick);
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(616, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 44);
            this.button3.TabIndex = 61;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(493, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 47);
            this.button4.TabIndex = 62;
            this.button4.Text = "Buscar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(170, 5);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(247, 20);
            this.txt_codigo.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Codigo:";
            // 
            // vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 480);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtglistar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgempresarial);
            this.Controls.Add(this.btnconcluir);
            this.Controls.Add(this.cbxpagamento);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.txt_codigocliente);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblpagamento);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgempresarial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblpagamento;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txt_codigocliente;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.ComboBox cbxpagamento;
        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.PictureBox imgempresarial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtglistar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
    }
}