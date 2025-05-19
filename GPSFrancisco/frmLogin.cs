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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conexao.ObterConexao();
            MessageBox.Show("Conectado com sucesso");
            conexao.FecharConexao();            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario, senha;

            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if (AcessarBanco(usuario,senha))
            {
                frmMenuPrincipal principal = new frmMenuPrincipal();
                principal.ShowDialog();
                this.Hide();
            }
            else {
                MessageBox.Show("Senha ou usuario incorretos!");
            }
        }

        private bool AcessarBanco(string nome, string senha) 
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome,senha from tbUsuarios where nome=@nome and senha=@senha";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome",MySqlDbType.VarChar,50).Value = nome;
            comm.Parameters.Add("@senha",MySqlDbType.VarChar,12).Value = senha;

            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR;
         
            DR = comm.ExecuteReader();

            bool resp = DR.HasRows;

            conexao.FecharConexao();
            return resp;
          
        }
    }
}
