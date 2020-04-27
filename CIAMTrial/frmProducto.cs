using CIAMTrial.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIAMTrial
{
    public partial class frmProducto : MetroFramework.Forms.MetroForm
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                productBindingSource.DataSource = dataContext.Products.ToList();
            }
            pnlInformacionProdu.Enabled = false;
            pnlProducto.Enabled = false;
            Product product = productBindingSource.Current as Product;
        }

        private void bttAñadir_Click(object sender, EventArgs e)
        {
            pnlInformacionProdu.Enabled = true;
            pnlProducto.Enabled = true;
            txtDescripcion.Focus();
            productBindingSource.Add(new Product());
            productBindingSource.MoveLast();
            Product product = productBindingSource.Current as Product;
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Product product =
                        productBindingSource.Current as Product;
                if (product != null)
                {
                    if (dataContext.Entry<Product>(product).State == EntityState.Detached)
                        dataContext.Set<Product>().Attach(product);
                    if (product.Id == 0)
                        dataContext.Entry<Product>(product).State = EntityState.Added;
                    else
                        dataContext.Entry<Product>(product).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Producto guardado");
                    pnlInformacionProdu.Enabled = false;
                    pnlProducto.Enabled = false;
                    grdProductos.Refresh();
                }
            }
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            pnlInformacionProdu.Enabled = false;
            pnlProducto.Enabled = false;
            productBindingSource.ResetBindings(false);
            frmProducto_Load(sender, e);
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            pnlInformacionProdu.Enabled = true;
            pnlProducto.Enabled = true;
            txtDescripcion.Focus();
            Product product = productBindingSource.Current as Product;
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
               "¿Quieres eliminar este producto?",
               "Eliminar",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Product product =
                         productBindingSource.Current as Product;
                    if (product != null)
                    {
                        if (dataContext.Entry<Product>(product).State == EntityState.Detached)
                            dataContext.Set<Product>().Attach(product);
                        dataContext.Entry<Product>(product).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Producto eliminado");
                        productBindingSource.RemoveCurrent();

                        pnlInformacionProdu.Enabled = false;
                        pnlProducto.Enabled = false;
                    }

                }
            }
        }
        private void grdProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Product product = productBindingSource.Current as Product;
        }
    }
}
