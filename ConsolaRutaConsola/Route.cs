using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaRutaConsola
{
    public class Route
    {
        public List<Nodos> Nodos { get; set; }
        public int TotalDistance { get; set; }

        public Route()
        {
            Nodos = new List<Nodos>();
            TotalDistance = 0;
        }
    }
}
