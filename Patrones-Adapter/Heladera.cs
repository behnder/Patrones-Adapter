using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Adapter
{
    class Heladera : Producto
    {
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Categoria { get; set; }
        public void Descripcion()
        {
            Console.WriteLine("Heladera moderna 100lts con freezer");
        }

        public void DatosParaAlmacenarEnBD()
        {
            Console.WriteLine($"\n<Categoria>{Categoria}</Categoria>\n<Nombre>{Nombre}</Nombre>\n<Modelo>{Modelo}</Modelo>");
        }
    }
}
