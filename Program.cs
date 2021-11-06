using System;

namespace Patrones_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Heladera heladera = new Heladera();
            heladera.Nombre = "Atma";
            heladera.Modelo = "ATH1";
            heladera.Categoria = "Grande";

            HeladeraProveedor heladeraProveedor = new HeladeraProveedor();
            heladeraProveedor.Nombre = "Gafa";
            heladeraProveedor.Modelo = "GFD1";
            heladeraProveedor.Categoria = "Chica";

            AdaptadorProducto adaptador = new AdaptadorProducto(heladeraProveedor);

            heladera.Descripcion();
            heladera.DatosParaAlmacenarEnBD();
            Console.WriteLine("================");
            adaptador.Descripcion();
            adaptador.DatosParaAlmacenarEnBD();

            Console.ReadKey();





        }
    }
}
