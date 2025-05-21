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
    public partial class frmGerenciarUsuarios : Form
    {
       
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmGerenciarUsuarios()
        {
            InitializeComponent();
            //executando o método desabilitar campos
            desabilitarCampos();
        }

        public frmGerenciarUsuarios(string nome) 
        {
  
            InitializeComponent();
            //executando o método desabilitar campos
            desabilitarCampos();
            txtUsuario.Text = nome;
            buscarUsuarioExistente(txtUsuario.Text);
        }

        //desabilitar campos
        public void desabilitarCampos()
        {
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtValidaSenha.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        //habilitar campos
        public void habilitarCampos()
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtValidaSenha.Enabled = true;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            txtUsuario.Focus();
        }
        public void habilitarCamposUsuarioExistente() 
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtValidaSenha.Enabled = true;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = false;
            txtUsuario.Focus();
        }

        //desabilitar campos cadastrar
        public void desabilitarCamposCadastrar()
        {
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtValidaSenha.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
            txtUsuario.Clear();
            txtSenha.Clear();
            txtValidaSenha.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmGerenciarUsuarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //executando o método limpar campos
            limparCampos();
        }

        //criando o método limpar campos
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtValidaSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("")
              || txtSenha.Text.Equals("")
              || txtValidaSenha.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores.",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
                limparCampos();
            }
            else
            {
                if (txtSenha.Text.Length < 12 || txtValidaSenha.Text.Length < 12)
                {
                    MessageBox.Show("A senha tem que ser igual a 12 caracteres",
                       "Mensagem do sistema",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error,
                      MessageBoxDefaultButton.Button1
                      );
                    return;
                }
                if (txtSenha.Text.Equals(txtValidaSenha.Text))
                {
                    if (carregarUsuario(txtUsuario.Text, txtSenha.Text) == 1)
                    {
                        MessageBox.Show("Cadastrado com sucesso.",
                             "Mensagem do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1
                            );
                        desabilitarCamposCadastrar();
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
                else
                {
                    MessageBox.Show("A senha não é igual.",
                         "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                        );
                    txtSenha.Clear();
                    txtValidaSenha.Clear();
                    txtSenha.Focus();
                }
            }
        }
        private void txtValidaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtValidaSenha.Text.Equals(txtSenha.Text))
            {
                btnChecked.Visible = true;
            }
            else
            {
                if (txtValidaSenha.Text.Length == 12)
                {
                    btnCheckedFalse.Visible = true;
                    btnChecked.Visible = false;
                }
                else if (txtValidaSenha.Text.Length != 12) 
                {
                    btnChecked.Visible = false;
                    btnCheckedFalse.Visible = false;
                }
            }
        }

        private int carregarUsuario(string usuario, string senha)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios(nome,senha)values(@nome,@senha);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = usuario;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 12).Value = senha;

            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            conexao.FecharConexao();

            return resp;
        }

        public void buscarusuariosCadastrado() 
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbUsuarios order by nome desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            cbxUsuariosCadastrados.Items.Clear();

            while (DR.Read()) 
            {
                cbxUsuariosCadastrados.Items.Add(DR.GetString(0));
            }

            conexao.FecharConexao();
        }

        //Método alterar usuario

        private int alterarUsuario(string usuario, string senha,int codUsu) {
            MySqlCommand comm = new MySqlCommand( );
            comm.CommandText = "update tbUsuarios set nome = @nome, senha = @senha where codUsu = " + codUsu;
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,50).Value = usuario;
            comm.Parameters.Add("@senha",MySqlDbType.VarChar,12).Value = senha ;

            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();
            conexao.FecharConexao();

            return resp;

        }

        // Excluir usuario 

        private int excluirUsuario(int codUsu) 
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbUsuarios where codUsu = @codUsu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("codUsu", MySqlDbType.Int32).Value = codUsu;
            comm.Connection = conexao.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            conexao.FecharConexao();

            desabilitarCampos();
            limparCampos();

            return resp;

        }
        private void buscarPorCodigo() 
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbusuarios where codUsu = 1";
            comm.CommandType = CommandType.Text;

            comm.Connection = conexao.ObterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();
            txtCodigo.Text = DR.GetString(0);
            txtUsuario.Text = DR.GetString(1);
            txtSenha.Text = DR.GetString(2);
            conexao.FecharConexao();
        }
        private void cbxUsuariosCadastrados_Click(object sender, EventArgs e)
        {
            buscarusuariosCadastrado();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPesquisar frmPesquisar = new frmPesquisar();
            frmPesquisar.ShowDialog();
            this.Show();
        }

        private void buscarUsuarioExistente(string usuario)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where nome = @nome;";
            comm.CommandType = CommandType.Text;


            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = usuario;

            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            txtUsuario.Text = DR.GetString(1);
            txtSenha.Text = DR.GetString(2);

            conexao.FecharConexao();

            habilitarCamposUsuarioExistente();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (alterarUsuario(txtUsuario.Text,txtSenha.Text,int.Parse(txtCodigo.Text)) == 1 ){
                MessageBox.Show("Usuario alterado com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                desabilitarCampos();
                limparCampos();
            }
            else {
                MessageBox.Show("Erro ao alterar", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult excluir = MessageBox.Show("Deseja excluir o usuario?", "mensagem do sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (excluir == DialogResult.Yes)
            {
                if (excluirUsuario(int.Parse(txtCodigo.Text)) == 1)
                {
                    MessageBox.Show("Usuario excluido com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    desabilitarCampos();
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Usuario não excluido", "mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    desabilitarCampos();
                    limparCampos();
                }
            }
            else{
            }
        }
    }
}
