namespace CIAMTrial
{
    partial class frmCentro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatosCentro = new MetroFramework.Controls.MetroPanel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblEmpleadoACargo = new MetroFramework.Controls.MetroLabel();
            this.lblCodigoPostal = new MetroFramework.Controls.MetroLabel();
            this.txtEmpleadoACargo = new MetroFramework.Controls.MetroTextBox();
            this.txtCodigoPostal = new MetroFramework.Controls.MetroTextBox();
            this.txtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefono = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreCentro = new MetroFramework.Controls.MetroTextBox();
            this.lblDireccion = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.lblTelefono = new MetroFramework.Controls.MetroLabel();
            this.lblNombreCentro = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerBindingSource)).BeginInit();
            this.pnlDatosCentro.SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.managerEmployeeDataGridViewTextBoxColumn,
            this.productsDataGridViewTextBoxColumn,
            this.employeesDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.centerBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.Location = new System.Drawing.Point(12, 63);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(398, 254);
            this.grdDatos.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            // 
            // managerEmployeeDataGridViewTextBoxColumn
            // 
            this.managerEmployeeDataGridViewTextBoxColumn.DataPropertyName = "ManagerEmployee";
            this.managerEmployeeDataGridViewTextBoxColumn.HeaderText = "ManagerEmployee";
            this.managerEmployeeDataGridViewTextBoxColumn.Name = "managerEmployeeDataGridViewTextBoxColumn";
            // 
            // productsDataGridViewTextBoxColumn
            // 
            this.productsDataGridViewTextBoxColumn.DataPropertyName = "Products";
            this.productsDataGridViewTextBoxColumn.HeaderText = "Products";
            this.productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            // 
            // employeesDataGridViewTextBoxColumn
            // 
            this.employeesDataGridViewTextBoxColumn.DataPropertyName = "Employees";
            this.employeesDataGridViewTextBoxColumn.HeaderText = "Employees";
            this.employeesDataGridViewTextBoxColumn.Name = "employeesDataGridViewTextBoxColumn";
            // 
            // centerBindingSource
            // 
            this.centerBindingSource.DataSource = typeof(CIAMTrial.Data.Center);
            // 
            // pnlDatosCentro
            // 
            this.pnlDatosCentro.Controls.Add(this.txtId);
            this.pnlDatosCentro.Controls.Add(this.lblEmpleadoACargo);
            this.pnlDatosCentro.Controls.Add(this.lblCodigoPostal);
            this.pnlDatosCentro.Controls.Add(this.txtEmpleadoACargo);
            this.pnlDatosCentro.Controls.Add(this.txtCodigoPostal);
            this.pnlDatosCentro.Controls.Add(this.txtDireccion);
            this.pnlDatosCentro.Controls.Add(this.txtTelefono);
            this.pnlDatosCentro.Controls.Add(this.txtNombreCentro);
            this.pnlDatosCentro.Controls.Add(this.lblDireccion);
            this.pnlDatosCentro.Controls.Add(this.lblId);
            this.pnlDatosCentro.Controls.Add(this.lblTelefono);
            this.pnlDatosCentro.Controls.Add(this.lblNombreCentro);
            this.pnlDatosCentro.HorizontalScrollbarBarColor = true;
            this.pnlDatosCentro.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatosCentro.HorizontalScrollbarSize = 10;
            this.pnlDatosCentro.Location = new System.Drawing.Point(427, 62);
            this.pnlDatosCentro.Name = "pnlDatosCentro";
            this.pnlDatosCentro.Size = new System.Drawing.Size(350, 255);
            this.pnlDatosCentro.TabIndex = 1;
            this.pnlDatosCentro.VerticalScrollbarBarColor = true;
            this.pnlDatosCentro.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatosCentro.VerticalScrollbarSize = 10;
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centerBindingSource, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(141, 25);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(80, 29);
            this.txtId.TabIndex = 13;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmpleadoACargo
            // 
            this.lblEmpleadoACargo.AutoSize = true;
            this.lblEmpleadoACargo.Location = new System.Drawing.Point(13, 207);
            this.lblEmpleadoACargo.Name = "lblEmpleadoACargo";
            this.lblEmpleadoACargo.Size = new System.Drawing.Size(118, 19);
            this.lblEmpleadoACargo.TabIndex = 12;
            this.lblEmpleadoACargo.Text = "Empleado a cargo";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(13, 172);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(91, 19);
            this.lblCodigoPostal.TabIndex = 11;
            this.lblCodigoPostal.Text = "Código Postal";
            this.lblCodigoPostal.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // txtEmpleadoACargo
            // 
            // 
            // 
            // 
            this.txtEmpleadoACargo.CustomButton.Image = null;
            this.txtEmpleadoACargo.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtEmpleadoACargo.CustomButton.Name = "";
            this.txtEmpleadoACargo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtEmpleadoACargo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpleadoACargo.CustomButton.TabIndex = 1;
            this.txtEmpleadoACargo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpleadoACargo.CustomButton.UseSelectable = true;
            this.txtEmpleadoACargo.CustomButton.Visible = false;
            this.txtEmpleadoACargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centerBindingSource, "ManagerEmployee", true));
            this.txtEmpleadoACargo.Lines = new string[0];
            this.txtEmpleadoACargo.Location = new System.Drawing.Point(141, 197);
            this.txtEmpleadoACargo.MaxLength = 32767;
            this.txtEmpleadoACargo.Name = "txtEmpleadoACargo";
            this.txtEmpleadoACargo.PasswordChar = '\0';
            this.txtEmpleadoACargo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpleadoACargo.SelectedText = "";
            this.txtEmpleadoACargo.SelectionLength = 0;
            this.txtEmpleadoACargo.SelectionStart = 0;
            this.txtEmpleadoACargo.ShortcutsEnabled = true;
            this.txtEmpleadoACargo.Size = new System.Drawing.Size(196, 29);
            this.txtEmpleadoACargo.TabIndex = 10;
            this.txtEmpleadoACargo.UseSelectable = true;
            this.txtEmpleadoACargo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpleadoACargo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodigoPostal
            // 
            // 
            // 
            // 
            this.txtCodigoPostal.CustomButton.Image = null;
            this.txtCodigoPostal.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtCodigoPostal.CustomButton.Name = "";
            this.txtCodigoPostal.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCodigoPostal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoPostal.CustomButton.TabIndex = 1;
            this.txtCodigoPostal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoPostal.CustomButton.UseSelectable = true;
            this.txtCodigoPostal.CustomButton.Visible = false;
            this.txtCodigoPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centerBindingSource, "ZipCode", true));
            this.txtCodigoPostal.Lines = new string[0];
            this.txtCodigoPostal.Location = new System.Drawing.Point(141, 162);
            this.txtCodigoPostal.MaxLength = 32767;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.PasswordChar = '\0';
            this.txtCodigoPostal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoPostal.SelectedText = "";
            this.txtCodigoPostal.SelectionLength = 0;
            this.txtCodigoPostal.SelectionStart = 0;
            this.txtCodigoPostal.ShortcutsEnabled = true;
            this.txtCodigoPostal.Size = new System.Drawing.Size(196, 29);
            this.txtCodigoPostal.TabIndex = 9;
            this.txtCodigoPostal.UseSelectable = true;
            this.txtCodigoPostal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoPostal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDireccion
            // 
            // 
            // 
            // 
            this.txtDireccion.CustomButton.Image = null;
            this.txtDireccion.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtDireccion.CustomButton.Name = "";
            this.txtDireccion.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion.CustomButton.TabIndex = 1;
            this.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion.CustomButton.UseSelectable = true;
            this.txtDireccion.CustomButton.Visible = false;
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centerBindingSource, "Address", true));
            this.txtDireccion.Lines = new string[0];
            this.txtDireccion.Location = new System.Drawing.Point(141, 127);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.ShortcutsEnabled = true;
            this.txtDireccion.Size = new System.Drawing.Size(196, 29);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.UseSelectable = true;
            this.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTelefono
            // 
            // 
            // 
            // 
            this.txtTelefono.CustomButton.Image = null;
            this.txtTelefono.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtTelefono.CustomButton.Name = "";
            this.txtTelefono.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefono.CustomButton.TabIndex = 1;
            this.txtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefono.CustomButton.UseSelectable = true;
            this.txtTelefono.CustomButton.Visible = false;
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centerBindingSource, "PhoneNumber", true));
            this.txtTelefono.Lines = new string[0];
            this.txtTelefono.Location = new System.Drawing.Point(141, 92);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(196, 29);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.UseSelectable = true;
            this.txtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombreCentro
            // 
            // 
            // 
            // 
            this.txtNombreCentro.CustomButton.Image = null;
            this.txtNombreCentro.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtNombreCentro.CustomButton.Name = "";
            this.txtNombreCentro.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNombreCentro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreCentro.CustomButton.TabIndex = 1;
            this.txtNombreCentro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreCentro.CustomButton.UseSelectable = true;
            this.txtNombreCentro.CustomButton.Visible = false;
            this.txtNombreCentro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centerBindingSource, "Name", true));
            this.txtNombreCentro.Lines = new string[0];
            this.txtNombreCentro.Location = new System.Drawing.Point(141, 57);
            this.txtNombreCentro.MaxLength = 32767;
            this.txtNombreCentro.Name = "txtNombreCentro";
            this.txtNombreCentro.PasswordChar = '\0';
            this.txtNombreCentro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreCentro.SelectedText = "";
            this.txtNombreCentro.SelectionLength = 0;
            this.txtNombreCentro.SelectionStart = 0;
            this.txtNombreCentro.ShortcutsEnabled = true;
            this.txtNombreCentro.Size = new System.Drawing.Size(196, 29);
            this.txtNombreCentro.TabIndex = 6;
            this.txtNombreCentro.UseSelectable = true;
            this.txtNombreCentro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreCentro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(13, 137);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 19);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(13, 102);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 19);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblNombreCentro
            // 
            this.lblNombreCentro.AutoSize = true;
            this.lblNombreCentro.Location = new System.Drawing.Point(13, 67);
            this.lblNombreCentro.Name = "lblNombreCentro";
            this.lblNombreCentro.Size = new System.Drawing.Size(122, 19);
            this.lblNombreCentro.TabIndex = 2;
            this.lblNombreCentro.Text = "Nombre del centro";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(624, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(543, 350);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(462, 350);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(705, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(381, 350);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlDatosCentro);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmCentro";
            this.Text = "Centro";
            this.Load += new System.EventHandler(this.frmCentro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerBindingSource)).EndInit();
            this.pnlDatosCentro.ResumeLayout(false);
            this.pnlDatosCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource centerBindingSource;
        private MetroFramework.Controls.MetroPanel pnlDatosCentro;
        private MetroFramework.Controls.MetroLabel lblEmpleadoACargo;
        private MetroFramework.Controls.MetroLabel lblCodigoPostal;
        private MetroFramework.Controls.MetroTextBox txtEmpleadoACargo;
        private MetroFramework.Controls.MetroTextBox txtCodigoPostal;
        private MetroFramework.Controls.MetroTextBox txtDireccion;
        private MetroFramework.Controls.MetroTextBox txtTelefono;
        private MetroFramework.Controls.MetroTextBox txtNombreCentro;
        private MetroFramework.Controls.MetroLabel lblDireccion;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroLabel lblTelefono;
        private MetroFramework.Controls.MetroLabel lblNombreCentro;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnAgregar;
    }
}