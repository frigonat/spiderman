using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderMan
{
    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar un sistema.-
    /// </summary>
    public class SistemaNoEncontradoException : Exception
    {
        public SistemaNoEncontradoException()
            : base("No se ha podido encontrar el sistema.-")
        {
        }

        public SistemaNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public SistemaNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede crear un sistema.-
    /// </summary>
    public class SistemaNoCreadoException : Exception
    {
        public SistemaNoCreadoException()
            : base("No se ha podido crear el sistema.-")
        {
        }

        public SistemaNoCreadoException(string mensaje)
            : base(mensaje)
        {
        }

        public SistemaNoCreadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se encuentra un sistema con datos no válidos.-
    /// </summary>
    public class SistemaNoValidoException : Exception
    {
        public SistemaNoValidoException()
            : base("El sistema recuperado contiene datos no válidos.-")
        {
        }

        public SistemaNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public SistemaNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }


    /// <summary>
    /// Excepción que se produce cuando no se puede cambiar un sistema.-
    /// </summary>
    public class SistemaNoCambiadoException : Exception
    {
        public SistemaNoCambiadoException()
            : base("No se ha podido cambiar el sistema.-")
        {
        }

        public SistemaNoCambiadoException(string mensaje)
            : base(mensaje)
        {
        }

        public SistemaNoCambiadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede deshabilitar un sistema.-
    /// </summary>
    public class SistemaNoDeshabilitadoException : Exception
    {
        public SistemaNoDeshabilitadoException()
            : base("No se ha podido deshabilitar el sistema.-")
        {
        }

        public SistemaNoDeshabilitadoException(string mensaje)
            : base(mensaje)
        {
        }

        public SistemaNoDeshabilitadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede habilitar un sistema.-
    /// </summary>
    public class SistemaNoHabilitadoException : Exception
    {
        public SistemaNoHabilitadoException()
            : base("No se ha podido habilitar el sistema.-")
        {
        }

        public SistemaNoHabilitadoException(string mensaje)
            : base(mensaje)
        {
        }

        public SistemaNoHabilitadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }
}
