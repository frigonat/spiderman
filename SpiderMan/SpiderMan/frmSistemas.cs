using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiderMan
{
    public partial class frmSistemas : Form
    {
        List<Sistema> sistemasConfigurados;
        Sistema sistemaActual;
        bool cargaEnProgreso;
        bool modificacionesPendientes;
        int indiceSistemaModificado;

        public frmSistemas()
        {
            InitializeComponent();
        }

        private void frmSistemas_Load(object sender, EventArgs e)
        {
            sistemasConfigurados = new List<Sistema>();
            recuperarSistemas();
            modificacionesPendientes = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarSistema();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (sistemaActual != null)  
                editarSistemaActual();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarSistemaActual();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Sistema.Guardar(sistemasConfigurados);
            modificacionesPendientes = false;
        }

        private void dgvSistemas_SelectionChanged(object sender, EventArgs e)
        {
            if (!cargaEnProgreso)
            {
                if (dgvSistemas.CurrentCell != null)
                {
                    string nombreElegido = System.Convert.ToString(dgvSistemas.CurrentRow.Cells[colNombreSistema.Name].Value);
                    sistemaActual = sistemasConfigurados.Find(x => x.Nombre == nombreElegido);

                    indiceSistemaModificado = dgvSistemas.CurrentRow.Index;
                }
            }
        }

        private void frmSistemas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modificacionesPendientes)
            {
                if (MessageBox.Show("Hay modificaciones pendientes. ¿Desea conservarlas?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Sistema.Guardar(sistemasConfigurados);
            }
        }

        private void tslAgregar_Click(object sender, EventArgs e)
        {
            agregarSistema();
        }

        private void tslGuardar_Click(object sender, EventArgs e)
        {
            Sistema.Guardar(sistemasConfigurados);
            modificacionesPendientes = false;
        }

        private void tslEliminar_Click(object sender, EventArgs e)
        {
            eliminarSistemaActual();
        }

        private void tslEditar_Click(object sender, EventArgs e)
        {
            editarSistemaActual();
        }

        private void tslRefrescar_Click(object sender, EventArgs e)
        {
            recuperarSistemas();
        }

        /// <summary>
        /// Muestra el formulario para agregar nuevos sistemas y si se realiza la operación, se adiciona el nuevo sistema a la lista.-
        /// </summary>
        private void agregarSistema()
        {
            frmABMSistemas f = new frmABMSistemas();
            Sistema nuevoSistema = f.Mostrar();

            if (nuevoSistema != null)
            {
                sistemasConfigurados.Add(nuevoSistema);

                object[] valores = new object[8];
                valores[0] = nuevoSistema.Nombre;
                valores[1] = nuevoSistema.Descripcion;
                valores[2] = nuevoSistema.DireccionIP;
                valores[3] = nuevoSistema.Estado.ToString();
                dgvSistemas.Rows.Add(valores);

                modificacionesPendientes = true;
            }

            tsslCantidadSistemas.Text = sistemasConfigurados.Count.ToString();
        }

        /// <summary>
        /// Muestra el formulario de edición de sistemas para permitir la modificación de datos del sistema actual.-
        /// </summary>
        private void editarSistemaActual()
        {
            frmABMSistemas f = new frmABMSistemas();
            Sistema sistemaModificado = f.Mostrar(sistemaActual);

            if (sistemaModificado != null)
            {
                sistemaActual = sistemaModificado;

                sistemasConfigurados.RemoveAll(x => x.Nombre == sistemaActual.Nombre);
                sistemasConfigurados.Add(sistemaActual);

                dgvSistemas.Rows[indiceSistemaModificado].Cells[colDescripcionSistema.Name].Value = sistemaActual.Descripcion;
                dgvSistemas.Rows[indiceSistemaModificado].Cells[colDireccionIP.Name].Value = sistemaActual.DireccionIP;
                dgvSistemas.Rows[indiceSistemaModificado].Cells[colEstadoSistema.Name].Value = sistemaActual.Estado;

                modificacionesPendientes = true;
            }
        }

        /// <summary>
        /// Elimina el sistema actual, si es que hay uno.-
        /// </summary>
        private void eliminarSistemaActual()
        {
            if (sistemaActual != null)
            {
                string mensaje = "¿Desea realmente eliminar el sistema " + sistemaActual.Nombre + "?";

                if (MessageBox.Show(mensaje, "Eliminación de Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sistemasConfigurados.Remove(sistemaActual);

                    dgvSistemas.Rows.RemoveAt(dgvSistemas.CurrentRow.Index);
                    tsslCantidadSistemas.Text = sistemasConfigurados.Count.ToString();
                    modificacionesPendientes = true;
                }
            }
        }

        /// <summary>
        /// Recupera la lista de sistemas del almacenamiento.-
        /// </summary>
        private void recuperarSistemas()
        {
            cargaEnProgreso = true;
            sistemasConfigurados = Sistema.Obtener();

            dgvSistemas.Rows.Clear();
            object[] valores = new object[8];
            foreach (Sistema s in sistemasConfigurados)
            {
                valores[0] = s.Nombre;
                valores[1] = s.Descripcion;
                valores[2] = s.DireccionIP;
                valores[3] = s.Estado.ToString();
                dgvSistemas.Rows.Add(valores);
            }

            if (sistemasConfigurados.Count > 0)
            {
                indiceSistemaModificado = 0;
                sistemaActual = sistemasConfigurados[0];
                dgvSistemas.Sort(colNombreSistema, ListSortDirection.Ascending);
            }
            else
            {
                sistemaActual = null;
            }

            tsslCantidadSistemas.Text = sistemasConfigurados.Count.ToString();
            cargaEnProgreso = false;
        }

    }
}
