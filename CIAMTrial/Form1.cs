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
    public partial class frmEmpleado : MetroFramework.Forms.MetroForm

    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                employeeBindingSource.DataSource = dataContext.Employees.ToList();
            }
            pnlDatosPersonales.Enabled = false;
            pnlArea.Enabled = false;
            pnlContacto.Enabled = false;
            Employee employee = employeeBindingSource.Current as Employee;
            if (employee != null && employee.ImageUrl != null)
                pctbEmpleado.Image = Image.FromFile(employee.ImageUrl);
            else
                pctbEmpleado.Image = null;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatosPersonales.Enabled = true;
            pnlContacto.Enabled = true;
            pnlArea.Enabled = true;
            pctbEmpleado.Image = null;
            employeeBindingSource.Add(new Employee());
            employeeBindingSource.MoveLast();
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatosPersonales.Enabled = true;
            pnlContacto.Enabled = true;
            pnlArea.Enabled = true;
            txtNombre.Focus();
            Employee employee =
                employeeBindingSource.Current as Employee;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
                "¿Quieres eliminar a este empleado?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Employee employee =
                        employeeBindingSource.Current as Employee;
                    if (employee != null)
                    {
                        if (dataContext.Entry<Employee>(employee).State == EntityState.Detached)
                            dataContext.Set<Employee>().Attach(employee);
                        dataContext.Entry<Employee>(employee).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Empleado eliminado");
                        employeeBindingSource.RemoveCurrent();
                        pctbEmpleado.Image = null;
                        pnlDatosPersonales.Enabled = false;
                        pnlContacto.Enabled = false;
                        pnlArea.Enabled = false;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Employee employee =
                    employeeBindingSource.Current as Employee;
                if (employee != null)
                {
                    if (dataContext.Entry<Employee>(employee).State == EntityState.Detached)
                        dataContext.Set<Employee>().Attach(employee);
                    if (employee.Id == 0)
                        dataContext.Entry<Employee>(employee).State = EntityState.Added;
                    else
                        dataContext.Entry<Employee>(employee).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Empleado guardado");
                    grdDatos.Refresh();
                    pnlDatosPersonales.Enabled = false;
                    pnlContacto.Enabled = false;
                    pnlArea.Enabled = false;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatosPersonales.Enabled = false;
            pnlContacto.Enabled = false;
            pnlArea.Enabled = false;
            employeeBindingSource.ResetBindings(false);
            frmEmpleado_Load(sender, e);
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee employee = employeeBindingSource.Current as Employee;
            if (employee != null && employee.ImageUrl != null)
                pctbEmpleado.Image = Image.FromFile(employee.ImageUrl);
            else
                pctbEmpleado.Image = null;

        }

        private void pctbEmpleado_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd =
                new OpenFileDialog()
                {
                    Filter = "|Archivos JPEG|*.jpg|Archivos PNG|*.png|Todos los archivos|*.*"
                })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctbEmpleado.Image = Image.FromFile(ofd.FileName);
                    Employee employee =
                        employeeBindingSource.Current as Employee;
                    if (employee != null)
                        employee.ImageUrl = ofd.FileName;

                }
            }
        }
    }
}


            