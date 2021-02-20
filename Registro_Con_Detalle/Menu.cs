using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_Con_Detalle.UI.Registros;

namespace Registro_Con_Detalle
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.rOrdenesToolStripMenuItem.Click += new EventHandler(this.rOdenesrOrdenesToolStripMenuItem_ItemClicked);

        }

        private void rOdenesrOrdenesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var rOrdenes = new rOrdenes();
            rOrdenes.MdiParent = this;
            rOrdenes.Show();
        }

    }
}
