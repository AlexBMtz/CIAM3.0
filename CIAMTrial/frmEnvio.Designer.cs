namespace CIAMTrial
{
    partial class frmEnvio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.requestDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depatureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDatosEnvio = new MetroFramework.Controls.MetroPanel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.lblFolio = new MetroFramework.Controls.MetroLabel();
            this.lblFechaSalida = new MetroFramework.Controls.MetroLabel();
            this.lblCantidadProducto = new MetroFramework.Controls.MetroLabel();
            this.lblNombreProducto = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.txtFolio = new MetroFramework.Controls.MetroTextBox();
            this.dtFecha = new MetroFramework.Controls.MetroDateTime();
            this.cmbCantidad = new MetroFramework.Controls.MetroComboBox();
            this.cmbProducto = new MetroFramework.Controls.MetroComboBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDetailBindingSource)).BeginInit();
            this.pnlDatosEnvio.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.AutoGenerateColumns = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.folioDataGridViewTextBoxColumn,
            this.depatureTimeDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.requestDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.requestDetailBindingSource;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle20;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.Location = new System.Drawing.Point(23, 87);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(312, 287);
            this.grdDatos.TabIndex = 0;
            // 
            // requestDetailBindingSource
            // 
            this.requestDetailBindingSource.DataSource = typeof(CIAMTrial.Data.RequestDetail);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // folioDataGridViewTextBoxColumn
            // 
            this.folioDataGridViewTextBoxColumn.DataPropertyName = "Folio";
            this.folioDataGridViewTextBoxColumn.HeaderText = "Folio";
            this.folioDataGridViewTextBoxColumn.Name = "folioDataGridViewTextBoxColumn";
            // 
            // depatureTimeDataGridViewTextBoxColumn
            // 
            this.depatureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepatureTime";
            this.depatureTimeDataGridViewTextBoxColumn.HeaderText = "DepatureTime";
            this.depatureTimeDataGridViewTextBoxColumn.Name = "depatureTimeDataGridViewTextBoxColumn";
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // requestDataGridViewTextBoxColumn
            // 
            this.requestDataGridViewTextBoxColumn.DataPropertyName = "Request";
            this.requestDataGridViewTextBoxColumn.HeaderText = "Request";
            this.requestDataGridViewTextBoxColumn.Name = "requestDataGridViewTextBoxColumn";
            // 
            // pnlDatosEnvio
            // 
            this.pnlDatosEnvio.Controls.Add(this.cmbCantidad);
            this.pnlDatosEnvio.Controls.Add(this.cmbProducto);
            this.pnlDatosEnvio.Controls.Add(this.dtFecha);
            this.pnlDatosEnvio.Controls.Add(this.txtFolio);
            this.pnlDatosEnvio.Controls.Add(this.txtId);
            this.pnlDatosEnvio.Controls.Add(this.lblNombreProducto);
            this.pnlDatosEnvio.Controls.Add(this.lblCantidadProducto);
            this.pnlDatosEnvio.Controls.Add(this.lblFechaSalida);
            this.pnlDatosEnvio.Controls.Add(this.lblFolio);
            this.pnlDatosEnvio.Controls.Add(this.lblId);
            this.pnlDatosEnvio.HorizontalScrollbarBarColor = true;
            this.pnlDatosEnvio.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatosEnvio.HorizontalScrollbarSize = 10;
            this.pnlDatosEnvio.Location = new System.Drawing.Point(362, 109);
            this.pnlDatosEnvio.Name = "pnlDatosEnvio";
            this.pnlDatosEnvio.Size = new System.Drawing.Size(309, 221);
            this.pnlDatosEnvio.TabIndex = 1;
            this.pnlDatosEnvio.VerticalScrollbarBarColor = true;
            this.pnlDatosEnvio.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatosEnvio.VerticalScrollbarSize = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(3, 48);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(38, 19);
            this.lblFolio.TabIndex = 3;
            this.lblFolio.Text = "Folio";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(3, 81);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(99, 19);
            this.lblFechaSalida.TabIndex = 4;
            this.lblFechaSalida.Text = "Fecha de salida";
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Location = new System.Drawing.Point(3, 153);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(139, 19);
            this.lblCantidadProducto.TabIndex = 5;
            this.lblCantidadProducto.Text = "Cantidad de producto";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(3, 118);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(139, 19);
            this.lblNombreProducto.TabIndex = 6;
            this.lblNombreProducto.Text = "Nombre del Producto";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestDetailBindingSource, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(197, 15);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(92, 23);
            this.txtId.TabIndex = 7;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFolio
            // 
            // 
            // 
            // 
            this.txtFolio.CustomButton.Image = null;
            this.txtFolio.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtFolio.CustomButton.Name = "";
            this.txtFolio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFolio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFolio.CustomButton.TabIndex = 1;
            this.txtFolio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFolio.CustomButton.UseSelectable = true;
            this.txtFolio.CustomButton.Visible = false;
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestDetailBindingSource, "Folio", true));
            this.txtFolio.Lines = new string[0];
            this.txtFolio.Location = new System.Drawing.Point(108, 44);
            this.txtFolio.MaxLength = 32767;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.PasswordChar = '\0';
            this.txtFolio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFolio.SelectedText = "";
            this.txtFolio.SelectionLength = 0;
            this.txtFolio.SelectionStart = 0;
            this.txtFolio.ShortcutsEnabled = true;
            this.txtFolio.Size = new System.Drawing.Size(181, 23);
            this.txtFolio.TabIndex = 9;
            this.txtFolio.UseSelectable = true;
            this.txtFolio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFolio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtFecha
            // 
            this.dtFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestDetailBindingSource, "DepatureTime", true));
            this.dtFecha.Location = new System.Drawing.Point(108, 73);
            this.dtFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(181, 29);
            this.dtFecha.TabIndex = 12;
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestDetailBindingSource, "ProductQuantity", true));
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.ItemHeight = 23;
            this.cmbCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbCantidad.Location = new System.Drawing.Point(148, 143);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(141, 29);
            this.cmbCantidad.TabIndex = 14;
            this.cmbCantidad.UseSelectable = true;
            // 
            // cmbProducto
            // 
            this.cmbProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestDetailBindingSource, "ProductName", true));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.ItemHeight = 23;
            this.cmbProducto.Items.AddRange(new object[] {
            "Agua embotellada",
            "Arroz Bolsa",
            "Comida enlatada",
            "Comida para bebés",
            "Desechables",
            "Frijol Bolsa",
            "Jabón",
            "Medicamentos",
            "Pañales",
            "Papel Higiénico",
            "Sopa enlatada",
            "Ropa",
            "Toallas Sanitarias"});
            this.cmbProducto.Location = new System.Drawing.Point(148, 108);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(141, 29);
            this.cmbProducto.TabIndex = 13;
            this.cmbProducto.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(510, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(429, 398);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(348, 398);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(591, 398);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(267, 398);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 469);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlDatosEnvio);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmEnvio";
            this.Text = "Envío";
            this.Load += new System.EventHandler(this.frmEnvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDetailBindingSource)).EndInit();
            this.pnlDatosEnvio.ResumeLayout(false);
            this.pnlDatosEnvio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depatureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource requestDetailBindingSource;
        private MetroFramework.Controls.MetroPanel pnlDatosEnvio;
        private MetroFramework.Controls.MetroDateTime dtFecha;
        private MetroFramework.Controls.MetroTextBox txtFolio;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblNombreProducto;
        private MetroFramework.Controls.MetroLabel lblCantidadProducto;
        private MetroFramework.Controls.MetroLabel lblFechaSalida;
        private MetroFramework.Controls.MetroLabel lblFolio;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroComboBox cmbCantidad;
        private MetroFramework.Controls.MetroComboBox cmbProducto;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnAgregar;
    }
}