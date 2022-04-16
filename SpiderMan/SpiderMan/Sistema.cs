using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderMan
{

    /// <summary>
    /// Modela un sistema IBM i al que puede accederse.-
    /// </summary>
    public class Sistema
    {

        #region atributos

        /// <summary>
        /// Nombre del sistema IBM i.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Descripción del sistema IBM i.
        /// </summary>
        private string descripcion;

        /// <summary>
        /// Dirección IP del sistema IBM i.
        /// </summary>
        private string direccionIP;

        /// <summary>
        /// Estado del Sistema.-
        /// </summary>
        private int estado;

        #endregion

        #region propiedades

        /// <summary>
        /// Obtiene el nombre del sistema IBM i.
        /// </summary>
        public string Nombre
        { 
            get { return this.nombre; } 
        }

        /// <summary>
        /// Obtiene la descripción del sistema IBM i.
        /// </summary>
        public string Descripcion
        {
            get { return this.descripcion; }    
        }

        /// <summary>
        /// Obtiene la dirección IP del sistema IBM i.
        /// </summary>
        public string DireccionIP
        {
            get { return this.direccionIP; }
        }



        #endregion

        public Sistema(string nuevoNombre, string nuevaDescripcion, string nuevaDireccionIP)
        {
        }

        public Sistema(string nombreBuscado)
        {
        }

        public int VerificarConexion()
        {
            return 0;   
        }

        public static List<String> Obtener()
        {
            return null;
        }
    }
}
