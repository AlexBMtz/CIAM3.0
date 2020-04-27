using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
