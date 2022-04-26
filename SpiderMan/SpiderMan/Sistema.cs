using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

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
        private EstadosDeSistema estado;

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

        /// <summary>
        /// Obtiene el estado del sistema IBM i.
        /// </summary>
        public EstadosDeSistema Estado
        {
            get { return this.estado; }
        }

        #endregion

        public Sistema(string nuevoNombre, string nuevaDescripcion, string nuevaDireccionIP)
        {
            this.nombre = nuevoNombre;
            this.descripcion = nuevaDescripcion;
            this.direccionIP = nuevaDireccionIP;
            this.estado = EstadosDeSistema.Habilitado;
        }

        public Sistema(string nuevoNombre, string nuevaDescripcion, string nuevaDireccionIP, EstadosDeSistema nuevoEstado)
        {
            this.nombre = nuevoNombre;
            this.descripcion = nuevaDescripcion;
            this.direccionIP = nuevaDireccionIP;
            this.estado = nuevoEstado;
        }


        public Sistema(string nombreBuscado)
        {
        }

        public int VerificarConexion()
        {
            return 0;
        }

        public static List<Sistema> Obtener()
        {
            List<Sistema> listaParaDevolver = new List<Sistema>();

            // se Carga todo el XML en el objeto libro
            XDocument xmlSistemas = XDocument.Load("c:\\Temp\\Sistemas.xml", LoadOptions.None);
            //usa éste siguiente para cargar desde texto (string) en vez de un archivo
            //XDocument doc = XDocument.Parse(texto);

            //Obtener objeto librosEjemplo
            XElement listaSistemas = xmlSistemas.Element("Sistemas");

            //Obtener lista de libros dentro de librosEjemplo
            IEnumerable<XElement> sistemas = listaSistemas.Descendants("Sistema");

            //has un foreach y por cada uno haz lo que tengas que hacer
            foreach (XElement sistema in sistemas)
            {
                string nombre = sistema.Element("Nombre").Value;
                string descripcion = sistema.Element("Descripcion").Value;
                string direccionIP = sistema.Element("DireccionIP").Value;
                string estado = sistema.Element("Estado").Value;

                Sistema nuevosSistema = new Sistema(nombre, descripcion, direccionIP);

                listaParaDevolver.Add(nuevosSistema);
            }

            return listaParaDevolver;
        }

        public static void Guardar(List<Sistema> sistemas)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            XmlElement element1 = doc.CreateElement(string.Empty, "Sistemas", string.Empty);
            doc.AppendChild(element1);

            foreach (Sistema s in sistemas)
            {
                XmlElement sistema = doc.CreateElement(string.Empty, "Sistema", string.Empty);
                element1.AppendChild(sistema);

                XmlElement nombre = doc.CreateElement(string.Empty, "Nombre", string.Empty);
                XmlElement descripcion = doc.CreateElement(string.Empty, "Descripcion", string.Empty);
                XmlElement direccionIP = doc.CreateElement(string.Empty, "DireccionIP", string.Empty);
                XmlElement estado = doc.CreateElement(string.Empty, "Estado", string.Empty);
                sistema.AppendChild(nombre);
                sistema.AppendChild(descripcion);
                sistema.AppendChild(direccionIP);
                sistema.AppendChild(estado);

                XmlText texto_Nombre = doc.CreateTextNode(s.Nombre);
                XmlText texto_Descripcion = doc.CreateTextNode(s.Descripcion);
                XmlText texto_DireccionIP = doc.CreateTextNode(s.DireccionIP);
                XmlText texto_Estado = doc.CreateTextNode("un estado qualuquiera");

                nombre.AppendChild(texto_Nombre);
                descripcion.AppendChild(texto_Descripcion);
                direccionIP.AppendChild(texto_DireccionIP);
                estado.AppendChild(texto_Estado);
            }

            doc.Save("C://Temp//Sistemas.xml");
        }

        public void Actualizar(string nuevaDescripcion, string nuevaDireccionIP)
        {
            this.descripcion = nuevaDescripcion;
            this.direccionIP = nuevaDireccionIP;
        }

        private static void ejemplo()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            XmlElement element1 = doc.CreateElement(string.Empty, "cuerpo", string.Empty);
            doc.AppendChild(element1);
           
            XmlElement element2 = doc.CreateElement(string.Empty, "nivel1", string.Empty);
            element1.AppendChild(element2);
            XmlElement element3 = doc.CreateElement(string.Empty, "nivel2", string.Empty);
            XmlText text1 = doc.CreateTextNode("texto");
            element3.AppendChild(text1);
            element2.AppendChild(element3);
            XmlElement element4 = doc.CreateElement(string.Empty, "nivel3", string.Empty);
            XmlText text2 = doc.CreateTextNode("más texto");
            element4.AppendChild(text2);
            element2.AppendChild(element4);
            doc.Save("C://ruta//xml_ejemplo.xml");
        }

    }
}
