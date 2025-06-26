using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public partial class frmGerenciarUnidades : Form
    {
        public frmGerenciarUnidades()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmGerenciarUnidades(string descricao)
        {
            InitializeComponent();
            desabilitarCampos();
            PesquisarPorNome(txtDescricao.Text);
            txtUnidade.Text = descricao;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastraProduto produtos = new frmCadastraProduto(); 
            produtos.ShowDialog();
            this.Show();
        }

        private void habilitarCampos() {
            txtCodigoBarras.Enabled = false;
            txtDescricao.Enabled = true;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            txtUnidade.Enabled = true;
            btnLimpar.Enabled = false;
            btnExcluir.Enabled = false;

            btnNovo.Enabled = false;
            txtDescricao.Focus();
        }

        private void desabilitarCampos()
        {

            txtCodigoBarras.Enabled = false;    
            txtDescricao.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            txtUnidade.Enabled = false;
            btnLimpar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void limparCampos() {
            txtUnidade.Clear();
            txtDescricao.Clear();
            txtCodigoBarras.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        public int cadastrarProduto(string descricao, string unidade)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbunidades(descricao, unidade) values (@descricao, @unidade)";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar,50).Value = descricao;
            comm.Parameters.Add("@unidade", MySqlDbType.VarChar,2).Value = unidade;

            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            conexao.FecharConexao();

            return resp;
        }


        private int alterarProduto(string descricao, string unidade, int codUni)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbunidades set descricao = @descricao, unidade = @unidade where codUni = @codUni";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 50).Value = descricao;
            comm.Parameters.Add("@unidade", MySqlDbType.VarChar, 2).Value = unidade;
            comm.Parameters.Add("@codUni", MySqlDbType.Int32).Value = codUni;


            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            conexao.FecharConexao();

            return resp;
        }

        private int alterarProduto(int codUni)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbunidades where codUni = codUni";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUni", MySqlDbType.Int32).Value = codUni;


            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            conexao.FecharConexao();

            return resp;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            habilitarCampos();

            if (txtDescricao.Text.Equals("") || txtUnidade.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores");
                txtDescricao.Focus();
            }

            else {

                if (cadastrarProduto(txtDescricao.Text, txtUnidade.Text) == 1) {
                    MessageBox.Show("Cadastrado com sucesso");
                    desabilitarCampos();
                    limparCampos();
                }
            }
        }

        public void PesquisarPorNome(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"SELECT * from tbunidades where descricao = @descricao";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar,50).Value = descricao;
            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR = comm.ExecuteReader();

            DR.Read();

            txtCodigoBarras.Text = Convert.ToString(DR.GetInt32(0));
            txtDescricao.Text = Convert.ToString(DR.GetString(1));
            txtUnidade.Text = Convert.ToString(DR.GetString(2));

            conexao.FecharConexao();

        }
    }
}
