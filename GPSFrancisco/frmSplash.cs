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
    public partial class frmSplash : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (pgbPorcentagem.Value < 100)
            {
                pgbPorcentagem.Value = pgbPorcentagem.Value + 10;
                lblPorcentagem.Text = pgbPorcentagem.Value.ToString() + "%";

                if (pgbPorcentagem.Value == 100) 
                {
                    tmrSplash.Enabled = false;
                    this.Hide();
                    frmLogin abrir = new frmLogin();
                    abrir.ShowDialog();
                    
                }
               
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}
