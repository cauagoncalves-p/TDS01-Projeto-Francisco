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

namespace GPSFrancisco
{
    public partial class frmPesquisarUnidadeMedida : Form
    {
        public frmPesquisarUnidadeMedida()
        {
            InitializeComponent();
        }

        private void lboPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string descricao = lboPesquisar.SelectedItem.ToString();
            frmGerenciarUnidades unidades = new frmGerenciarUnidades(descricao);
            unidades.ShowDialog();
            this.Hide();
        }

        public void pesquisarPorCodigo(int codUni)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"select * from tbunidades where codUnid = {codUni}";
            comm.CommandType = CommandType.Text;

            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

           
            lboPesquisar.Items.Clear();

            lboPesquisar.Items.Add(DR.GetString(2));

            conexao.FecharConexao();
        }

        private void pesquisarPorNome(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"select * from tbunidades where descricao like '%{descricao}%'";
            comm.CommandType = CommandType.Text;

            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            while (DR.Read())
            {
                lboPesquisar.Items.Add(DR.GetString(1));
            }

            conexao.FecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked) {
                pesquisarPorCodigo(Convert.ToInt32(txtDescricao.Text));
                txtDescricao.Focus();
            }

            if (rdbNome.Checked)
            {
                pesquisarPorNome(txtDescricao.Text);
                txtDescricao.Focus();
            }
        }
    }
}
