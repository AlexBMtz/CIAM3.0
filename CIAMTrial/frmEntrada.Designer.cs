namespace CIAMTrial
{
    partial class frmEntrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.cmbCantidad = new MetroFramework.Controls.MetroComboBox();
            this.CmbTipo = new MetroFramework.Controls.MetroComboBox();
            this.dtFecha = new MetroFramework.Controls.MetroDateTime();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblTipo = new MetroFramework.Controls.MetroLabel();
            this.lblCantidad = new MetroFramework.Controls.MetroLabel();
            this.lblFechaDeAdmision = new MetroFramework.Controls.MetroLabel();
            this.lblNombreDonante = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.donationDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donationDetailBindingSource)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.donorNameDataGridViewTextBoxColumn,
            this.admissionDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.donationTypeDataGridViewTextBoxColumn,
            this.donationDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.donationDetailBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.Location = new System.Drawing.Point(23, 63);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(278, 305);
            this.grdDatos.TabIndex = 0;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.Controls.Add(this.txtId);
            this.pnlDatos.Controls.Add(this.cmbCantidad);
            this.pnlDatos.Controls.Add(this.CmbTipo);
            this.pnlDatos.Controls.Add(this.dtFecha);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.lblTipo);
            this.pnlDatos.Controls.Add(this.lblCantidad);
            this.pnlDatos.Controls.Add(this.lblFechaDeAdmision);
            this.pnlDatos.Controls.Add(this.lblNombreDonante);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(317, 103);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(354, 203);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationDetailBindingSource, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(147, 20);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(200, 23);
            this.txtId.TabIndex = 10;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationDetailBindingSource, "Quantity", true));
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
            this.cmbCantidad.Location = new System.Drawing.Point(147, 115);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(121, 29);
            this.cmbCantidad.TabIndex = 9;
            this.cmbCantidad.UseSelectable = true;
            // 
            // CmbTipo
            // 
            this.CmbTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationDetailBindingSource, "DonationType", true));
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.ItemHeight = 23;
            this.CmbTipo.Items.AddRange(new object[] {
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
            this.CmbTipo.Location = new System.Drawing.Point(147, 150);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(121, 29);
            this.CmbTipo.TabIndex = 8;
            this.CmbTipo.UseSelectable = true;
            // 
            // dtFecha
            // 
            this.dtFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationDetailBindingSource, "AdmissionDate", true));
            this.dtFecha.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.donationDetailBindingSource, "AdmissionDate", true));
            this.dtFecha.Location = new System.Drawing.Point(147, 80);
            this.dtFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 29);
            this.dtFecha.TabIndex = 7;
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationDetailBindingSource, "DonorName", true));
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(147, 51);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(7, 160);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 19);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 125);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 19);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblFechaDeAdmision
            // 
            this.lblFechaDeAdmision.AutoSize = true;
            this.lblFechaDeAdmision.Location = new System.Drawing.Point(7, 90);
            this.lblFechaDeAdmision.Name = "lblFechaDeAdmision";
            this.lblFechaDeAdmision.Size = new System.Drawing.Size(121, 19);
            this.lblFechaDeAdmision.TabIndex = 3;
            this.lblFechaDeAdmision.Text = "Fecha de Admisión";
            // 
            // lblNombreDonante
            // 
            this.lblNombreDonante.AutoSize = true;
            this.lblNombreDonante.Location = new System.Drawing.Point(7, 55);
            this.lblNombreDonante.Name = "lblNombreDonante";
            this.lblNombreDonante.Size = new System.Drawing.Size(134, 19);
            this.lblNombreDonante.TabIndex = 2;
            this.lblNombreDonante.Text = "Nombre del Donante";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(515, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(434, 390);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(353, 390);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(596, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(272, 390);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // donationDetailBindingSource
            // 
            this.donationDetailBindingSource.DataSource = typeof(CIAMTrial.Data.DonationDetail);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // donorNameDataGridViewTextBoxColumn
            // 
            this.donorNameDataGridViewTextBoxColumn.DataPropertyName = "DonorName";
            this.donorNameDataGridViewTextBoxColumn.HeaderText = "DonorName";
            this.donorNameDataGridViewTextBoxColumn.Name = "donorNameDataGridViewTextBoxColumn";
            // 
            // admissionDateDataGridViewTextBoxColumn
            // 
            this.admissionDateDataGridViewTextBoxColumn.DataPropertyName = "AdmissionDate";
            this.admissionDateDataGridViewTextBoxColumn.HeaderText = "AdmissionDate";
            this.admissionDateDataGridViewTextBoxColumn.Name = "admissionDateDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // donationTypeDataGridViewTextBoxColumn
            // 
            this.donationTypeDataGridViewTextBoxColumn.DataPropertyName = "DonationType";
            this.donationTypeDataGridViewTextBoxColumn.HeaderText = "DonationType";
            this.donationTypeDataGridViewTextBoxColumn.Name = "donationTypeDataGridViewTextBoxColumn";
            // 
            // donationDataGridViewTextBoxColumn
            // 
            this.donationDataGridViewTextBoxColumn.DataPropertyName = "Donation";
            this.donationDataGridViewTextBoxColumn.HeaderText = "Donation";
            this.donationDataGridViewTextBoxColumn.Name = "donationDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 469);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmEntrada";
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.frmEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donationDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroLabel lblTipo;
        private MetroFramework.Controls.MetroLabel lblCantidad;
        private MetroFramework.Controls.MetroLabel lblFechaDeAdmision;
        private MetroFramework.Controls.MetroLabel lblNombreDonante;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource donationDetailBindingSource;
        private MetroFramework.Controls.MetroDateTime dtFecha;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroComboBox cmbCantidad;
        private MetroFramework.Controls.MetroComboBox CmbTipo;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroTextBox txtId;
    }
}