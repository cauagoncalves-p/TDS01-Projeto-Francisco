namespace GPSFrancisco
{
    partial class frmRecurparFotos
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
            this.picFotos = new System.Windows.Forms.PictureBox();
            this.dtgFoto = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picFotos
            // 
            this.picFotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotos.Location = new System.Drawing.Point(90, 39);
            this.picFotos.Name = "picFotos";
            this.picFotos.Size = new System.Drawing.Size(532, 221);
            this.picFotos.TabIndex = 0;
            this.picFotos.TabStop = false;
            // 
            // dtgFoto
            // 
            this.dtgFoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFoto.Location = new System.Drawing.Point(68, 341);
            this.dtgFoto.Name = "dtgFoto";
            this.dtgFoto.Size = new System.Drawing.Size(314, 160);
            this.dtgFoto.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(461, 341);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(161, 50);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(461, 414);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(161, 50);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(461, 482);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(161, 50);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // frmRecurparFotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 556);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtgFoto);
            this.Controls.Add(this.picFotos);
            this.Name = "frmRecurparFotos";
            this.Text = "frmRecurparFotos";
            ((System.ComponentModel.ISupportInitialize)(this.picFotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFotos;
        private System.Windows.Forms.DataGridView dtgFoto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}