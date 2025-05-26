using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFrancisco
{
    public partial class frmAtribuicao : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmAtribuicao()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public void desabilitarCampos() {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            btnCadastrar.Enabled = false;
            btnLimpar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = true;
        }

        public void habilitarNovosCampos() {
            txtNome.Enabled = true;
            txtCodigo.Enabled = false;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        public void limparCampos() 
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        public int cadastrarAtribuicoes(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbAtribuicao(nome) values (@nome);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            conexao.FecharConexao();

            return resp;

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarNovosCampos();
            btnNovo.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Por favor preencha o campo nome", "mensagem do sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
                txtNome.Focus();
            }
            else {
                if (cadastrarAtribuicoes(txtNome.Text) == 1) 
                {
                    MessageBox.Show("Atribuição cadastrada com sucesso!", "mensagem do sistema",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limparCampos();
                    desabilitarCampos();
                }            
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.ShowDialog();
            this.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPesquisar frmPesquisar = new frmPesquisar();
            frmPesquisar.ShowDialog();
            this.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
