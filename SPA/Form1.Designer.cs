namespace SPA
{
    partial class frmSpa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpa));
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblInicial = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.cbxMassagem = new System.Windows.Forms.CheckBox();
            this.cbxMeditacao = new System.Windows.Forms.CheckBox();
            this.cbxLimpeza = new System.Windows.Forms.CheckBox();
            this.cbxPodologia = new System.Windows.Forms.CheckBox();
            this.txtMassagem = new System.Windows.Forms.TextBox();
            this.txtMeditacao = new System.Windows.Forms.TextBox();
            this.txtLimpeza = new System.Windows.Forms.TextBox();
            this.txtPodologia = new System.Windows.Forms.TextBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.gpAdd = new System.Windows.Forms.GroupBox();
            this.txtInicial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.gpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(115, 321);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 0;
            this.txtFinal.Text = "0";
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinal_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(259, 319);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(356, 319);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Location = new System.Drawing.Point(27, 27);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(90, 13);
            this.lblInicial.TabIndex = 4;
            this.lblInicial.Text = "Tarifa Inicial (R$):";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(27, 325);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(82, 13);
            this.lblFinal.TabIndex = 5;
            this.lblFinal.Text = "Valor Final (R$):";
            // 
            // cbxMassagem
            // 
            this.cbxMassagem.AutoSize = true;
            this.cbxMassagem.Location = new System.Drawing.Point(9, 28);
            this.cbxMassagem.Name = "cbxMassagem";
            this.cbxMassagem.Size = new System.Drawing.Size(163, 17);
            this.cbxMassagem.TabIndex = 6;
            this.cbxMassagem.Text = "Massagem Terapeutica (R$):";
            this.cbxMassagem.UseVisualStyleBackColor = true;
            this.cbxMassagem.CheckedChanged += new System.EventHandler(this.cbxMassagem_CheckedChanged);
            // 
            // cbxMeditacao
            // 
            this.cbxMeditacao.AutoSize = true;
            this.cbxMeditacao.Location = new System.Drawing.Point(9, 67);
            this.cbxMeditacao.Name = "cbxMeditacao";
            this.cbxMeditacao.Size = new System.Drawing.Size(155, 17);
            this.cbxMeditacao.TabIndex = 7;
            this.cbxMeditacao.Text = "Sessão de Meditação (R$):";
            this.cbxMeditacao.UseVisualStyleBackColor = true;
            this.cbxMeditacao.CheckedChanged += new System.EventHandler(this.cbxMeditacao_CheckedChanged);
            // 
            // cbxLimpeza
            // 
            this.cbxLimpeza.AutoSize = true;
            this.cbxLimpeza.Location = new System.Drawing.Point(283, 24);
            this.cbxLimpeza.Name = "cbxLimpeza";
            this.cbxLimpeza.Size = new System.Drawing.Size(127, 17);
            this.cbxLimpeza.TabIndex = 8;
            this.cbxLimpeza.Text = "Limpeza de Pele(R$):";
            this.cbxLimpeza.UseVisualStyleBackColor = true;
            this.cbxLimpeza.CheckedChanged += new System.EventHandler(this.cbxLimpeza_CheckedChanged);
            // 
            // cbxPodologia
            // 
            this.cbxPodologia.AutoSize = true;
            this.cbxPodologia.Location = new System.Drawing.Point(283, 68);
            this.cbxPodologia.Name = "cbxPodologia";
            this.cbxPodologia.Size = new System.Drawing.Size(99, 17);
            this.cbxPodologia.TabIndex = 9;
            this.cbxPodologia.Text = "Podologia (R$):";
            this.cbxPodologia.UseVisualStyleBackColor = true;
            this.cbxPodologia.CheckedChanged += new System.EventHandler(this.cbxPodologia_CheckedChanged);
            // 
            // txtMassagem
            // 
            this.txtMassagem.Enabled = false;
            this.txtMassagem.Location = new System.Drawing.Point(177, 24);
            this.txtMassagem.Name = "txtMassagem";
            this.txtMassagem.Size = new System.Drawing.Size(100, 20);
            this.txtMassagem.TabIndex = 10;
            this.txtMassagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMeditacao
            // 
            this.txtMeditacao.Enabled = false;
            this.txtMeditacao.Location = new System.Drawing.Point(177, 65);
            this.txtMeditacao.Name = "txtMeditacao";
            this.txtMeditacao.Size = new System.Drawing.Size(100, 20);
            this.txtMeditacao.TabIndex = 11;
            this.txtMeditacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLimpeza
            // 
            this.txtLimpeza.Enabled = false;
            this.txtLimpeza.Location = new System.Drawing.Point(416, 21);
            this.txtLimpeza.Name = "txtLimpeza";
            this.txtLimpeza.Size = new System.Drawing.Size(100, 20);
            this.txtLimpeza.TabIndex = 12;
            this.txtLimpeza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPodologia
            // 
            this.txtPodologia.Enabled = false;
            this.txtPodologia.Location = new System.Drawing.Point(416, 64);
            this.txtPodologia.Name = "txtPodologia";
            this.txtPodologia.Size = new System.Drawing.Size(100, 20);
            this.txtPodologia.TabIndex = 13;
            this.txtPodologia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picFoto
            // 
            this.picFoto.Image = ((System.Drawing.Image)(resources.GetObject("picFoto.Image")));
            this.picFoto.Location = new System.Drawing.Point(27, 161);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(522, 144);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 14;
            this.picFoto.TabStop = false;
            // 
            // gpAdd
            // 
            this.gpAdd.Controls.Add(this.cbxLimpeza);
            this.gpAdd.Controls.Add(this.txtPodologia);
            this.gpAdd.Controls.Add(this.cbxMassagem);
            this.gpAdd.Controls.Add(this.txtLimpeza);
            this.gpAdd.Controls.Add(this.cbxMeditacao);
            this.gpAdd.Controls.Add(this.txtMeditacao);
            this.gpAdd.Controls.Add(this.cbxPodologia);
            this.gpAdd.Controls.Add(this.txtMassagem);
            this.gpAdd.Location = new System.Drawing.Point(27, 55);
            this.gpAdd.Name = "gpAdd";
            this.gpAdd.Size = new System.Drawing.Size(522, 100);
            this.gpAdd.TabIndex = 15;
            this.gpAdd.TabStop = false;
            this.gpAdd.Text = "Adicionais";
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(123, 24);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(100, 20);
            this.txtInicial.TabIndex = 0;
            this.txtInicial.Text = "0";
            this.txtInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInicial.TextChanged += new System.EventHandler(this.txtInicial_TextChanged);
            this.txtInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInicial_KeyPress);
            // 
            // frmSpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 364);
            this.Controls.Add(this.txtInicial);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblInicial);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.gpAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSpa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.Load += new System.EventHandler(this.frmSpa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.gpAdd.ResumeLayout(false);
            this.gpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.CheckBox cbxMassagem;
        private System.Windows.Forms.CheckBox cbxMeditacao;
        private System.Windows.Forms.CheckBox cbxLimpeza;
        private System.Windows.Forms.CheckBox cbxPodologia;
        private System.Windows.Forms.TextBox txtMassagem;
        private System.Windows.Forms.TextBox txtMeditacao;
        private System.Windows.Forms.TextBox txtLimpeza;
        private System.Windows.Forms.TextBox txtPodologia;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.GroupBox gpAdd;
        private System.Windows.Forms.TextBox txtInicial;
    }
}

