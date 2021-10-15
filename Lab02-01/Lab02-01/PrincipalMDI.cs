using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }

        private void PrincipalMDI_Load(object sender, EventArgs e)
        {

        }

        private void mnuSisSalirDelSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            manUsuario frm = new manUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManProductos_Click(object sender, EventArgs e)
        {
            manProducto frm2 = new manProducto();
            frm2.MdiParent = this;
            frm2.Show();

        }

        private void mnuManCategorias_Click(object sender, EventArgs e)
        {
            manCategoria frm3 = new manCategoria();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void mnuManProveedores_Click(object sender, EventArgs e)
        {
            manProveedor frm = new manProveedor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManClientes_Click(object sender, EventArgs e)
        {
            manClientes frm = new manClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manCargo frm = new manCargo();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
