using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GPSFrancisco
{
    public partial class frmMenuPrincipal : Form

    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGerenciarUsuarios usuarios = new frmGerenciarUsuarios();
            usuarios.ShowDialog();
            this.Show();
        }

        private void btnAtribuicao_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAtribuicao frmAtribuicao = new frmAtribuicao();  
            frmAtribuicao.ShowDialog(); 
            this.Show();
        }

        private void btnVoluntarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGerenciaVoluntario frmGerenciaVoluntario = new frmGerenciaVoluntario();  
            frmGerenciaVoluntario.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastraProduto frmCadastraProduto = new frmCadastraProduto();   
            frmCadastraProduto.ShowDialog();
            this.Show();
        }
    }
}
