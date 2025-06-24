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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using Org.BouncyCastle.Asn1.X509;

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
            carregaVoluntariosPorNome(txtNome.Text);
        }

        public void limparCampos()
        {
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
        public void habiitarCamposNovos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            btnInserirFoto.Enabled = true;
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
            pcbFotoVoluntario.Enabled = true;
            txtNome.Focus();
        }

        public void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            btnInserirFoto.Enabled = false;
            txtNumero.Enabled = false;
            mkdCEP.Enabled = false;
            pcbFotoVoluntario.Enabled = false;
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

        //habilitar campos ALTERAR
        public void habilitarCamposAlterar()
        {
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
            cbxAtribuicao.Enabled = true;
            cbxEstado.Enabled = true;
            dtpData.Enabled = true;
            dtpHora.Enabled = true;
            cbStatus.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            pcbFotoVoluntario.Enabled = true;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = true;
            txtNome.Focus();
        }

        public int cadastrarVoluntario(string nome, string email, string telCel, string endereco,
            string cep, string complemento,string numero, string bairro, string cidade, string estado,
            int codAtr, DateTime data, DateTime hora, int status, byte[] foto)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbVoluntario(nome,email,telCel,endereco,numero,cep,complemento,bairro,cidade,estado,codAtr,data_,hora,status_, foto) values (@nome,@email,@telCel,@endereco,@numero,@cep,@complemento,@bairro,@cidade,@estado,@codAtr,@data_,@hora,@status_, @foto);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 15).Value = telCel;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = endereco;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 9).Value = numero;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = cep;
            comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 100).Value = complemento;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = cidade;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = estado;
            comm.Parameters.Add("@codAtr", MySqlDbType.Int32).Value = codigoAtribuicao;
            comm.Parameters.Add("@data_", MySqlDbType.Datetime).Value = data;
            comm.Parameters.Add("@hora", MySqlDbType.Datetime).Value = hora;
            comm.Parameters.Add("@status_", MySqlDbType.Int32).Value = status;
            comm.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto;

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
            comm.CommandText = "select codAtr from tbatribuicao where nome = @nome;";
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
            comm.CommandText = "select codAtr from tbatribuicao where nome = @nome;";
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

        public void buscaCEP(string cep)
        {
            var viaCEPService = ViaCepService.Default();
            try
            {
                var endereco = viaCEPService.ObterEndereco(cep);

                txtEndereco.Text = endereco.Logradouro.ToString();
                txtCidade.Text = endereco.Localidade.ToString();
                txtBairro.Text = endereco.Bairro.ToString();
                cbxEstado.Text = endereco.UF.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Cep não encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mkdCEP.Clear();
                mkdCEP.Focus();
            }
        }

        private void carregaVoluntariosPorNome(string nome)
        {


            //public void carregaImagem()
            //{
            //    MySqlCommand comm = new MySqlCommand();
            //    string sql = "SELECT * FROM tbimagem";
            //    MySqlDataAdapter DA = new MySqlDataAdapter(sql, conexao.ObterConexao());
            //    DataTable dt = new DataTable();

            //    if (DA.Fill(dt) < 1)
            //    {
            //        MessageBox.Show("Sem registros no banco de dados");
            //    }
            //    else
            //    {

            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            dgvFotos.Rows.Add(dr.ItemArray);
            //        }

            //        DA.Dispose();
            //    }

            //    conexao.FecharConexao();
            //}

            //private void dataGridView1_SelectionChanged(object sender, EventArgs e)
            //{
            //    string nome = dgvFotos.SelectedRows[0].Cells[0].Value.ToString();

            //    MySqlCommand comm = new MySqlCommand();
            //    string sql = $"SELECT * FROM tbimagem where codImg like {nome}";
            //    MySqlDataAdapter DA = new MySqlDataAdapter(sql, conexao.ObterConexao());
            //    DataTable dt = new DataTable();
            //    DA.Fill(dt);
            //    byte[] image = (byte[])dt.Rows[0][2];
            //    MemoryStream ms = new MemoryStream(image);
            //    picFotos.Image = Image.FromStream(ms);

            //    conexao.FecharConexao();
            //}

            bool status = false;

            MySqlCommand comm = new MySqlCommand();
            string sql = "select * from tbvoluntario vol INNER join tbatribuicao atr on vol.codAtr = atr.codAtr where vol.nome = @nome;";
            comm.CommandText = sql ;
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();

            byte[] image = (byte[])DR.GetValue(15);
            MemoryStream ms = new MemoryStream(image);
        

            if (DR.GetInt32(14) == 1)
            {
                status = true;
            }

            if (DR.GetInt32(14) == 0)
            {
                status = false;
            }

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mkdTelefone.Text = DR.GetString(3);
            txtEndereco.Text = DR.GetString(4);
            txtNumero.Text = DR.GetString(5);
            mkdCEP.Text = DR.GetString(6);
            txtComplemento.Text = DR.GetString(7);
            txtBairro.Text = DR.GetString(8);
            txtCidade.Text = DR.GetString(9);
            cbxEstado.Text = DR.GetString(10);
            codigoAtribuicao = DR.GetInt32(11);
            dtpData.Value = DR.GetDateTime(12);
            dtpHora.Value = DR.GetDateTime(13);
            cbStatus.Checked = status;
            pcbFotoVoluntario.Image = Image.FromStream(ms);
            cbxAtribuicao.Text = DR.GetString(17);

            habilitarCamposAlterar();

            conexao.FecharConexao();
        }

        private void mkdCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
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
                byte[] imagem_byte = null;

                if (pcbFotoVoluntario.Image != null)
                {
                    FileStream fs = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);

                    imagem_byte = br.ReadBytes((int)fs.Length);
                }

                DateTime data = dtpData.Value;
                string dataFormatada = data.ToString("yyyy-MM-dd");
   

                if (cadastrarVoluntario(txtNome.Text,txtEmail.Text,mkdTelefone.Text,txtEndereco.Text,mkdCEP.Text,txtComplemento.Text,txtNumero.Text,txtBairro.Text,txtCidade.Text,cbxEstado.Text,codigoAtribuicao, Convert.ToDateTime(dataFormatada)
                    ,dtpHora.Value, cbStatus.Checked ? 1 : 0, imagem_byte
                    ) == 1)
                {
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
        string caminhoFoto;
        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)| *.jpg|PNG Files(*.png)|*.png|AllFiles(*.*) | *.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string foto = ofd.FileName.ToString();
                pcbFotoVoluntario.ImageLocation = foto;
                caminhoFoto = foto;
            }
        }

        public int excluirVoluntarios(int codVol) { 
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbVoluntario where codVol = @codVol;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codVol", MySqlDbType.Int32).Value = codVol;

            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();
            return resp;
        }

        public int alterarVolunrarios(string nome) {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update table from tbVoluntario where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar,100).Value = nome;
            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            return resp;
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int resp = alterarVolunrarios(txtNome.Text);

            if (resp == 1)
            {
                MessageBox.Show("Alterado com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            }
            else {
                MessageBox.Show("Alterado com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int resp = excluirVoluntarios(Convert.ToInt32(txtCodigo.Text));

                if (resp == 1)
                {
                    MessageBox.Show("Excluído com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                limparCampos();
                desabilitarCamposNovo();
                btnNovo.Enabled = true;
            }
        }
    }
}
