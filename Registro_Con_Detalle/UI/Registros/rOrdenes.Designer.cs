
namespace Registro_Con_Detalle.UI.Registros
{
    partial class rOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OrdenIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProductoIdComboBox = new System.Windows.Forms.ComboBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.InventarioTextBox = new System.Windows.Forms.TextBox();
            this.OrdenesGroupBox = new System.Windows.Forms.GroupBox();
            this.OrdenesDataGridView = new System.Windows.Forms.DataGridView();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.OrdenIdLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.ProductoLabel = new System.Windows.Forms.Label();
            this.InventarioLabel = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenIdnumericUpDown)).BeginInit();
            this.OrdenesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(70, 22);
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(66, 23);
            this.CantidadNumericUpDown.TabIndex = 0;
            // 
            // OrdenIdnumericUpDown
            // 
            this.OrdenIdnumericUpDown.Location = new System.Drawing.Point(103, 9);
            this.OrdenIdnumericUpDown.Name = "OrdenIdnumericUpDown";
            this.OrdenIdnumericUpDown.Size = new System.Drawing.Size(55, 23);
            this.OrdenIdnumericUpDown.TabIndex = 1;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(103, 39);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(91, 23);
            this.FechaDateTimePicker.TabIndex = 2;
            // 
            // ProductoIdComboBox
            // 
            this.ProductoIdComboBox.FormattingEnabled = true;
            this.ProductoIdComboBox.Location = new System.Drawing.Point(103, 68);
            this.ProductoIdComboBox.Name = "ProductoIdComboBox";
            this.ProductoIdComboBox.Size = new System.Drawing.Size(152, 23);
            this.ProductoIdComboBox.TabIndex = 3;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(84, 57);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(261, 23);
            this.DescripcionTextBox.TabIndex = 4;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(188, 22);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(157, 23);
            this.PrecioTextBox.TabIndex = 5;
            // 
            // InventarioTextBox
            // 
            this.InventarioTextBox.Location = new System.Drawing.Point(103, 97);
            this.InventarioTextBox.Name = "InventarioTextBox";
            this.InventarioTextBox.Size = new System.Drawing.Size(152, 23);
            this.InventarioTextBox.TabIndex = 6;
            // 
            // OrdenesGroupBox
            // 
            this.OrdenesGroupBox.Controls.Add(this.OrdenesDataGridView);
            this.OrdenesGroupBox.Controls.Add(this.RemoverButton);
            this.OrdenesGroupBox.Controls.Add(this.AgregarButton);
            this.OrdenesGroupBox.Controls.Add(this.CantidadLabel);
            this.OrdenesGroupBox.Controls.Add(this.DescripcionLabel);
            this.OrdenesGroupBox.Controls.Add(this.PrecioLabel);
            this.OrdenesGroupBox.Controls.Add(this.CantidadNumericUpDown);
            this.OrdenesGroupBox.Controls.Add(this.PrecioTextBox);
            this.OrdenesGroupBox.Controls.Add(this.DescripcionTextBox);
            this.OrdenesGroupBox.Location = new System.Drawing.Point(19, 135);
            this.OrdenesGroupBox.Name = "OrdenesGroupBox";
            this.OrdenesGroupBox.Size = new System.Drawing.Size(485, 280);
            this.OrdenesGroupBox.TabIndex = 7;
            this.OrdenesGroupBox.TabStop = false;
            this.OrdenesGroupBox.Text = "Agregar Ordenes";
            // 
            // OrdenesDataGridView
            // 
            this.OrdenesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdenesDataGridView.Location = new System.Drawing.Point(7, 85);
            this.OrdenesDataGridView.Name = "OrdenesDataGridView";
            this.OrdenesDataGridView.RowTemplate.Height = 25;
            this.OrdenesDataGridView.Size = new System.Drawing.Size(472, 157);
            this.OrdenesDataGridView.TabIndex = 2;
            this.OrdenesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RemoverButton
            // 
            this.RemoverButton.Location = new System.Drawing.Point(7, 248);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(136, 23);
            this.RemoverButton.TabIndex = 1;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(372, 31);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(107, 23);
            this.AgregarButton.TabIndex = 0;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Location = new System.Drawing.Point(9, 26);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(55, 15);
            this.CantidadLabel.TabIndex = 11;
            this.CantidadLabel.Text = "Cantidad";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(9, 60);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(69, 15);
            this.DescripcionLabel.TabIndex = 13;
            this.DescripcionLabel.Text = "Descripcion";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Location = new System.Drawing.Point(142, 26);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(40, 15);
            this.PrecioLabel.TabIndex = 14;
            this.PrecioLabel.Text = "Precio";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(164, 9);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(30, 23);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // OrdenIdLabel
            // 
            this.OrdenIdLabel.AutoSize = true;
            this.OrdenIdLabel.Location = new System.Drawing.Point(19, 11);
            this.OrdenIdLabel.Name = "OrdenIdLabel";
            this.OrdenIdLabel.Size = new System.Drawing.Size(54, 15);
            this.OrdenIdLabel.TabIndex = 9;
            this.OrdenIdLabel.Text = "Orden ID";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(19, 39);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(38, 15);
            this.FechaLabel.TabIndex = 10;
            this.FechaLabel.Text = "Fecha";
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Location = new System.Drawing.Point(19, 71);
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.Size = new System.Drawing.Size(56, 15);
            this.ProductoLabel.TabIndex = 12;
            this.ProductoLabel.Text = "Producto";
            // 
            // InventarioLabel
            // 
            this.InventarioLabel.AutoSize = true;
            this.InventarioLabel.Location = new System.Drawing.Point(19, 100);
            this.InventarioLabel.Name = "InventarioLabel";
            this.InventarioLabel.Size = new System.Drawing.Size(60, 15);
            this.InventarioLabel.TabIndex = 15;
            this.InventarioLabel.Text = "Inventario";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(126, 450);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 16;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(207, 450);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 17;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(289, 450);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 18;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 482);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.InventarioLabel);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.OrdenIdLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.OrdenesGroupBox);
            this.Controls.Add(this.InventarioTextBox);
            this.Controls.Add(this.ProductoIdComboBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.OrdenIdnumericUpDown);
            this.Name = "rOrdenes";
            this.Text = "Registro De Ordenes";
            this.Load += new System.EventHandler(this.rOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenIdnumericUpDown)).EndInit();
            this.OrdenesGroupBox.ResumeLayout(false);
            this.OrdenesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.NumericUpDown OrdenIdnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.ComboBox ProductoIdComboBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox InventarioTextBox;
        private System.Windows.Forms.GroupBox OrdenesGroupBox;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label OrdenIdLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.Label InventarioLabel;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.DataGridView OrdenesDataGridView;
    }
}