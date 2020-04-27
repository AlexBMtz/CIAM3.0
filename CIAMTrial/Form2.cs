using System;

namespace CIAMTrial
{
    public partial class frmInicio : MetroFramework.Forms.MetroForm
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void bttPrueba_Click(object sender, EventArgs e)
        {
            
            frmCentro administrador = new frmCentro();
            administrador.ShowDialog();
            

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            
            frmEmpleado administrador = new frmEmpleado();
            administrador.ShowDialog();
            
        }

        private void btnDonadores_Click(object sender, EventArgs e)
        {
            
            frmDonante administrador = new frmDonante();
            administrador.ShowDialog();
            
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            
            frmEnvio administrador = new frmEnvio();
            administrador.ShowDialog();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
          
            frmEnvio administrador = new frmEnvio();
            administrador.ShowDialog();
            
        }

        private void btnDonaciones_Click(object sender, EventArgs e)
        {
            
            frmProducto administrador = new frmProducto();
            administrador.ShowDialog();
            
        }
    }
}
