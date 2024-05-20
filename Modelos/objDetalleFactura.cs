using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class objDetalleFactura:objBase
    {
        public int Id { get; set; }
        public int Precio { get; set; }
        public int SubTotal { get; set; }
        public int idFactura { get; set; }
        public int Cantidad { get; set; }
        public int IdProducto { get; set; }
    }
}
