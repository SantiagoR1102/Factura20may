using System;
using System.Collections.Generic;


namespace Modelos
{
    public class objFacturacion : objBase
    {
        public int Cedula { get; set; }
        public int Total { get; set; }
        public int TotalFinal { get; set; }
        public List<objDetalleFactura> Detalle { get; set; } =new List<objDetalleFactura>();
        //public DateTime Fecha { get; set; }
        //public int NumFactura { get; set; }
    }
}
