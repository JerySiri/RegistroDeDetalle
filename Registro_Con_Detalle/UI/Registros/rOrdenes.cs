using Registro_Con_Detalle.Entidades;
using Registro_Con_Detalle.BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Registro_Con_Detalle.UI.Registros
{
    public partial class rOrdenes : Form
    {

        public List<OrdenesDetalle> Detalle { get; set; }

        public rOrdenes()
        {
            InitializeComponent();
            this.Detalle = new List<OrdenesDetalle>();
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();

            OrdenIdnumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            CantidadNumericUpDown.Value = 0;
            ProductoIdComboBox.SelectedIndex = 1;
            DescripcionTextBox.Clear();
            PrecioTextBox.Clear();
            InventarioTextBox.Clear();

            this.Detalle = new List<OrdenesDetalle>();
            CargarGrid();
        }

        private void CargarGrid()
        {
            OrdenesDataGridView.DataSource = null;
            OrdenesDataGridView.DataSource = this.Detalle;

        }

        private Ordenes LlenarClase()
        {
            Ordenes ordenes = new Ordenes();
            ordenes.OrdenesId = (int)OrdenIdnumericUpDown.Value;
            ordenes.Fecha = FechaDateTimePicker.Value;

            ordenes.OrdenesDetalles = this.Detalle;

            return ordenes;
        }

        private void LlenarCampos(Ordenes ordenes)
        {

            OrdenIdnumericUpDown.Value = ordenes.OrdenesId;
            FechaDateTimePicker.Value = ordenes.Fecha;

            this.Detalle = ordenes.OrdenesDetalles;
            CargarGrid();
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (OrdenIdnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(OrdenIdnumericUpDown, "No se puede guardar ningun campo con valor 0");
                OrdenIdnumericUpDown.Focus();
                paso = false;
            }

            if (CantidadNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CantidadNumericUpDown,"La cantidad debe ser mayor o igual a 1");
                CantidadNumericUpDown.Focus();
                paso = false;
            }

            if (DescripcionTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Este Campo no puede esta vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            if ((PrecioTextBox.Text == string.Empty) )
            {
                MyErrorProvider.SetError(PrecioTextBox, "Este Campo no puede estar vacio");
                PrecioTextBox.Focus();
                paso = false;
                //float resultado;
                //|| !float.TryParse(PrecioTextBox.Text, out resultado)
            }
          
            /*if (InventarioTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(InventarioTextBox, "Este Campo no puede estar vacio");
                InventarioTextBox.Focus();
                paso = false;
            }
            */
            if(this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(OrdenesDataGridView, "Debes Agregar un telefono");
                OrdenesGroupBox.Focus();
                paso = false;
            }

            return paso;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (OrdenesDataGridView.DataSource != null)
                this.Detalle = (List<OrdenesDetalle>)OrdenesDataGridView.DataSource;

            this.Detalle.Add(new OrdenesDetalle
                (
                    OrdenesDetalleId: 0,
                    OrdenesId: (int)OrdenIdnumericUpDown.Value,
                    ProductoId: (int)ProductoIdComboBox.SelectedIndex,
                    Descripcion: DescripcionTextBox.Text,
                    Cantidad: (int)CantidadNumericUpDown.Value,
                    precio: Convert.ToSingle(PrecioTextBox.Text) 
                )
            );
            CargarGrid();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (OrdenesDataGridView.Rows.Count > 0 || OrdenesDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(OrdenesDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Ordenes orden;
            bool paso = false;

            if (!Validar())
                return;

            orden = LlenarClase();

            paso = OrdenesBLL.Guardar(orden);

            if (!paso)
                MessageBox.Show("No fue posible guardar o modificar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            else
                    Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (OrdenesBLL.Eliminar((int) OrdenIdnumericUpDown.Value))
                Limpiar();
            else
                MessageBox.Show("No pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Ordenes orden = OrdenesBLL.Buscar((int)OrdenIdnumericUpDown.Value);

            if (orden != null)
               LlenarCampos(orden);
            else
                MessageBox.Show("Usuario No existe.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void rOrdenes_Load(object sender, EventArgs e)
        {
            ProductoIdComboBox.DataSource = ProductoBLL.GetRoles();
            ProductoIdComboBox.DisplayMember = "Nombre";
            ProductoIdComboBox.ValueMember = "ProductoId";
        }
    }
}
