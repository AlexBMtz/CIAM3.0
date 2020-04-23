namespace CIAMTrial
{
    partial class frmProducto
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
            this.pnlInformacionProdu = new MetroFramework.Controls.MetroPanel();
            this.txtCantidad = new MetroFramework.Controls.MetroTextBox();
            this.txtTipoProducto = new MetroFramework.Controls.MetroTextBox();
            this.txtCalidad = new MetroFramework.Controls.MetroTextBox();
            this.lblCalidad = new MetroFramework.Controls.MetroLabel();
            this.lblCantidad = new MetroFramework.Controls.MetroLabel();
            this.lblTipoProducto = new MetroFramework.Controls.MetroLabel();
            this.pnlProducto = new MetroFramework.Controls.MetroPanel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.txtProducto = new MetroFramework.Controls.MetroTextBox();
            this.lblProducto = new MetroFramework.Controls.MetroLabel();
            this.bttGuardar = new MetroFramework.Controls.MetroButton();
            this.bttAñadir = new MetroFramework.Controls.MetroButton();
            this.bttCancelar = new MetroFramework.Controls.MetroButton();
            this.bttEditar = new MetroFramework.Controls.MetroButton();
            this.bttEliminar = new MetroFramework.Controls.MetroButton();
            this.grdProductos = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliableQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQualityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlInformacionProdu.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInformacionProdu
            // 
            this.pnlInformacionProdu.Controls.Add(this.txtCantidad);
            this.pnlInformacionProdu.Controls.Add(this.txtTipoProducto);
            this.pnlInformacionProdu.Controls.Add(this.txtCalidad);
            this.pnlInformacionProdu.Controls.Add(this.lblCalidad);
            this.pnlInformacionProdu.Controls.Add(this.lblCantidad);
            this.pnlInformacionProdu.Controls.Add(this.lblTipoProducto);
            this.pnlInformacionProdu.HorizontalScrollbarBarColor = true;
            this.pnlInformacionProdu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlInformacionProdu.HorizontalScrollbarSize = 10;
            this.pnlInformacionProdu.Location = new System.Drawing.Point(345, 203);
            this.pnlInformacionProdu.Name = "pnlInformacionProdu";
            this.pnlInformacionProdu.Size = new System.Drawing.Size(293, 152);
            this.pnlInformacionProdu.TabIndex = 4;
            this.pnlInformacionProdu.VerticalScrollbarBarColor = true;
            this.pnlInformacionProdu.VerticalScrollbarHighlightOnWheel = false;
            this.pnlInformacionProdu.VerticalScrollbarSize = 10;
            // 
            // txtCantidad
            // 
            // 
            // 
            // 
            this.txtCantidad.CustomButton.Image = null;
            this.txtCantidad.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtCantidad.CustomButton.Name = "";
            this.txtCantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidad.CustomButton.TabIndex = 1;
            this.txtCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidad.CustomButton.UseSelectable = true;
            this.txtCantidad.CustomButton.Visible = false;
            this.txtCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "AvaliableQuantity", true));
            this.txtCantidad.Lines = new string[0];
            this.txtCantidad.Location = new System.Drawing.Point(130, 112);
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.ShortcutsEnabled = true;
            this.txtCantidad.Size = new System.Drawing.Size(148, 23);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.UseSelectable = true;
            this.txtCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTipoProducto
            // 
            // 
            // 
            // 
            this.txtTipoProducto.CustomButton.Image = null;
            this.txtTipoProducto.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtTipoProducto.CustomButton.Name = "";
            this.txtTipoProducto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTipoProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTipoProducto.CustomButton.TabIndex = 1;
            this.txtTipoProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTipoProducto.CustomButton.UseSelectable = true;
            this.txtTipoProducto.CustomButton.Visible = false;
            this.txtTipoProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductTye", true));
            this.txtTipoProducto.Lines = new string[0];
            this.txtTipoProducto.Location = new System.Drawing.Point(130, 14);
            this.txtTipoProducto.MaxLength = 32767;
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.PasswordChar = '\0';
            this.txtTipoProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTipoProducto.SelectedText = "";
            this.txtTipoProducto.SelectionLength = 0;
            this.txtTipoProducto.SelectionStart = 0;
            this.txtTipoProducto.ShortcutsEnabled = true;
            this.txtTipoProducto.Size = new System.Drawing.Size(148, 23);
            this.txtTipoProducto.TabIndex = 5;
            this.txtTipoProducto.UseSelectable = true;
            this.txtTipoProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTipoProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCalidad
            // 
            // 
            // 
            // 
            this.txtCalidad.CustomButton.Image = null;
            this.txtCalidad.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtCalidad.CustomButton.Name = "";
            this.txtCalidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCalidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCalidad.CustomButton.TabIndex = 1;
            this.txtCalidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCalidad.CustomButton.UseSelectable = true;
            this.txtCalidad.CustomButton.Visible = false;
            this.txtCalidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductQuality", true));
            this.txtCalidad.Lines = new string[0];
            this.txtCalidad.Location = new System.Drawing.Point(130, 62);
            this.txtCalidad.MaxLength = 32767;
            this.txtCalidad.Name = "txtCalidad";
            this.txtCalidad.PasswordChar = '\0';
            this.txtCalidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCalidad.SelectedText = "";
            this.txtCalidad.SelectionLength = 0;
            this.txtCalidad.SelectionStart = 0;
            this.txtCalidad.ShortcutsEnabled = true;
            this.txtCalidad.Size = new System.Drawing.Size(148, 23);
            this.txtCalidad.TabIndex = 4;
            this.txtCalidad.UseSelectable = true;
            this.txtCalidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCalidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCalidad
            // 
            this.lblCalidad.AutoSize = true;
            this.lblCalidad.Location = new System.Drawing.Point(9, 62);
            this.lblCalidad.Name = "lblCalidad";
            this.lblCalidad.Size = new System.Drawing.Size(54, 19);
            this.lblCalidad.TabIndex = 3;
            this.lblCalidad.Text = "Calidad";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(11, 116);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 19);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(9, 14);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(115, 19);
            this.lblTipoProducto.TabIndex = 1;
            this.lblTipoProducto.Text = "Tipo del Producto";
            // 
            // pnlProducto
            // 
            this.pnlProducto.Controls.Add(this.txtId);
            this.pnlProducto.Controls.Add(this.lblId);
            this.pnlProducto.Controls.Add(this.txtDescripcion);
            this.pnlProducto.Controls.Add(this.lblDescripcion);
            this.pnlProducto.Controls.Add(this.txtProducto);
            this.pnlProducto.Controls.Add(this.lblProducto);
            this.pnlProducto.HorizontalScrollbarBarColor = true;
            this.pnlProducto.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProducto.HorizontalScrollbarSize = 10;
            this.pnlProducto.Location = new System.Drawing.Point(342, 17);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(293, 180);
            this.pnlProducto.TabIndex = 3;
            this.pnlProducto.VerticalScrollbarBarColor = true;
            this.pnlProducto.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProducto.VerticalScrollbarSize = 10;
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Id", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(195, 58);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(75, 23);
            this.txtId.TabIndex = 8;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(168, 58);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 19);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID";
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(12, 80);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(269, 80);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 58);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(76, 19);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtProducto
            // 
            // 
            // 
            // 
            this.txtProducto.CustomButton.Image = null;
            this.txtProducto.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtProducto.CustomButton.Name = "";
            this.txtProducto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProducto.CustomButton.TabIndex = 1;
            this.txtProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProducto.CustomButton.UseSelectable = true;
            this.txtProducto.CustomButton.Visible = false;
            this.txtProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.txtProducto.Lines = new string[0];
            this.txtProducto.Location = new System.Drawing.Point(12, 32);
            this.txtProducto.MaxLength = 32767;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProducto.SelectedText = "";
            this.txtProducto.SelectionLength = 0;
            this.txtProducto.SelectionStart = 0;
            this.txtProducto.ShortcutsEnabled = true;
            this.txtProducto.Size = new System.Drawing.Size(186, 23);
            this.txtProducto.TabIndex = 3;
            this.txtProducto.UseSelectable = true;
            this.txtProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(3, 10);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(63, 19);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto";
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(356, 399);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttGuardar.TabIndex = 13;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseSelectable = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // bttAñadir
            // 
            this.bttAñadir.Location = new System.Drawing.Point(356, 370);
            this.bttAñadir.Name = "bttAñadir";
            this.bttAñadir.Size = new System.Drawing.Size(75, 23);
            this.bttAñadir.TabIndex = 14;
            this.bttAñadir.Text = "Añadir";
            this.bttAñadir.UseSelectable = true;
            this.bttAñadir.Click += new System.EventHandler(this.bttAñadir_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(534, 399);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttCancelar.TabIndex = 12;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseSelectable = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(446, 370);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(75, 23);
            this.bttEditar.TabIndex = 15;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseSelectable = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(534, 370);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttEliminar.TabIndex = 16;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseSelectable = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // grdProductos
            // 
            this.grdProductos.AllowUserToResizeRows = false;
            this.grdProductos.AutoGenerateColumns = false;
            this.grdProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.productTyeDataGridViewTextBoxColumn,
            this.avaliableQuantityDataGridViewTextBoxColumn,
            this.productQualityDataGridViewTextBoxColumn,
            this.donationDetailsDataGridViewTextBoxColumn,
            this.requestDetailsDataGridViewTextBoxColumn});
            this.grdProductos.DataSource = this.productBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdProductos.EnableHeadersVisualStyles = false;
            this.grdProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProductos.Location = new System.Drawing.Point(11, 75);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductos.Size = new System.Drawing.Size(325, 185);
            this.grdProductos.TabIndex = 17;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // productTyeDataGridViewTextBoxColumn
            // 
            this.productTyeDataGridViewTextBoxColumn.DataPropertyName = "ProductTye";
            this.productTyeDataGridViewTextBoxColumn.HeaderText = "ProductTye";
            this.productTyeDataGridViewTextBoxColumn.Name = "productTyeDataGridViewTextBoxColumn";
            // 
            // avaliableQuantityDataGridViewTextBoxColumn
            // 
            this.avaliableQuantityDataGridViewTextBoxColumn.DataPropertyName = "AvaliableQuantity";
            this.avaliableQuantityDataGridViewTextBoxColumn.HeaderText = "AvaliableQuantity";
            this.avaliableQuantityDataGridViewTextBoxColumn.Name = "avaliableQuantityDataGridViewTextBoxColumn";
            // 
            // productQualityDataGridViewTextBoxColumn
            // 
            this.productQualityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuality";
            this.productQualityDataGridViewTextBoxColumn.HeaderText = "ProductQuality";
            this.productQualityDataGridViewTextBoxColumn.Name = "productQualityDataGridViewTextBoxColumn";
            // 
            // donationDetailsDataGridViewTextBoxColumn
            // 
            this.donationDetailsDataGridViewTextBoxColumn.DataPropertyName = "DonationDetails";
            this.donationDetailsDataGridViewTextBoxColumn.HeaderText = "DonationDetails";
            this.donationDetailsDataGridViewTextBoxColumn.Name = "donationDetailsDataGridViewTextBoxColumn";
            // 
            // requestDetailsDataGridViewTextBoxColumn
            // 
            this.requestDetailsDataGridViewTextBoxColumn.DataPropertyName = "RequestDetails";
            this.requestDetailsDataGridViewTextBoxColumn.HeaderText = "RequestDetails";
            this.requestDetailsDataGridViewTextBoxColumn.Name = "requestDetailsDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CIAMTrial.Data.Product);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 430);
            this.Controls.Add(this.grdProductos);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.bttAñadir);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.pnlInformacionProdu);
            this.Controls.Add(this.pnlProducto);
            this.Name = "frmProducto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.pnlInformacionProdu.ResumeLayout(false);
            this.pnlInformacionProdu.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlInformacionProdu;
        private MetroFramework.Controls.MetroTextBox txtCantidad;
        private MetroFramework.Controls.MetroTextBox txtTipoProducto;
        private MetroFramework.Controls.MetroTextBox txtCalidad;
        private MetroFramework.Controls.MetroLabel lblCalidad;
        private MetroFramework.Controls.MetroLabel lblCantidad;
        private MetroFramework.Controls.MetroLabel lblTipoProducto;
        private MetroFramework.Controls.MetroPanel pnlProducto;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroTextBox txtProducto;
        private MetroFramework.Controls.MetroLabel lblProducto;
        private MetroFramework.Controls.MetroButton bttGuardar;
        private MetroFramework.Controls.MetroButton bttAñadir;
        private MetroFramework.Controls.MetroButton bttCancelar;
        private MetroFramework.Controls.MetroButton bttEditar;
        private MetroFramework.Controls.MetroButton bttEliminar;
        private MetroFramework.Controls.MetroGrid grdProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avaliableQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQualityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donationDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}