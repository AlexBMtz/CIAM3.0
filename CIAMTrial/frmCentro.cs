using CIAMTrial.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CIAMTrial
{
    public partial class frmCentro : MetroFramework.Forms.MetroForm
    {
        public frmCentro()
        {
            InitializeComponent();
        }

        private void frmCentro_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                centerBindingSource.DataSource = dataContext.Centers.ToList();
            }
            pnlDatosCentro.Enabled = false;

            Center center = centerBindingSource.Current as Center;

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatosCentro.Enabled = true;
            centerBindingSource.Add(new Center());
            centerBindingSource.MoveLast();
            txtNombreCentro.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatosCentro.Enabled = true;
            txtNombreCentro.Focus();
            Center center =
                centerBindingSource.Current as Center;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
                "¿Quieres eliminar a este centro?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Center center =
                        centerBindingSource.Current as Center;
                    if (center != null)
                    {
                        if (dataContext.Entry<Center>(center).State == EntityState.Detached)
                            dataContext.Set<Center>().Attach(center);
                        dataContext.Entry<Center>(center).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Centro Eliminado");
                        centerBindingSource.RemoveCurrent();
                        pnlDatosCentro.Enabled = false;

                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Center center =
                    centerBindingSource.Current as Center;
                if (center != null)
                {
                    if (dataContext.Entry<Center>(center).State == EntityState.Detached)
                        dataContext.Set<Center>().Attach(center);
                    if (center.Id == 0)
                        dataContext.Entry<Center>(center).State = EntityState.Added;
                    else
                        dataContext.Entry<Center>(center).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Centro guardado");
                    grdDatos.Refresh();
                    pnlDatosCentro.Enabled = false;

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatosCentro.Enabled = false;
            centerBindingSource.ResetBindings(false);
            frmCentro_Load(sender, e);
        }
        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Center center = centerBindingSource.Current as Center;


        }
    }

}
