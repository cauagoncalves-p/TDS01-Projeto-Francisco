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
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
        }

        private void limparCampos() 
        {
            txtDescricao.Clear();
            lboPesquisar.Items.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        //pesquisar por codigo 

        public void pesquisarPorCodigo(int codigoUsu) 
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where codUsu = @codUsu";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("codUsu", MySqlDbType.Int32).Value = codigoUsu;

            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();


            lboPesquisar.Items.Add(DR.GetString(1));
            
            conexao.FecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked || rdbNome.Checked)
            {

                if (rdbCodigo.Checked && !txtDescricao.Text.Equals(""))
                {
                    try
                    {
                        pesquisarPorCodigo(Convert.ToInt32(txtDescricao.Text));
                        txtDescricao.Focus();
                    }
                    catch (Exception) 
                    {
                        MessageBox.Show("Por favor, inserir apenas numeros");
                        txtDescricao.Clear();
                        txtDescricao.Focus();
                    }
                   
                }
                else if (rdbNome.Checked && !txtDescricao.Text.Equals(""))
                {
                    pesquisarPorNome(txtDescricao.Text);
                    txtDescricao.Focus();
                }
                else 
                {
                    MessageBox.Show("Favor inserir um código ou nome","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecionar uma opção de busca", "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
         
        }

        private void pesquisarPorNome(string usuario) 
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where nome like '%" + usuario + "%';";
            comm.CommandType = CommandType.Text;

            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            while (DR.Read()){
                lboPesquisar.Items.Add(DR.GetString(1));
            }

            conexao.FecharConexao();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked) 
            {
                txtDescricao.Focus();
            }
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked){
                txtDescricao.Focus();            
            }
        }

        private void lboPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = lboPesquisar.SelectedItem.ToString();
            frmGerenciarUsuarios frmGerenciarUsuarios = new frmGerenciarUsuarios(nome);
            frmGerenciarUsuarios.ShowDialog();
        }

      
    }
}
