namespace GPSFrancisco
{
    partial class frmCarregarFoto
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.picFotos = new System.Windows.Forms.PictureBox();
            this.txtBuscaFotos = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSalvarFotos = new System.Windows.Forms.Button();
            this.btnInserirFotos = new System.Windows.Forms.Button();
            this.ofdInerirFotos = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(464, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(352, 83);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 20);
            this.txtNome.TabIndex = 1;
            // 
            // picFotos
            // 
            this.picFotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotos.Location = new System.Drawing.Point(318, 140);
            this.picFotos.Name = "picFotos";
            this.picFotos.Size = new System.Drawing.Size(402, 273);
            this.picFotos.TabIndex = 2;
            this.picFotos.TabStop = false;
            // 
            // txtBuscaFotos
            // 
            this.txtBuscaFotos.Location = new System.Drawing.Point(244, 442);
            this.txtBuscaFotos.Multiline = true;
            this.txtBuscaFotos.Name = "txtBuscaFotos";
            this.txtBuscaFotos.Size = new System.Drawing.Size(538, 20);
            this.txtBuscaFotos.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(78, 518);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(144, 46);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(258, 518);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(144, 46);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSalvarFotos
            // 
            this.btnSalvarFotos.Location = new System.Drawing.Point(448, 518);
            this.btnSalvarFotos.Name = "btnSalvarFotos";
            this.btnSalvarFotos.Size = new System.Drawing.Size(144, 46);
            this.btnSalvarFotos.TabIndex = 6;
            this.btnSalvarFotos.Text = "Salvar Fotos";
            this.btnSalvarFotos.UseVisualStyleBackColor = true;
            this.btnSalvarFotos.Click += new System.EventHandler(this.btnSalvarFotos_Click);
            // 
            // btnInserirFotos
            // 
            this.btnInserirFotos.Location = new System.Drawing.Point(638, 518);
            this.btnInserirFotos.Name = "btnInserirFotos";
            this.btnInserirFotos.Size = new System.Drawing.Size(144, 46);
            this.btnInserirFotos.TabIndex = 7;
            this.btnInserirFotos.Text = "Inserir Fotos";
            this.btnInserirFotos.UseVisualStyleBackColor = true;
            this.btnInserirFotos.Click += new System.EventHandler(this.btnInserirFotos_Click);
            // 
            // ofdInerirFotos
            // 
            this.ofdInerirFotos.FileName = "openFileDialog1";
            // 
            // frmCarregarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 622);
            this.Controls.Add(this.btnInserirFotos);
            this.Controls.Add(this.btnSalvarFotos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtBuscaFotos);
            this.Controls.Add(this.picFotos);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCarregarFoto";
            this.Text = "frmCarregarFoto";
            ((System.ComponentModel.ISupportInitialize)(this.picFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox picFotos;
        private System.Windows.Forms.TextBox txtBuscaFotos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSalvarFotos;
        private System.Windows.Forms.Button btnInserirFotos;
        private System.Windows.Forms.OpenFileDialog ofdInerirFotos;
    }
}