using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Adapter
{
    class AdaptadorProducto : Producto
    {
        HeladeraProveedor heladera;

        public AdaptadorProducto(HeladeraProveedor heladera)
        {
            this.heladera = heladera;
        }

        public void Descripcion()
        {
            heladera.Descripcion();
        }

        public void DatosParaAlmacenarEnBD()
        {
            heladera.DatosParaAlmacenarEnBD();
        }
    }
}
