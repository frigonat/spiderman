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
        public frmSistemas()
        {
            InitializeComponent();
        }

        private void frmSistemas_Load(object sender, EventArgs e)
        {
            sistemasConfigurados = new List<Sistema>(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sistemasConfigurados = Sistema.Obtener();

            lstSistemas.Items.Clear();
            foreach (Sistema s in sistemasConfigurados)
                lstSistemas.Items.Add(s.Descripcion);

            sistemaActual = sistemasConfigurados[0];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Sistema.Guardar(sistemasConfigurados);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmABMSistemas f = new frmABMSistemas();
            Sistema nuevoSistema = f.Mostrar();

            if (nuevoSistema != null)
            {
                sistemasConfigurados.Add(nuevoSistema);
                lstSistemas.Items.Add(nuevoSistema.Descripcion);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMSistemas f = new frmABMSistemas();
            Sistema sistemaModificado = f.Mostrar(sistemaActual);

            if (sistemaModificado != null)
            {
                sistemaActual = sistemaModificado;
                //me falta llevar reemplazar en la lista el sistema actual por el modificado
            }


        }
    }
}
