using CIAMTrial.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CIAMTrial
{
    public partial class frmDonante : MetroFramework.Forms.MetroForm
    {
        public frmDonante()
        {
            InitializeComponent();
        }

        private void Donante_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                donorBindingSource.DataSource = dataContext.Donors.ToList();
            }
            pnlDatos.Enabled = false;
            pnlContacto.Enabled = false;
            pnlDonacion.Enabled = false;
            Donor donor = donorBindingSource.Current as Donor;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pnlContacto.Enabled = true;
            pnlDonacion.Enabled = true;
            donorBindingSource.Add(new Donor());
            donorBindingSource.MoveLast();
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pnlContacto.Enabled = true;
            pnlDonacion.Enabled = true;
            txtNombre.Focus();
            Donor donor = donorBindingSource.Current as Donor;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
                "¿Quieres eliminar a este donador?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Donor donor =
                        donorBindingSource.Current as Donor;
                    if (donor != null)
                    {
                        if (dataContext.Entry<Donor>(donor).State == EntityState.Detached)
                            dataContext.Set<Donor>().Attach(donor);
                        dataContext.Entry<Donor>(donor).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Donador eliminado");
                        donorBindingSource.RemoveCurrent();

                        pnlDatos.Enabled = false;
                        pnlContacto.Enabled = false;
                        pnlDonacion.Enabled = false;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Donor donor =
                   donorBindingSource.Current as Donor;
                if (donor != null)
                {
                    if (dataContext.Entry<Donor>(donor).State == EntityState.Detached)
                        dataContext.Set<Donor>().Attach(donor);
                    if (donor.Id == 0)
                        dataContext.Entry<Donor>(donor).State = EntityState.Added;
                    else
                        dataContext.Entry<Donor>(donor).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Donador guardado");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                    pnlContacto.Enabled = false;
                    pnlDonacion.Enabled = false;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            pnlContacto.Enabled = false;
            pnlDonacion.Enabled = false;
            donorBindingSource.ResetBindings(false);
            Donante_Load(sender, e);
        }
        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Donor donor = donorBindingSource.Current as Donor;
            

        }
    }
}
