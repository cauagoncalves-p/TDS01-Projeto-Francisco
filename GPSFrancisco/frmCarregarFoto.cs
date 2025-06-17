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
    public partial class frmCarregarFoto : Form
    {
        public frmCarregarFoto()
        {
            InitializeComponent();
        }

        private void btnInserirFotos_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)| *.jpg|PNG Files(*.png)|*.png|AllFiles(*.*) | *.*";

            if (ofd.ShowDialog() == DialogResult.OK) {
                string foto = ofd.FileName.ToString();
                txtBuscaFotos.Text = foto;
                picFotos.ImageLocation = foto;
            }
        }

        private void btnSalvarFotos_Click(object sender, EventArgs e)
        {
            if (picFotos.Image != null)
            {
                byte[] imagem_byte = null;

                FileStream fs = new FileStream(this.txtBuscaFotos.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                imagem_byte = br.ReadBytes((int)fs.Length);

                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "insert into tbImagem(nome, campo_imagem) values (@nome, @campo_imagem);";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@campo_imagem", MySqlDbType.LongBlob).Value = imagem_byte;
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;


                comm.Connection = conexao.ObterConexao();

                int resp = comm.ExecuteNonQuery();

                MessageBox.Show("Foto salva no banco de dados!!!" + resp);

                conexao.FecharConexao();
            }

            else {
                MessageBox.Show("Favor inserir um texto ou uma imagem");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecurparFotos frmRecurparFotos = new frmRecurparFotos();
            frmRecurparFotos.ShowDialog();
            this.Show();

        }
    }
}
