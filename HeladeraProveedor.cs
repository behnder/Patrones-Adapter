using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Adapter
{
    class HeladeraProveedor
    {

        public string Categoria { get; set; }
        public string Nombre { get; set; } 
        public string Modelo { get; set; }
        public void Descripcion()
        {
            Console.WriteLine("Heladera moderna 150lts sin freezer");
        }

        public void DatosParaAlmacenarEnBD()
        {
            Console.WriteLine($"\ncategoria={Categoria}\nnombre={Nombre}\nmodelo={Modelo}\n");
             
        }
    }
}
