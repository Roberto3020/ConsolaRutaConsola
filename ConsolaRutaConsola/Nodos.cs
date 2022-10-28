using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaRutaConsola
{
    public class Nodos
    {
        public Nodos()
        {
            Ways = new List<Way>();
        }
        public string CodigoCity { get; set; }
        public string City { get; set; }
        public List<Way> Ways { get; set; }
    }
}
