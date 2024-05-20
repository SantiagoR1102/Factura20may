using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class objSubCategoria:objBase
    {
        public int IdCategoria { get; set; }
        public objCategoria categoria { get; set; } = new objCategoria();
        public string Categoria { get; set; }
    }
}
