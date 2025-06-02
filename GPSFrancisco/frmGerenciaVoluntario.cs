using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MosaicoSolutions.ViaCep;
using System.Reflection.Emit;

namespace GPSFrancisco
{
    public partial class frmGerenciaVoluntario : Form
    {
        public frmGerenciaVoluntario()
        {
            InitializeComponent();
            carregaAtribuicoes();
            desabilitarCamposNovo();
        }

        public frmGerenciaVoluntario(string nome)
        {
            InitializeComponent();
            carregaAtribuicoes();
            desabilitarCamposNovo();
            txtNome.Text = nome;    
        }

        public void limparCampos(){
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            mkdCEP.Clear();
            txtComplemento.Clear();
            lblTelefone.Enabled = true;
            cbxAtribuicao.Text = "";
            cbxEstado.Text = "";
            cbStatus.Checked = false;
            dtpData.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now; 
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = true;
            txtNome.Focus();
            desabilitarCamposNovo();
        }
        public void habiitarCamposNovos(){
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            mkdCEP.Enabled = true;
            txtComplemento.Enabled = true;
            mkdTelefone.Enabled = true;
            cbxEstado.Enabled = true;
            cbStatus.Enabled = true;
            dtpData.Enabled = true;
            dtpHora.Enabled = true;
            cbxAtribuicao.Enabled = true;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = true;
            txtNome.Focus();
        }

        public void desabilitarCamposNovo() {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            mkdCEP.Enabled = false;
            txtComplemento.Enabled = false;
            mkdTelefone.Enabled = false;
            cbxEstado.Enabled = false;
            cbxAtribuicao.Enabled = false;  
            cbStatus.Enabled = false;
            dtpData.Enabled = false;
            dtpHora.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;
            txtNome.Focus();
        }
        public int cadastrarVoluntario(string nome, string email, string telCel,string endereco,
            string cep,string numero, string bairro, string cidade, string estado, 
            DateTime data, DateTime hora, int status) 
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbVoluntario(nome,email,telCel,endereco,numero,cep,bairro,cidade,estado,codAtr,data_,hora,status_) values (@nome,@email,@telCel,@endereco,@numero,@cep,@bairro,@cidade,@estado,@codAtr,@data_,@hora,@status_);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 15).Value = telCel;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = endereco;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 9).Value = numero;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = cep;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = cidade;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = estado;
            comm.Parameters.Add("@codAtr", MySqlDbType.Int32).Value = codigoAtribuicao;
            comm.Parameters.Add("@data_", MySqlDbType.Date).Value = data;
            comm.Parameters.Add("@hora", MySqlDbType.Time).Value = hora;
            comm.Parameters.Add("@status_", MySqlDbType.Bit).Value = status;

            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            conexao.FecharConexao();

            return resp;
        }


        public void carregaAtribuicoes()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbAtribuicao order by nome;";
            comm.CommandType = CommandType.Text;

            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbxAtribuicao.Items.Add(DR.GetString(1));
            }

            conexao.FecharConexao();
        }

        //buscando código da atribuição carregada na combo
        public int buscaCodigoAtribuicoes(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codAtr from tbatribuicoes where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = conexao.ObterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            int codAtr = DR.GetInt32(0);
            conexao.FecharConexao();

            return codAtr;
        }

        private int buscarCodigoAtribuicoes(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codAtr from tbAtribuicao where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();

            int res = DR.GetInt32(0);

            conexao.FecharConexao();

            return res;
        }

        int codigoAtribuicao;
        private void cbxAtribuicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoAtribuicao = buscarCodigoAtribuicoes(cbxAtribuicao.SelectedItem.ToString());
        }

        public void buscaCEP(string cep) {
            var viaCEPService = ViaCepService.Default();
            try
            {
                var endereco = viaCEPService.ObterEndereco(cep);

                txtEndereco.Text = endereco.Logradouro.ToString();
                txtCidade.Text = endereco.Localidade.ToString();
                txtBairro.Text = endereco.ToString();
                cbxEstado.Text = endereco.UF.ToString();
            }
            catch (Exception) {
                MessageBox.Show("Cep não encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mkdCEP.Clear();
                mkdCEP.Focus();
            }
           
        }
        private void mkdCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                buscaCEP(mkdCEP.Text);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habiitarCamposNovos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //verificando se os campos foram preenchidos
            if (txtNome.Text.Equals("") ||
                txtEmail.Text.Equals("") ||
                mkdTelefone.Text.Equals("(  )      -") ||
                txtEndereco.Text.Equals("") ||
                txtNumero.Text.Equals("") ||
                mkdCEP.Text.Equals("     -") ||
                txtComplemento.Equals("") ||
                txtBairro.Text.Equals("") ||
                txtCidade.Text.Equals("") ||
                cbxEstado.Text.Equals("") ||
                cbxAtribuicao.Text.Equals("") ||
                cbStatus.Checked == false
                )
            {
                MessageBox.Show("Favor preencher os campos",
                    "Messagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtNome.Focus();
            }
            else
            {
                if (cadastrarVoluntario(txtNome.Text, txtEmail.Text, mkdTelefone.Text, mkdCEP.Text, mkdCEP.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text,
                    cbxEstado.Text, dtpData.Value, dtpHora.Value, cbStatus.Checked ? 1 : 0
                    ) == 1) {
                MessageBox.Show("Cadastrado com sucesso.",
                    "Messagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
                desabilitarCamposNovo();
                }
                 else
                    {
                    MessageBox.Show("Erro ao cadastrar.",
                        "Mensagem do sistemas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    }
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.ShowDialog();
            this.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPesquisarVoluntarios frmPesquisarVoluntarios = new frmPesquisarVoluntarios();
            frmPesquisarVoluntarios.ShowDialog();
            this.Show();
        }
    }
}
