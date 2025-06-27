namespace GPSFrancisco
{
    partial class frmCadastraProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastraProduto));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.pcbFotoProduto = new System.Windows.Forms.PictureBox();
            this.lblPrimeiraUnidade = new System.Windows.Forms.Label();
            this.cbxUnidade = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblCodigoDeBarras = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.ofdCarregar = new System.Windows.Forms.OpenFileDialog();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gpbVoluntario = new System.Windows.Forms.GroupBox();
            this.pcbCodigoBarras = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblValidade = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoProduto)).BeginInit();
            this.pnlCRUD.SuspendLayout();
            this.gpbVoluntario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCodigoBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(279, 11);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(121, 42);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.FlatAppearance.BorderSize = 0;
            this.btnInserirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirProduto.Image")));
            this.btnInserirProduto.Location = new System.Drawing.Point(720, 192);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(59, 51);
            this.btnInserirProduto.TabIndex = 24;
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // pcbFotoProduto
            // 
            this.pcbFotoProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbFotoProduto.Location = new System.Drawing.Point(802, 25);
            this.pcbFotoProduto.Name = "pcbFotoProduto";
            this.pcbFotoProduto.Size = new System.Drawing.Size(170, 136);
            this.pcbFotoProduto.TabIndex = 21;
            this.pcbFotoProduto.TabStop = false;
            // 
            // lblPrimeiraUnidade
            // 
            this.lblPrimeiraUnidade.AutoSize = true;
            this.lblPrimeiraUnidade.Location = new System.Drawing.Point(572, 171);
            this.lblPrimeiraUnidade.Name = "lblPrimeiraUnidade";
            this.lblPrimeiraUnidade.Size = new System.Drawing.Size(130, 20);
            this.lblPrimeiraUnidade.TabIndex = 19;
            this.lblPrimeiraUnidade.Text = "Primeira Unidade";
            // 
            // cbxUnidade
            // 
            this.cbxUnidade.FormattingEnabled = true;
            this.cbxUnidade.Location = new System.Drawing.Point(576, 204);
            this.cbxUnidade.Name = "cbxUnidade";
            this.cbxUnidade.Size = new System.Drawing.Size(138, 28);
            this.cbxUnidade.TabIndex = 11;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(824, 11);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(121, 42);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(687, 11);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 42);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(549, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(121, 42);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Location = new System.Drawing.Point(24, 493);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(960, 65);
            this.pnlCRUD.TabIndex = 14;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(411, 11);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 42);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(144, 11);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 42);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(3, 11);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(121, 42);
            this.btnNovo.TabIndex = 17;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(401, 171);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(41, 20);
            this.lblLote.TabIndex = 13;
            this.lblLote.Text = "Lote";
            this.lblLote.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(405, 204);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(138, 26);
            this.txtLote.TabIndex = 7;
            // 
            // lblCodigoDeBarras
            // 
            this.lblCodigoDeBarras.AutoSize = true;
            this.lblCodigoDeBarras.Location = new System.Drawing.Point(23, 40);
            this.lblCodigoDeBarras.Name = "lblCodigoDeBarras";
            this.lblCodigoDeBarras.Size = new System.Drawing.Size(130, 20);
            this.lblCodigoDeBarras.TabIndex = 11;
            this.lblCodigoDeBarras.Text = "Codigo de barras";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(173, 395);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(111, 26);
            this.dtpHora.TabIndex = 15;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(26, 77);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(362, 26);
            this.txtCodigoBarras.TabIndex = 6;
            this.txtCodigoBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyDown);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(21, 395);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(121, 26);
            this.dtpData.TabIndex = 14;
            // 
            // ofdCarregar
            // 
            this.ofdCarregar.FileName = "openFileDialog1";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(169, 360);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(127, 20);
            this.lblHoraEntrada.TabIndex = 25;
            this.lblHoraEntrada.Text = "Hora de Entrada";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(17, 360);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(127, 20);
            this.lblDataEntrada.TabIndex = 24;
            this.lblDataEntrada.Text = "Data da Entrada";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(17, 169);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(20, 204);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(362, 26);
            this.txtDescricao.TabIndex = 2;
            // 
            // gpbVoluntario
            // 
            this.gpbVoluntario.Controls.Add(this.pcbCodigoBarras);
            this.gpbVoluntario.Controls.Add(this.label1);
            this.gpbVoluntario.Controls.Add(this.button1);
            this.gpbVoluntario.Controls.Add(this.lblQuantidade);
            this.gpbVoluntario.Controls.Add(this.txtQuantidade);
            this.gpbVoluntario.Controls.Add(this.lblValidade);
            this.gpbVoluntario.Controls.Add(this.dateTimePicker1);
            this.gpbVoluntario.Controls.Add(this.btnInserirProduto);
            this.gpbVoluntario.Controls.Add(this.lblHoraEntrada);
            this.gpbVoluntario.Controls.Add(this.dtpHora);
            this.gpbVoluntario.Controls.Add(this.lblDataEntrada);
            this.gpbVoluntario.Controls.Add(this.pcbFotoProduto);
            this.gpbVoluntario.Controls.Add(this.lblPrimeiraUnidade);
            this.gpbVoluntario.Controls.Add(this.dtpData);
            this.gpbVoluntario.Controls.Add(this.cbxUnidade);
            this.gpbVoluntario.Controls.Add(this.lblLote);
            this.gpbVoluntario.Controls.Add(this.txtLote);
            this.gpbVoluntario.Controls.Add(this.lblCodigoDeBarras);
            this.gpbVoluntario.Controls.Add(this.txtCodigoBarras);
            this.gpbVoluntario.Controls.Add(this.lblDescricao);
            this.gpbVoluntario.Controls.Add(this.txtDescricao);
            this.gpbVoluntario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbVoluntario.Location = new System.Drawing.Point(24, 25);
            this.gpbVoluntario.Name = "gpbVoluntario";
            this.gpbVoluntario.Size = new System.Drawing.Size(985, 446);
            this.gpbVoluntario.TabIndex = 13;
            this.gpbVoluntario.TabStop = false;
            this.gpbVoluntario.Text = "Informações do produto ";
            // 
            // pcbCodigoBarras
            // 
            this.pcbCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbCodigoBarras.Location = new System.Drawing.Point(473, 77);
            this.pcbCodigoBarras.Name = "pcbCodigoBarras";
            this.pcbCodigoBarras.Size = new System.Drawing.Size(271, 42);
            this.pcbCodigoBarras.TabIndex = 32;
            this.pcbCodigoBarras.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Codigo de barras";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 31);
            this.button1.TabIndex = 30;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(18, 260);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 29;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(21, 295);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(123, 26);
            this.txtQuantidade.TabIndex = 28;
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Location = new System.Drawing.Point(329, 360);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(71, 20);
            this.lblValidade.TabIndex = 27;
            this.lblValidade.Text = "Validade";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(333, 395);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 26);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // frmCadastraProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 575);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.gpbVoluntario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastraProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastraProduto";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoProduto)).EndInit();
            this.pnlCRUD.ResumeLayout(false);
            this.gpbVoluntario.ResumeLayout(false);
            this.gpbVoluntario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCodigoBarras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.PictureBox pcbFotoProduto;
        private System.Windows.Forms.Label lblPrimeiraUnidade;
        private System.Windows.Forms.ComboBox cbxUnidade;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblCodigoDeBarras;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.OpenFileDialog ofdCarregar;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox gpbVoluntario;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pcbCodigoBarras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}