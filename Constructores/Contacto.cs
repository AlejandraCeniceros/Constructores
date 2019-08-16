using System;
using System.Collections.Generic;
using System.Text;

namespace Constructores
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Contacto()
        {
            Nombre = "Sin nombre";
            Celular = "Sin Celular";
            Telefono = "Sin telfono";
            Correo = "Sin correo";
            Direccion = "Sin direccion";
        }

        public Contacto(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;
            Celular = "Sin Celular";
            Telefono = "Sin telfono";
            Direccion = "Sin direccion";
        }
        public Contacto(string nombre, string celular, string telefono, string correo, string direccion)
        {

        }

    }
}
