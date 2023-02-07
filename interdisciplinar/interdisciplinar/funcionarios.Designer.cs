
namespace interdisciplinar
{
    partial class funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(funcionarios));
            this.imgempresarial = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtendereço = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.cbxsexo = new System.Windows.Forms.ComboBox();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lbluf = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblendereço = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblsetor = new System.Windows.Forms.Label();
            this.txtsetor = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgempresarial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgempresarial
            // 
            this.imgempresarial.Image = ((System.Drawing.Image)(resources.GetObject("imgempresarial.Image")));
            this.imgempresarial.Location = new System.Drawing.Point(826, 19);
            this.imgempresarial.Name = "imgempresarial";
            this.imgempresarial.Size = new System.Drawing.Size(204, 212);
            this.imgempresarial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgempresarial.TabIndex = 53;
            this.imgempresarial.TabStop = false;
            this.imgempresarial.Click += new System.EventHandler(this.imgempresarial_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(536, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 47);
            this.button4.TabIndex = 51;
            this.button4.Text = "  Excluir";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(402, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 47);
            this.button3.TabIndex = 50;
            this.button3.Text = "Alterar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(253, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 47);
            this.button2.TabIndex = 49;
            this.button2.Text = "Buscar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(125, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 47);
            this.button1.TabIndex = 48;
            this.button1.Text = "  Novo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtglistar
            // 
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.Location = new System.Drawing.Point(78, 248);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.Size = new System.Drawing.Size(734, 150);
            this.dtglistar.TabIndex = 47;
            this.dtglistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistar_CellContentClick);
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(133, 205);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(146, 20);
            this.txttelefone.TabIndex = 46;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(486, 146);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(112, 20);
            this.txtnumero.TabIndex = 45;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(700, 143);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(112, 20);
            this.txtemail.TabIndex = 44;
            // 
            // txtendereço
            // 
            this.txtendereço.Location = new System.Drawing.Point(133, 146);
            this.txtendereço.Name = "txtendereço";
            this.txtendereço.Size = new System.Drawing.Size(285, 20);
            this.txtendereço.TabIndex = 43;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(700, 75);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(108, 20);
            this.txtcidade.TabIndex = 42;
            // 
            // cbxsexo
            // 
            this.cbxsexo.FormattingEnabled = true;
            this.cbxsexo.Items.AddRange(new object[] {
            "",
            "M",
            "F",
            "O"});
            this.cbxsexo.Location = new System.Drawing.Point(486, 75);
            this.cbxsexo.Name = "cbxsexo";
            this.cbxsexo.Size = new System.Drawing.Size(112, 21);
            this.cbxsexo.TabIndex = 41;
            // 
            // dtpdata
            // 
            this.dtpdata.Location = new System.Drawing.Point(184, 68);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(234, 20);
            this.dtpdata.TabIndex = 40;
            // 
            // txtuf
            // 
            this.txtuf.Location = new System.Drawing.Point(700, 19);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(100, 20);
            this.txtuf.TabIndex = 39;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(486, 19);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(112, 20);
            this.txtcpf.TabIndex = 38;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(115, 19);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(303, 20);
            this.txtnome.TabIndex = 37;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Location = new System.Drawing.Point(75, 212);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(52, 13);
            this.lbltelefone.TabIndex = 36;
            this.lbltelefone.Text = "Telefone:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(659, 146);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 35;
            this.lblemail.Text = "Email:";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(446, 75);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(34, 13);
            this.lblsexo.TabIndex = 34;
            this.lblsexo.Text = "Sexo:";
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Location = new System.Drawing.Point(670, 26);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(24, 13);
            this.lbluf.TabIndex = 33;
            this.lbluf.Text = "UF:";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(651, 82);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(43, 13);
            this.lblcidade.TabIndex = 32;
            this.lblcidade.Text = "Cidade:";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(436, 153);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(44, 13);
            this.lblnumero.TabIndex = 31;
            this.lblnumero.Text = "Número";
            // 
            // lblendereço
            // 
            this.lblendereço.AutoSize = true;
            this.lblendereço.Location = new System.Drawing.Point(71, 153);
            this.lblendereço.Name = "lblendereço";
            this.lblendereço.Size = new System.Drawing.Size(56, 13);
            this.lblendereço.TabIndex = 30;
            this.lblendereço.Text = "Endereço:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(71, 74);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(107, 13);
            this.lbldata.TabIndex = 29;
            this.lbldata.Text = "Data de Nascimento:";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(450, 22);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(30, 13);
            this.lblcpf.TabIndex = 28;
            this.lblcpf.Text = "CPF:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(71, 22);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 27;
            this.lblnome.Text = "Nome:";
            // 
            // lblsetor
            // 
            this.lblsetor.AutoSize = true;
            this.lblsetor.Location = new System.Drawing.Point(322, 212);
            this.lblsetor.Name = "lblsetor";
            this.lblsetor.Size = new System.Drawing.Size(35, 13);
            this.lblsetor.TabIndex = 54;
            this.lblsetor.Text = "Setor:";
            // 
            // txtsetor
            // 
            this.txtsetor.Location = new System.Drawing.Point(363, 209);
            this.txtsetor.Name = "txtsetor";
            this.txtsetor.Size = new System.Drawing.Size(143, 20);
            this.txtsetor.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(654, 430);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 47);
            this.button5.TabIndex = 52;
            this.button5.Text = "Limpar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 497);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtsetor);
            this.Controls.Add(this.lblsetor);
            this.Controls.Add(this.imgempresarial);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtglistar);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtendereço);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.cbxsexo);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.txtuf);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lbluf);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblendereço);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblnome);
            this.Name = "funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "funcionarios";
            this.Load += new System.EventHandler(this.funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgempresarial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgempresarial;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtglistar;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtendereço;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.ComboBox cbxsexo;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.TextBox txtuf;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lbluf;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblendereço;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblsetor;
        private System.Windows.Forms.TextBox txtsetor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
    }
}