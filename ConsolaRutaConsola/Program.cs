using System;
using System.Collections.Generic;

namespace ConsolaRutaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var origin = string.Empty;
            var destiny = string.Empty;
            var transporte = string.Empty;
            var graph = new  List<Nodos>();
            var costo = 0;
            var result = new Nodos();


            // Nodos nodeBogota = new Nodos() { City = "Bogota" };
            //Nodos nodeSm = new Nodos() { City = "Santa Marta" };
            Console.WriteLine("**BIENVENIDO AL PROGRAMA DE RUTA***");
            Console.WriteLine("Por favor seleccione alguna de las dos sgt ruta");
            Console.WriteLine("*** Urbana ***");
            Console.WriteLine("*** Nacional ***");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine($"Por favor ingrese su opcion:");
            var typeRoute = Console.ReadLine();
            Console.WriteLine($"Su opcion es: {typeRoute}");
            if (typeRoute.Equals("Urbana"))
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("Puntos de partidas");
                Console.WriteLine("01- Principal Coca");
                Console.WriteLine("02- Sede Sur");
                Console.WriteLine("Por favor ingrese su origen");
                origin = Console.ReadLine();
                if (origin.Contains("01"))
                {
                    Console.WriteLine($"Su opcion es: {origin}");
                    Nodos nodeValledupar = new Nodos() { City = "Norte-Sede princiapl" };
                    Console.WriteLine("------------------------------------------------------------------------");
                    result = nodeValledupar;
                    Console.WriteLine("Sus rutas de reparto son:");
                    Console.WriteLine("01- Centro comercial - Mayales");
                    Console.WriteLine("02- Tienda mayorista ppp");
                    Console.WriteLine("------------------------------------------------------------------------");
                    //var repairt = Console.ReadLine();

                        Nodos nodeCentro = new Nodos() { City = "Centro comercial - Mayales" };
                        Nodos nodeDoce = new Nodos() { City = "Tienda mayorista ppp" };

                        nodeValledupar.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 150 });
                        nodeValledupar.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 50 });

                        nodeCentro.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 40 });
                        nodeCentro.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 130 });

                        nodeDoce.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 10 });
                        nodeDoce.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 1 });

                    costo = 40000;
                        graph = new List<Nodos>
                        {
                            nodeValledupar,nodeCentro,nodeDoce
                        };
                }
                else if (origin.Contains("01"))
                {

                }
            }
            var service = new Service(graph, 2, result);
            service.Run();
            Console.WriteLine("Sus rutas son: ");
            Console.WriteLine(service.GetAllRoutes);
            Console.WriteLine($"Su costo por el transporte es{costo}");
        }



    }
}


/*nodeValledupar.Ways.Add(new Way() { Nodo = nodeBqll, Distance = 100 });
  nodeValledupar.Ways.Add(new Way() { Nodo = nodeBogota, Distance = 250 });
  nodeValledupar.Ways.Add(new Way() { Nodo = nodeSm, Distance = 70 });

  nodeBqll.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 150 });
  nodeBqll.Ways.Add(new Way() { Nodo = nodeBogota, Distance = 350 });
  nodeBqll.Ways.Add(new Way() { Nodo = nodeSm, Distance = 60 });

  nodeBogota.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 120 });
  nodeBogota.Ways.Add(new Way() { Nodo = nodeBqll, Distance = 240 });
  nodeBogota.Ways.Add(new Way() { Nodo = nodeSm, Distance = 400 });

  nodeSm.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 60 });
  nodeSm.Ways.Add(new Way() { Nodo = nodeBqll, Distance = 40 });
  nodeSm.Ways.Add(new Way() { Nodo = nodeBogota, Distance = 750 });*/