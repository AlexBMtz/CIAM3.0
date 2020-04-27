namespace CIAMTrial
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.bttPrueba = new MetroFramework.Controls.MetroButton();
            this.btnEmpleados = new MetroFramework.Controls.MetroButton();
            this.btnEntradas = new MetroFramework.Controls.MetroButton();
            this.btnDonaciones = new MetroFramework.Controls.MetroButton();
            this.btnDonadores = new MetroFramework.Controls.MetroButton();
            this.btnEnvios = new MetroFramework.Controls.MetroButton();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.lblSubtitulo = new MetroFramework.Controls.MetroLabel();
            this.pcbCentro = new System.Windows.Forms.PictureBox();
            this.pcbEmpleados = new System.Windows.Forms.PictureBox();
            this.pcbDonadores = new System.Windows.Forms.PictureBox();
            this.pcbEnvio = new System.Windows.Forms.PictureBox();
            this.pcbEntradas = new System.Windows.Forms.PictureBox();
            this.pcbProducto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDonadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // bttPrueba
            // 
            this.bttPrueba.BackColor = System.Drawing.Color.Transparent;
            this.bttPrueba.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bttPrueba.Location = new System.Drawing.Point(131, 138);
            this.bttPrueba.Name = "bttPrueba";
            this.bttPrueba.Size = new System.Drawing.Size(107, 72);
            this.bttPrueba.TabIndex = 0;
            this.bttPrueba.Text = "Centros";
            this.bttPrueba.UseCustomBackColor = true;
            this.bttPrueba.UseSelectable = true;
            this.bttPrueba.Click += new System.EventHandler(this.bttPrueba_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEmpleados.Location = new System.Drawing.Point(375, 138);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(116, 72);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseCustomBackColor = true;
            this.btnEmpleados.UseSelectable = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnEntradas
            // 
            this.btnEntradas.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEntradas.Location = new System.Drawing.Point(375, 270);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(116, 72);
            this.btnEntradas.TabIndex = 2;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.UseCustomBackColor = true;
            this.btnEntradas.UseSelectable = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnDonaciones
            // 
            this.btnDonaciones.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDonaciones.Location = new System.Drawing.Point(636, 270);
            this.btnDonaciones.Name = "btnDonaciones";
            this.btnDonaciones.Size = new System.Drawing.Size(106, 72);
            this.btnDonaciones.TabIndex = 3;
            this.btnDonaciones.Text = "Producto";
            this.btnDonaciones.UseCustomBackColor = true;
            this.btnDonaciones.UseSelectable = true;
            this.btnDonaciones.Click += new System.EventHandler(this.btnDonaciones_Click);
            // 
            // btnDonadores
            // 
            this.btnDonadores.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDonadores.Location = new System.Drawing.Point(636, 138);
            this.btnDonadores.Name = "btnDonadores";
            this.btnDonadores.Size = new System.Drawing.Size(106, 72);
            this.btnDonadores.TabIndex = 4;
            this.btnDonadores.Text = "Donadores";
            this.btnDonadores.UseCustomBackColor = true;
            this.btnDonadores.UseSelectable = true;
            this.btnDonadores.Click += new System.EventHandler(this.btnDonadores_Click);
            // 
            // btnEnvios
            // 
            this.btnEnvios.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEnvios.Location = new System.Drawing.Point(131, 270);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.Size = new System.Drawing.Size(107, 72);
            this.btnEnvios.TabIndex = 5;
            this.btnEnvios.Text = "Envíos";
            this.btnEnvios.UseCustomBackColor = true;
            this.btnEnvios.UseSelectable = true;
            this.btnEnvios.Click += new System.EventHandler(this.btnEnvios_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitulo.Location = new System.Drawing.Point(375, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(59, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "CIAM";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSubtitulo.Location = new System.Drawing.Point(241, 85);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(346, 25);
            this.lblSubtitulo.TabIndex = 7;
            this.lblSubtitulo.Text = "CENTRO INTEGRAL DE ACOPIO MEXICANO";
            // 
            // pcbCentro
            // 
            this.pcbCentro.Image = ((System.Drawing.Image)(resources.GetObject("pcbCentro.Image")));
            this.pcbCentro.InitialImage = null;
            this.pcbCentro.Location = new System.Drawing.Point(34, 138);
            this.pcbCentro.Name = "pcbCentro";
            this.pcbCentro.Size = new System.Drawing.Size(100, 72);
            this.pcbCentro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCentro.TabIndex = 8;
            this.pcbCentro.TabStop = false;
            // 
            // pcbEmpleados
            // 
            this.pcbEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("pcbEmpleados.Image")));
            this.pcbEmpleados.Location = new System.Drawing.Point(275, 138);
            this.pcbEmpleados.Name = "pcbEmpleados";
            this.pcbEmpleados.Size = new System.Drawing.Size(100, 72);
            this.pcbEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEmpleados.TabIndex = 9;
            this.pcbEmpleados.TabStop = false;
            // 
            // pcbDonadores
            // 
            this.pcbDonadores.Image = ((System.Drawing.Image)(resources.GetObject("pcbDonadores.Image")));
            this.pcbDonadores.Location = new System.Drawing.Point(536, 138);
            this.pcbDonadores.Name = "pcbDonadores";
            this.pcbDonadores.Size = new System.Drawing.Size(100, 72);
            this.pcbDonadores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDonadores.TabIndex = 10;
            this.pcbDonadores.TabStop = false;
            // 
            // pcbEnvio
            // 
            this.pcbEnvio.Image = ((System.Drawing.Image)(resources.GetObject("pcbEnvio.Image")));
            this.pcbEnvio.Location = new System.Drawing.Point(34, 270);
            this.pcbEnvio.Name = "pcbEnvio";
            this.pcbEnvio.Size = new System.Drawing.Size(100, 72);
            this.pcbEnvio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEnvio.TabIndex = 11;
            this.pcbEnvio.TabStop = false;
            // 
            // pcbEntradas
            // 
            this.pcbEntradas.Image = ((System.Drawing.Image)(resources.GetObject("pcbEntradas.Image")));
            this.pcbEntradas.Location = new System.Drawing.Point(275, 270);
            this.pcbEntradas.Name = "pcbEntradas";
            this.pcbEntradas.Size = new System.Drawing.Size(100, 72);
            this.pcbEntradas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEntradas.TabIndex = 12;
            this.pcbEntradas.TabStop = false;
            // 
            // pcbProducto
            // 
            this.pcbProducto.Image = ((System.Drawing.Image)(resources.GetObject("pcbProducto.Image")));
            this.pcbProducto.Location = new System.Drawing.Point(536, 270);
            this.pcbProducto.Name = "pcbProducto";
            this.pcbProducto.Size = new System.Drawing.Size(100, 72);
            this.pcbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProducto.TabIndex = 13;
            this.pcbProducto.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbProducto);
            this.Controls.Add(this.pcbEntradas);
            this.Controls.Add(this.pcbEnvio);
            this.Controls.Add(this.pcbDonadores);
            this.Controls.Add(this.pcbEmpleados);
            this.Controls.Add(this.pcbCentro);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEnvios);
            this.Controls.Add(this.btnDonadores);
            this.Controls.Add(this.btnDonaciones);
            this.Controls.Add(this.btnEntradas);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.bttPrueba);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pcbCentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDonadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton bttPrueba;
        private MetroFramework.Controls.MetroButton btnEmpleados;
        private MetroFramework.Controls.MetroButton btnEntradas;
        private MetroFramework.Controls.MetroButton btnDonaciones;
        private MetroFramework.Controls.MetroButton btnDonadores;
        private MetroFramework.Controls.MetroButton btnEnvios;
        private MetroFramework.Controls.MetroLabel lblTitulo;
        private MetroFramework.Controls.MetroLabel lblSubtitulo;
        private System.Windows.Forms.PictureBox pcbCentro;
        private System.Windows.Forms.PictureBox pcbEmpleados;
        private System.Windows.Forms.PictureBox pcbDonadores;
        private System.Windows.Forms.PictureBox pcbEnvio;
        private System.Windows.Forms.PictureBox pcbEntradas;
        private System.Windows.Forms.PictureBox pcbProducto;
    }
}