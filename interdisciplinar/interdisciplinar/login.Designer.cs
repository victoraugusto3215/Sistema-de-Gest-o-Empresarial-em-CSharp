
namespace interdisciplinar
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btnconcluir = new System.Windows.Forms.Button();
            this.imgempresarial = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgempresarial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(29, 15);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(46, 13);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuário:";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(29, 71);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(41, 13);
            this.lblsenha.TabIndex = 2;
            this.lblsenha.Text = "Senha:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(81, 12);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(194, 20);
            this.txtusuario.TabIndex = 4;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(81, 71);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(194, 20);
            this.txtsenha.TabIndex = 5;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            // 
            // btnconcluir
            // 
            this.btnconcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnconcluir.Image")));
            this.btnconcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconcluir.Location = new System.Drawing.Point(81, 116);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(85, 42);
            this.btnconcluir.TabIndex = 6;
            this.btnconcluir.Text = "  Concluir";
            this.btnconcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconcluir.UseVisualStyleBackColor = true;
            this.btnconcluir.Click += new System.EventHandler(this.btnconcluir_Click);
            this.btnconcluir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnconcluir_KeyPress);
            // 
            // imgempresarial
            // 
            this.imgempresarial.Image = ((System.Drawing.Image)(resources.GetObject("imgempresarial.Image")));
            this.imgempresarial.Location = new System.Drawing.Point(315, 15);
            this.imgempresarial.Name = "imgempresarial";
            this.imgempresarial.Size = new System.Drawing.Size(149, 143);
            this.imgempresarial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgempresarial.TabIndex = 9;
            this.imgempresarial.TabStop = false;
            this.imgempresarial.Click += new System.EventHandler(this.imgempresarial_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(172, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastre-se";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgempresarial);
            this.Controls.Add(this.btnconcluir);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgempresarial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.PictureBox imgempresarial;
        private System.Windows.Forms.Button button1;
    }
}