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
        }
    }
