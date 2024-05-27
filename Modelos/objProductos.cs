namespace Modelos
{
    public class objProductos : objBase
    {
        public int idSubCategoria { get; set; }
        public int Precio { get; set; }
        public int CodPro { get; set; }

        public string categoria { get; set; }
        public string SubCategoria { get; set; }
        public int Total { get; set; }
        //public objCategoria categoria { get; set; } = new objCategoria();
        //    public objSubCategoria SubCategoria { get; set; } = new objSubCategoria();


    }
}
