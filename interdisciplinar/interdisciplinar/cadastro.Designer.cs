
namespace interdisciplinar
{
    partial class cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            this.lblnome = new System.Windows.Forms.Label();
            this.lblusuário = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.imgempresarial = new System.Windows.Forms.PictureBox();
            this.btnconcluir = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgempresarial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(68, 55);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // lblusuário
            // 
            this.lblusuário.AutoSize = true;
            this.lblusuário.Location = new System.Drawing.Point(68, 88);
            this.lblusuário.Name = "lblusuário";
            this.lblusuário.Size = new System.Drawing.Size(46, 13);
            this.lblusuário.TabIndex = 1;
            this.lblusuário.Text = "Usuário:";
            this.lblusuário.Click += new System.EventHandler(this.lblusuário_Click);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(68, 143);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(41, 13);
            this.lblsenha.TabIndex = 2;
            this.lblsenha.Text = "Senha:";
            this.lblsenha.Click += new System.EventHandler(this.lblsenha_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(112, 48);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(177, 20);
            this.txtnome.TabIndex = 3;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(112, 85);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(169, 20);
            this.txtuser.TabIndex = 4;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(115, 143);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(174, 20);
            this.txtsenha.TabIndex = 5;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            // 
            // imgempresarial
            // 
            this.imgempresarial.Image = ((System.Drawing.Image)(resources.GetObject("imgempresarial.Image")));
            this.imgempresarial.Location = new System.Drawing.Point(466, 18);
            this.imgempresarial.Name = "imgempresarial";
            this.imgempresarial.Size = new System.Drawing.Size(164, 145);
            this.imgempresarial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgempresarial.TabIndex = 6;
            this.imgempresarial.TabStop = false;
            // 
            // btnconcluir
            // 
            this.btnconcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnconcluir.Image")));
            this.btnconcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconcluir.Location = new System.Drawing.Point(68, 325);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(113, 47);
            this.btnconcluir.TabIndex = 22;
            this.btnconcluir.Text = "   Concluir";
            this.btnconcluir.UseVisualStyleBackColor = true;
            this.btnconcluir.Click += new System.EventHandler(this.btnconcluir_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluir.Image")));
            this.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluir.Location = new System.Drawing.Point(190, 325);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(103, 47);
            this.btnexcluir.TabIndex = 25;
            this.btnexcluir.Text = "  Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(304, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 47);
            this.button1.TabIndex = 26;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar.Location = new System.Drawing.Point(527, 326);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(103, 47);
            this.btn_limpar.TabIndex = 27;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // dtglistar
            // 
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.Location = new System.Drawing.Point(71, 188);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.Size = new System.Drawing.Size(559, 123);
            this.dtglistar.TabIndex = 28;
            this.dtglistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistar_CellContentClick);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(417, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 47);
            this.button2.TabIndex = 29;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(112, 11);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(177, 20);
            this.txt_codigo.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Codigo:";
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 385);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtglistar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnconcluir);
            this.Controls.Add(this.imgempresarial);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblusuário);
            this.Controls.Add(this.lblnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgempresarial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblusuário;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.PictureBox imgempresarial;
        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.DataGridView dtglistar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
    }
}