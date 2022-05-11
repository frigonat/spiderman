﻿using System;
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

        public Sistema Mostrar()
        {
            modoEdicion = false;
            sistemaActual = null;
            this.ShowDialog();
            return sistemaActual;
        }

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

            cmbEstados.Items.Add(EstadosDeSistema.Habilitado.ToString());
            cmbEstados.Items.Add(EstadosDeSistema.Deshabilitado.ToString());

            if (modoEdicion)
            {
                this.Text = "Editar Sistema";
                btnGuardar.Text = "Aplicar";
                lblEstadoNuevo.Visible = false;
                cmbEstados.Visible = true;
                txtNombreSistema.Enabled = false;
                btnAceptar.Visible = false;
            }
            else
            {
                this.Text = "Agregar Sistema";
                btnGuardar.Text = "Guardar";
                lblEstadoNuevo.Visible = true;
                cmbEstados.Visible = false;
                txtNombreSistema.Enabled = true;
                btnAceptar.Visible = true;
            }

            if (sistemaActual != null )
            {
                txtNombreSistema.Text = sistemaActual.Nombre;
                txtDescripcionSistema.Text = sistemaActual.Descripcion;
                txtDireccionIPSistema.Text = sistemaActual.DireccionIP;
                cmbEstados.Text = sistemaActual.Estado.ToString();  
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            sistemaActual = null;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modoEdicion)
            {
                sistemaActual.Actualizar(txtDescripcionSistema.Text, txtDireccionIPSistema.Text);

                if (sistemaActual.Estado.ToString() != cmbEstados.Text)
                {
                    if (cmbEstados.Text == EstadosDeSistema.Habilitado.ToString())
                    {
                        sistemaActual.Habilitar();
                    }
                    else
                    {
                        sistemaActual.Deshabilitar();
                    }
                }
            }
            else
            {
                sistemaActual = new Sistema(txtNombreSistema.Text, txtDescripcionSistema.Text, txtDireccionIPSistema.Text, ((int)EstadosDeSistema.Habilitado).ToString());
            }
        }
    }
}
