using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public partial class frmRecurparFotos : Form
    {
        public frmRecurparFotos()
        {
            InitializeComponent();
            carregaImagem();
        }

        public void carregaImagem() {
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT * FROM tbimagem";
            MySqlDataAdapter DA = new MySqlDataAdapter(sql, conexao.ObterConexao());
            DataTable dt = new DataTable();

            if (DA.Fill(dt) < 1)
            {
                MessageBox.Show("Sem registros no banco de dados");
            }
            else {

                foreach (DataRow dr in dt.Rows) 
                {
                    dgvFotos.Rows.Add(dr.ItemArray);
                }

                DA.Dispose();
            }

            conexao.FecharConexao();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string nome = dgvFotos.SelectedRows[0].Cells[0].Value.ToString();

            MySqlCommand comm = new MySqlCommand();
            string sql = $"SELECT * FROM tbimagem where codImg like {nome}";
            MySqlDataAdapter DA = new MySqlDataAdapter(sql, conexao.ObterConexao());
            DataTable dt = new DataTable();
            DA.Fill(dt);
            byte[] image = (byte[])dt.Rows[0][2];
            MemoryStream ms = new MemoryStream(image);
            picFotos.Image = Image.FromStream(ms);

            conexao.FecharConexao();
        }
    }
}
