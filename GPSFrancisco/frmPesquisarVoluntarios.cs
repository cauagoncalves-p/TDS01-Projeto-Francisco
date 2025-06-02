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
    public partial class frmPesquisarVoluntarios : Form
    {
        public frmPesquisarVoluntarios()
        {
            InitializeComponent();
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
            lboPesquisar.Items.Add(txtDescricao.Text);
        }
    }
}
