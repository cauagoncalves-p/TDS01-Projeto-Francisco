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
    public partial class frmGerenciaVoluntario : Form
    {
        public frmGerenciaVoluntario()
        {
            InitializeComponent();
            carregaAtribuicoes();
        }

        public int cadastrarVoluntario(string nome, string email, string telCel,string endereco,
            string cep,string numero, string bairro, string cidade, string estado, 
            int codAtr, DateTime data, DateTime hora, int status) 
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbVoluntario(nome,email,telCel,endereco,numero,cep,bairro,cidade,estado,codAtr,data_,hora,status_) values (@nome,@email,@telCel,@endereco,@numero,@cep,@bairro,@cidade,@estado,@codAtr,@data_,@hora,@status_);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 15).Value = telCel;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = endereco;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 9).Value = numero;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = cep;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = cidade;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = estado;
            comm.Parameters.Add("@codAtr", MySqlDbType.Int32).Value = codAtr;
            comm.Parameters.Add("@data_", MySqlDbType.Date).Value = data;
            comm.Parameters.Add("@hora", MySqlDbType.Time).Value = hora;
            comm.Parameters.Add("@status_", MySqlDbType.Bit).Value = status;

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.ShowDialog();  
            this.Show();
        }
    }
}
