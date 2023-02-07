
namespace interdisciplinar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblusuário = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btnconcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(128, 107);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(167, 20);
            this.txtsenha.TabIndex = 11;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(128, 65);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(167, 20);
            this.txtuser.TabIndex = 10;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(128, 18);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(167, 20);
            this.txtnome.TabIndex = 9;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(81, 107);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(41, 13);
            this.lblsenha.TabIndex = 8;
            this.lblsenha.Text = "Senha:";
            this.lblsenha.Click += new System.EventHandler(this.lblsenha_Click);
            // 
            // lblusuário
            // 
            this.lblusuário.AutoSize = true;
            this.lblusuário.Location = new System.Drawing.Point(82, 68);
            this.lblusuário.Name = "lblusuário";
            this.lblusuário.Size = new System.Drawing.Size(46, 13);
            this.lblusuário.TabIndex = 7;
            this.lblusuário.Text = "Usuário:";
            this.lblusuário.Click += new System.EventHandler(this.lblusuário_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(82, 25);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 6;
            this.lblnome.Text = "Nome:";
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar.Location = new System.Drawing.Point(204, 160);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(80, 47);
            this.btn_limpar.TabIndex = 61;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btnconcluir
            // 
            this.btnconcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnconcluir.Image")));
            this.btnconcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconcluir.Location = new System.Drawing.Point(101, 160);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(88, 47);
            this.btnconcluir.TabIndex = 60;
            this.btnconcluir.Text = "   Concluir";
            this.btnconcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconcluir.UseVisualStyleBackColor = true;
            this.btnconcluir.Click += new System.EventHandler(this.btnconcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 222);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btnconcluir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblusuário);
            this.Controls.Add(this.lblnome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblusuário;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btnconcluir;
    }
}