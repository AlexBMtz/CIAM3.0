using CIAMTrial.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CIAMTrial
{
    public partial class frmEnvio : MetroFramework.Forms.MetroForm
    {
        public frmEnvio()
        {
            InitializeComponent();
        }

        private void frmEnvio_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                requestDetailBindingSource.DataSource = dataContext.RequestDetails.ToList();
            }
            pnlDatosEnvio.Enabled = false;
            RequestDetail requestDetail = requestDetailBindingSource.Current as RequestDetail;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatosEnvio.Enabled = true;

            requestDetailBindingSource.Add(new RequestDetail());
            requestDetailBindingSource.MoveLast();
            txtFolio.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatosEnvio.Enabled = true;

            txtFolio.Focus();
            RequestDetail requestDetail =
                requestDetailBindingSource.Current as RequestDetail;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
                "¿Quieres eliminar envío?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DataContext dataContext = new DataContext())
                {
                    RequestDetail requestDetail =
                        requestDetailBindingSource.Current as RequestDetail;
                    if (requestDetail != null)
                    {
                        if (dataContext.Entry<RequestDetail>(requestDetail).State == EntityState.Detached)
                            dataContext.Set<RequestDetail>().Attach(requestDetail);
                        dataContext.Entry<RequestDetail>(requestDetail).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Envío eliminado");
                        requestDetailBindingSource.RemoveCurrent();
                        pnlDatosEnvio.Enabled = false;

                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                RequestDetail requestDetail =
                    requestDetailBindingSource.Current as RequestDetail;
                if (requestDetail != null)
                {
                    if (dataContext.Entry<RequestDetail>(requestDetail).State == EntityState.Detached)
                        dataContext.Set<RequestDetail>().Attach(requestDetail);
                    if (requestDetail.Id == 0)
                        dataContext.Entry<RequestDetail>(requestDetail).State = EntityState.Added;
                    else
                        dataContext.Entry<RequestDetail>(requestDetail).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Envío guardado");
                    grdDatos.Refresh();
                    pnlDatosEnvio.Enabled = false;

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatosEnvio.Enabled = false;
            requestDetailBindingSource.ResetBindings(false);
            frmEnvio_Load(sender, e);
        }
        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RequestDetail requestDetail = requestDetailBindingSource.Current as RequestDetail;
        }
    }
}
