using System;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            contacto1.Nombre = "Ana";
            contacto1.Celular = "(644) 1 29 55 73";
            contacto1.Correo = "ana@correo.com";

            Console.WriteLine("Nombre:" + contacto1.Nombre);
            Console.WriteLine("Celular:" + contacto1.Celular);
            Console.WriteLine("Correo: " + contacto1.Correo);
            Console.WriteLine("Direccion: " + contacto1.Direccion);

            Contacto contacto2 = new Contacto("Ana", "ana@correo.com");

            Console.WriteLine("Contacto 2: ");
            Console.WriteLine("Nombre" + contacto2.Nombre);
            Console.WriteLine("Correo" + contacto2.Correo);
            Console.WriteLine("Direccion" + contacto2.Direccion);


            Console.Read();

        }
    }
}
