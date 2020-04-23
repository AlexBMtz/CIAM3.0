using CIAMTrial.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CIAMTrial
{
    public partial class frmEntrada : MetroFramework.Forms.MetroForm
    {
        public frmEntrada()
        {
            InitializeComponent();
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                donationDetailBindingSource.DataSource = dataContext.DonationDetails.ToList();
            }
            pnlDatos.Enabled = false;

            DonationDetail donationDetail = donationDetailBindingSource.Current as DonationDetail;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;

            donationDetailBindingSource.Add(new DonationDetail());
            donationDetailBindingSource.MoveLast();
            txtNombre.Focus();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtNombre.Focus();
            DonationDetail donationDetail =
            donationDetailBindingSource.Current as DonationDetail;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
                "¿Quieres eliminar esta entrada?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DataContext dataContext = new DataContext())
                {
                    DonationDetail donationDetail =
                        donationDetailBindingSource.Current as DonationDetail;
                    if (donationDetail != null)
                    {
                        if (dataContext.Entry<DonationDetail>(donationDetail).State == EntityState.Detached)
                            dataContext.Set<DonationDetail>().Attach(donationDetail);
                        dataContext.Entry<DonationDetail>(donationDetail).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Entrada eliminado");
                        donationDetailBindingSource.RemoveCurrent();

                        pnlDatos.Enabled = false;

                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                DonationDetail donationDetail =
                    donationDetailBindingSource.Current as DonationDetail;
                if (donationDetail != null)
                {
                    if (dataContext.Entry<DonationDetail>(donationDetail).State == EntityState.Detached)
                        dataContext.Set<DonationDetail>().Attach(donationDetail);
                    if (donationDetail.Id == 0)
                        dataContext.Entry<DonationDetail>(donationDetail).State = EntityState.Added;
                    else
                        dataContext.Entry<DonationDetail>(donationDetail).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Entrada guardada");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;

            donationDetailBindingSource.ResetBindings(false);
            frmEntrada_Load(sender, e);
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DonationDetail donationDetail = donationDetailBindingSource.Current as DonationDetail;


        }
    }
}


