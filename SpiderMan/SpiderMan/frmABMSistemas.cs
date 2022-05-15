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
    public partial class frmABMSistemas : Form
    {
        private bool modoEdicion;
        private Sistema sistemaActual;

        //Muestra el formulario de ABM de Sistemas preparado para agregar un nuevo sistema a la colección.-
        public Sistema Mostrar()
        {
            modoEdicion = false;
            sistemaActual = null;
            this.ShowDialog();
            return sistemaActual;
        }

        //Muestra el formulario de ABM de Sistemas preparado para editar el sistema que se recibe como parámetro.-
        public Sistema Mostrar(Sistema s)
        {
            modoEdicion = true;
            sistemaActual = s;
            this.ShowDialog();
            return sistemaActual;
        }

        public frmABMSistemas()
        {
            InitializeComponent();
        }

        private void frmABMSistemas_Load(object sender, EventArgs e)
        {
            tslOperacion.Text = "";
            cmbEstados.Items.Add(EstadosDeSistema.Habilitado.ToString());
            cmbEstados.Items.Add(EstadosDeSistema.Deshabilitado.ToString());

            if (modoEdicion)
            {
                this.Text = "Editar Sistema";
                btnGuardar.Text = "Aplicar";
                lblEstadoNuevo.Visible = false;
                cmbEstados.Visible = true;
                txtNombreSistema.Enabled = false;
            }
            else
            {
                this.Text = "Agregar Sistema";
                btnGuardar.Text = "Guardar";
                lblEstadoNuevo.Visible = true;
                cmbEstados.Visible = false;
                txtNombreSistema.Enabled = true;
            }

            if (sistemaActual != null )
            {
                txtNombreSistema.Text = sistemaActual.Nombre;
                txtDescripcionSistema.Text = sistemaActual.Descripcion;
                txtDireccionIPSistema.Text = sistemaActual.DireccionIP;
                cmbEstados.Text = sistemaActual.Estado.ToString();  
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            sistemaActual = null;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modoEdicion)
            {
                try
                {
                    validarGUI();
                    sistemaActual.Actualizar(txtDescripcionSistema.Text, txtDireccionIPSistema.Text);

                    if (sistemaActual.Estado.ToString() != cmbEstados.Text)
                    {
                        if (cmbEstados.Text == EstadosDeSistema.Habilitado.ToString())
                            sistemaActual.Habilitar();
                        else
                            sistemaActual.Deshabilitar();
                    }

                    tslOperacion.Text = "Sistema Actualizado!";
                    timer1.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    validarGUI();
                    sistemaActual = new Sistema(txtNombreSistema.Text, txtDescripcionSistema.Text, txtDireccionIPSistema.Text, ((int)EstadosDeSistema.Habilitado).ToString());
                    txtNombreSistema.Text = "";
                    txtDescripcionSistema.Text = "";
                    txtDireccionIPSistema.Text = "";
                    tslOperacion.Text = "Sistema Guardado!";
                    timer1.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslOperacion.Text = "";
            timer1.Stop();
        }

        /// <summary>
        /// Valida los datos ingresados tanto para el alta como para la edición de un sistema.-
        /// </summary>
        private void validarGUI()
        {

            //Se valida que se ingrese la descripción del sistema.-
            if (txtDescripcionSistema.TextLength <= 0)
            {
                txtDescripcionSistema.Focus();
                throw new SistemaNoCreadoException("Debe ingresarse la descripción para el sistema.");
            }

            //Se valida que se ingrese la IP del sistema.-
            if (txtDireccionIPSistema.TextLength <= 0)
            {
                txtDireccionIPSistema.Focus();
                throw new SistemaNoCreadoException("Debe ingresarse la dirección IP o DNS del sistema.");
            }

            if (!modoEdicion)
            {
                //Se valida que se ingrese el nombre del sistema.-
                if (txtNombreSistema.TextLength <= 0)
                {
                    txtNombreSistema.Focus();
                    throw new SistemaNoCreadoException("Debe ingresarse el nombre del sistema.");
                }

                //Se valida que el nombre del sistema no exista previamente.-
                try
                {
                    Sistema s = new Sistema(txtNombreSistema.Text);
                    throw new SistemaNoCreadoException("Ya existe un sistema con el nombre ingresado [" + txtNombreSistema.Text + "]");
                }
                catch (SistemaNoEncontradoException ex)
                {
                    //do nothing
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
    }
}
