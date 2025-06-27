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
using GenCode128;
using QRCoder;

namespace GPSFrancisco
{
    public partial class frmCadastraProduto : Form
    {
        public frmCadastraProduto()
        {
            InitializeComponent();
            buscarUnidadeMedidas();
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            this.Show();
            frmGerenciarUnidades gerenciarUnidades = new frmGerenciarUnidades();
            gerenciarUnidades.ShowDialog();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.ShowDialog();
            this.Show();
        }

        private void buscarUnidadeMedidas()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbunidades order by unidade";
            comm.CommandType = CommandType.Text;

            comm.Connection = conexao.ObterConexao();

            MySqlDataReader reader = comm.ExecuteReader();


            while (reader.Read())
            {

                cbxUnidade.Items.Add(reader.GetString(2));
            }

            conexao.FecharConexao();

        }

        int codigoUnidade;
        private int cadastrarProdutos(int codBarras, string descricao, int quantidade, string lote, int codigoUnidade, DateTime dataEntrada
            , DateTime horaEntrada, DateTime validade) {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbProdutos (codBarras,descricao,quantidade,lote,dataEntr,horaEnt,validade,codUnid) values (@codBarras,@descricao,@quantidade,@lote,@dataEntr,@horaEnt,@validade,@codUnid)";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codBarras",MySqlDbType.Int32).Value = codBarras;
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = descricao;
            comm.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            comm.Parameters.Add("@lote", MySqlDbType.VarChar,10).Value = lote;
            comm.Parameters.Add("@dataEntr", MySqlDbType.Datetime).Value = dataEntrada;
            comm.Parameters.Add("@horaEntr", MySqlDbType.Datetime).Value = horaEntrada;
            comm.Parameters.Add("@validade", MySqlDbType.Datetime).Value = validade;
            comm.Parameters.Add("@codUnid", MySqlDbType.Int32).Value = codigoUnidade;

            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            return resp;

        }
        private int excluirProdutos (int codBarras)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbProdutos where codBarras = @codBarras";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codBarras", MySqlDbType.Int32).Value = codBarras;
            
            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            return resp;
        }

        private int AtualizarProdutos(int codBarras, string descricao, int quantidade, string lote, int codigoUnidade, DateTime dataEntrada
        , DateTime horaEntrada, DateTime validade)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbProdutos set codBarras = @codBarras,descricao = @descricao,quantidade = @quantidade,lote = @lote,dataEntr = @dataEntr ,horaEntr = @horaEnt, validade = @validade,codUnid = @codUnid";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codBarras", MySqlDbType.Int32).Value = codBarras;
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = descricao;
            comm.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            comm.Parameters.Add("@lote", MySqlDbType.VarChar, 10).Value = lote;
            comm.Parameters.Add("@dataEntr", MySqlDbType.Datetime).Value = dataEntrada;
            comm.Parameters.Add("@horaEntr", MySqlDbType.Datetime).Value = horaEntrada;
            comm.Parameters.Add("@validade", MySqlDbType.Datetime).Value = validade;
            comm.Parameters.Add("@codUnid", MySqlDbType.Int32).Value = codigoUnidade;

            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            return resp;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                Image image = Code128Rendering.MakeBarcodeImage(txtCodigoBarras.Text, 2, true);
                pcbCodigoBarras.Image = image;
            
            }
        }
    }
}
