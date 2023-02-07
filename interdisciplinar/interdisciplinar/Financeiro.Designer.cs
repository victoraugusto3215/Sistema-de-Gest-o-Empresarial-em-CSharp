
namespace interdisciplinar
{
    partial class Financeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Financeiro));
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lbltitular = new System.Windows.Forms.Label();
            this.lblemissao = new System.Windows.Forms.Label();
            this.lblvencimento = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.txt_titular = new System.Windows.Forms.TextBox();
            this.data_emissao = new System.Windows.Forms.DateTimePicker();
            this.data_vencimento = new System.Windows.Forms.DateTimePicker();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.imgempresarial = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnconcluir = new System.Windows.Forms.Button();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgempresarial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(47, 50);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(55, 13);
            this.lblcategoria.TabIndex = 0;
            this.lblcategoria.Text = "Categoria:";
            this.lblcategoria.Click += new System.EventHandler(this.lblcategoria_Click);
            // 
            // lbltitular
            // 
            this.lbltitular.AutoSize = true;
            this.lbltitular.Location = new System.Drawing.Point(47, 82);
            this.lbltitular.Name = "lbltitular";
            this.lbltitular.Size = new System.Drawing.Size(39, 13);
            this.lbltitular.TabIndex = 1;
            this.lbltitular.Text = "Titular:";
            this.lbltitular.Click += new System.EventHandler(this.lbltitular_Click);
            // 
            // lblemissao
            // 
            this.lblemissao.AutoSize = true;
            this.lblemissao.Location = new System.Drawing.Point(47, 118);
            this.lblemissao.Name = "lblemissao";
            this.lblemissao.Size = new System.Drawing.Size(90, 13);
            this.lblemissao.TabIndex = 2;
            this.lblemissao.Text = "Data de Emissão:";
            this.lblemissao.Click += new System.EventHandler(this.lblemissao_Click);
            // 
            // lblvencimento
            // 
            this.lblvencimento.AutoSize = true;
            this.lblvencimento.Location = new System.Drawing.Point(47, 155);
            this.lblvencimento.Name = "lblvencimento";
            this.lblvencimento.Size = new System.Drawing.Size(107, 13);
            this.lblvencimento.TabIndex = 3;
            this.lblvencimento.Text = "Data do Vencimento:";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(47, 195);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(34, 13);
            this.lblvalor.TabIndex = 4;
            this.lblvalor.Text = "Valor:";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(108, 44);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(289, 20);
            this.txt_categoria.TabIndex = 5;
            // 
            // txt_titular
            // 
            this.txt_titular.Location = new System.Drawing.Point(108, 79);
            this.txt_titular.Name = "txt_titular";
            this.txt_titular.Size = new System.Drawing.Size(289, 20);
            this.txt_titular.TabIndex = 6;
            // 
            // data_emissao
            // 
            this.data_emissao.Location = new System.Drawing.Point(143, 112);
            this.data_emissao.Name = "data_emissao";
            this.data_emissao.Size = new System.Drawing.Size(254, 20);
            this.data_emissao.TabIndex = 7;
            // 
            // data_vencimento
            // 
            this.data_vencimento.Location = new System.Drawing.Point(160, 149);
            this.data_vencimento.Name = "data_vencimento";
            this.data_vencimento.Size = new System.Drawing.Size(237, 20);
            this.data_vencimento.TabIndex = 8;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(90, 192);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(310, 20);
            this.txtvalor.TabIndex = 9;
            // 
            // imgempresarial
            // 
            this.imgempresarial.Image = ((System.Drawing.Image)(resources.GetObject("imgempresarial.Image")));
            this.imgempresarial.Location = new System.Drawing.Point(408, 44);
            this.imgempresarial.Name = "imgempresarial";
            this.imgempresarial.Size = new System.Drawing.Size(160, 164);
            this.imgempresarial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgempresarial.TabIndex = 10;
            this.imgempresarial.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(356, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 47);
            this.button2.TabIndex = 56;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar.Location = new System.Drawing.Point(466, 389);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(103, 47);
            this.btn_limpar.TabIndex = 55;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(243, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 47);
            this.button1.TabIndex = 54;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluir.Image")));
            this.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluir.Location = new System.Drawing.Point(129, 388);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(103, 47);
            this.btnexcluir.TabIndex = 53;
            this.btnexcluir.Text = "  Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnconcluir
            // 
            this.btnconcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnconcluir.Image")));
            this.btnconcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconcluir.Location = new System.Drawing.Point(7, 388);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(113, 47);
            this.btnconcluir.TabIndex = 52;
            this.btnconcluir.Text = "   Concluir";
            this.btnconcluir.UseVisualStyleBackColor = true;
            this.btnconcluir.Click += new System.EventHandler(this.btnconcluir_Click);
            // 
            // dtglistar
            // 
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.Location = new System.Drawing.Point(9, 268);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.Size = new System.Drawing.Size(559, 105);
            this.dtglistar.TabIndex = 57;
            this.dtglistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistar_CellContentClick);
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(90, 227);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(310, 20);
            this.txt_status.TabIndex = 59;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(50, 230);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 13);
            this.label.TabIndex = 58;
            this.label.Text = "Status:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(108, 12);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(289, 20);
            this.txt_codigo.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Codigo:";
            // 
            // Financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 451);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dtglistar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnconcluir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgempresarial);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.data_vencimento);
            this.Controls.Add(this.data_emissao);
            this.Controls.Add(this.txt_titular);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lblvencimento);
            this.Controls.Add(this.lblemissao);
            this.Controls.Add(this.lbltitular);
            this.Controls.Add(this.lblcategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Financeiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financeiro";
            this.Load += new System.EventHandler(this.Financeiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgempresarial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lbltitular;
        private System.Windows.Forms.Label lblemissao;
        private System.Windows.Forms.Label lblvencimento;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.TextBox txt_titular;
        private System.Windows.Forms.DateTimePicker data_vencimento;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.PictureBox imgempresarial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.DataGridView dtglistar;
        private System.Windows.Forms.DateTimePicker data_emissao;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
    }
}