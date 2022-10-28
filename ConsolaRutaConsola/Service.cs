using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaRutaConsola
{
    public  class Service
    {
        private List<Nodos> _graph { get; set; }
        private int _n;
        private Nodos _origin { get; set; }
        private List<Route> _solution { get; set; }
        public double Costo { get; set; }

        public string GetAllRoutes
        {
            get
            {
                string result = "";

                foreach (var item in _solution)
                {
                    foreach (var nodos in item.Nodos)
                    {

                        result += nodos.City  + Costo * item.TotalDistance  +",";
                    }
                    result += " " + item.TotalDistance + "\n";
                }
                return result;
            }

        }

        public Service( List<Nodos> graph,int n, Nodos nodos )
        {
            _graph = graph;
            _n = n;
            _origin = nodos;
        }

        public void Run()
        {
            _solution = new List<Route>();

            for (int i = 0; i < _n; i++)
            {
                _solution.Add(GenerateRoute());
            }
            _solution = _solution.OrderBy(d => d.TotalDistance).ToList();
        }

        private Route GenerateRoute()
        {
            var solution = new Route();

            solution.Nodos.Add(_origin);
            Nodos current = _origin;
            for (int i = 0; i < _graph.Count -1; i++)
            {
                Nodos next = null;
                do
                {
                    next = NextNodos(current);
                } while (solution.Nodos.Contains(next));

                solution.Nodos.Add(next);
                solution.TotalDistance += current.Ways.Where(d => d.Nodo.City == next.City).First().Distance;

                current = next;
            }
            solution.Nodos.Add(_origin);
            solution.TotalDistance += current.Ways.Where(d => d.Nodo.City == _origin.City).First().Distance;
            return solution;
        }

        private Nodos NextNodos(Nodos current)
        {
            var nextNode = new Random().Next(0, _graph.Count -1);
            return current.Ways[nextNode].Nodo;
        }
    }
}
