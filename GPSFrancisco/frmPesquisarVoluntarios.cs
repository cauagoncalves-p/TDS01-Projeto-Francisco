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
    public partial class frmPesquisarVoluntarios : Form
    {
        public frmPesquisarVoluntarios()
        {
            InitializeComponent();
        }

        public void habilitarCampos()
        {
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
            gpxPesquisar.Enabled = true;
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        public void limparCampos()
        {
            txtDescricao.Clear();
            lboPesquisar.Items.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
        }

        private void lboPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = lboPesquisar.SelectedItem.ToString();
            
            this.Hide();
            frmGerenciaVoluntario frmGerenciaVoluntario = new frmGerenciaVoluntario(nome);
            frmGerenciaVoluntario.ShowDialog();
            this.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!rdbCodigo.Checked && !rdbNome.Checked)
            {
                MessageBox.Show("Por favor, selecionar um item");
            }

            else if (txtDescricao.Equals("")) {
                MessageBox.Show("Favor inserir um valor");
                txtDescricao.Focus();
            }
            else
            {
                if (rdbCodigo.Checked) {
                    buscarVoluntarioPorCodigo(Convert.ToInt32(txtDescricao.Text));
                }

                if (rdbNome.Checked) {
                    buscarVoluntarioPorNome(txtDescricao.Text);
                }
            }
           
        }

        public void buscarVoluntarioPorCodigo(int codVol) {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVoluntario where codVol = @codVol";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codVol", MySqlDbType.Int32).Value = codVol;

            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            lboPesquisar.Items.Add(DR.GetInt32(0));

            conexao.FecharConexao();
        }


        public void buscarVoluntarioPorNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"select * from tbVoluntario where nome like = @'%{nome}%'";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Connection = conexao.ObterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while(DR.Read()){
                lboPesquisar.Items.Add(DR.GetString(1));
            }

            conexao.FecharConexao();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked) {
                habilitarCampos();
            }
        }


        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked) {
                habilitarCampos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos(); 
            
        }
    }
}
