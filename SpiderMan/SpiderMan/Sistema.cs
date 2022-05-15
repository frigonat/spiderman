using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

        private static string rutaArchivo;

        private static string nombreArchivo = "Sistemas.xml";

        /// <summary>
        /// Crea un nuevo sistema con los datos recibidos como parámetros.-
        /// </summary>
        /// <param name="nuevoNombre">Nombre para el nuevo sistema.-</param>
        /// <param name="nuevaDescripcion">Descripción para el nuevo sistema.-</param>
        /// <param name="nuevaDireccionIP">Dirección IP (o DNS) para el nuevo sistema.-</param>
        /// <param name="nuevoEstado">Estado para el nuevo sistema (1=Habilitado / 2=Deshabilitado)</param>
        public Sistema(string nuevoNombre, string nuevaDescripcion, string nuevaDireccionIP, string nuevoEstado)
        {
            this.nombre = nuevoNombre;
            this.descripcion = nuevaDescripcion;
            this.direccionIP = nuevaDireccionIP;

            EstadosDeSistema es;
            if (Enum.TryParse(nuevoEstado, out es))
                this.estado = es;
            else
                this.estado = EstadosDeSistema.Deshabilitado;
        }

        /// <summary>
        /// Crea un nuevo sistema con los datos recibidos como parámetros.-
        /// </summary>
        /// <param name="nuevoNombre">Nombre para el nuevo sistema.-</param>
        /// <param name="nuevaDescripcion">Descripción para el nuevo sistema.-</param>
        /// <param name="nuevaDireccionIP">Dirección IP (o DNS) para el nuevo sistema.-</param>
        /// <param name="nuevoEstado">Estado para el nuevo sistema.-</param>
        public Sistema(string nuevoNombre, string nuevaDescripcion, string nuevaDireccionIP, EstadosDeSistema nuevoEstado)
        {
            this.nombre = nuevoNombre;
            this.descripcion = nuevaDescripcion;
            this.direccionIP = nuevaDireccionIP;
            this.estado = nuevoEstado;
        }

        /// <summary>
        /// Obtiene de la lista de sistemas configurados, aquel cuyo nombre coincida con el recibido como parámetro.-
        /// </summary>
        /// <param name="nombreBuscado"></param>
        /// <exception cref="SistemaNoEncontradoException"></exception>
        public Sistema(string nombreBuscado)
        {
            List<Sistema> sistemasConfigurados = new List<Sistema>();
            
            sistemasConfigurados = Sistema.Obtener();

            int x = sistemasConfigurados.FindIndex (s => s.nombre == nombreBuscado);    
            if (x == -1)
            {
                throw new SistemaNoEncontradoException();
            }
            else
            {
                Sistema sistemaEncontrado = sistemasConfigurados.Find(s => s.Nombre == nombreBuscado);
                this.nombre = sistemaEncontrado.nombre; 
                this.descripcion = sistemaEncontrado.descripcion; 
                this.direccionIP = sistemaEncontrado.direccionIP;
                this.estado = sistemaEncontrado.Estado;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int VerificarConexion()
        {
            return 0;
        }

        /// <summary>
        /// Obtiene la lista de sistemas configurados.-
        /// </summary>
        /// <returns></returns>
        public static List<Sistema> Obtener()
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            rutaArchivo = Path.GetDirectoryName(myAssembly.Location);
            List<Sistema> listaParaDevolver = new List<Sistema>();

            //Se verifica que exista el archivo de sistemas.
            if (File.Exists(rutaArchivo + Path.DirectorySeparatorChar + nombreArchivo))
            {
                // se Carga todo el XML en el objeto libro
                //XDocument xmlSistemas = XDocument.Load("c:\\Temp\\Sistemas.xml", LoadOptions.None);
                XDocument xmlSistemas = XDocument.Load(rutaArchivo + Path.DirectorySeparatorChar + nombreArchivo);
                //usa éste siguiente para cargar desde texto (string) en vez de un archivo
                //XDocument doc = XDocument.Parse(texto);

                //Obtener objeto librosEjemplo
                XElement listaSistemas = xmlSistemas.Element("Sistemas");

                //Obtener lista de libros dentro de librosEjemplo
                IEnumerable<XElement> sistemas = listaSistemas.Descendants("Sistema");

                //haz un foreach y por cada uno haz lo que tengas que hacer
                foreach (XElement sistema in sistemas)
                {
                    string nombre = sistema.Element("Nombre").Value;
                    string descripcion = sistema.Element("Descripcion").Value;
                    string direccionIP = sistema.Element("DireccionIP").Value;
                    string estado = sistema.Element("Estado").Value;

                    Sistema nuevosSistema = new Sistema(nombre, descripcion, direccionIP, estado);
                    listaParaDevolver.Add(nuevosSistema);
                }
            }

            return listaParaDevolver;
        }

        /// <summary>
        /// Guarda en el almacenamiento la lista de sistemas.-
        /// </summary>
        /// <param name="sistemas"></param>
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
                XmlText texto_Estado = doc.CreateTextNode(((int)s.estado).ToString());

                nombre.AppendChild(texto_Nombre);
                descripcion.AppendChild(texto_Descripcion);
                direccionIP.AppendChild(texto_DireccionIP);
                estado.AppendChild(texto_Estado);
            }

            doc.Save(rutaArchivo + Path.DirectorySeparatorChar + nombreArchivo);
        }

        /// <summary>
        /// Habilita el sistema actual.-
        /// </summary>
        public void Habilitar()
        {
            this.estado = EstadosDeSistema.Habilitado;
        }

        /// <summary>
        /// Deshabilita el sistema actual.-
        /// </summary>
        public void Deshabilitar()
        {
            this.estado = EstadosDeSistema.Deshabilitado;
        }

        /// <summary>
        /// Actualiza el sistema actual con los datos recibidos como parámetro.-
        /// </summary>
        /// <param name="nuevaDescripcion">Nueva descripción.</param>
        /// <param name="nuevaDireccionIP">Nueva dirección IP.</param>
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
