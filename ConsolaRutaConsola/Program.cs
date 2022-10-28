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
            var graph = new List<Nodos>();
            var costo = 0;
            var result = new Nodos();
            var knwo = string.Empty;

            // Nodos nodeBogota = new Nodos() { City = "Bogota" };
            //Nodos nodeSm = new Nodos() { City = "Santa Marta" };
            Console.WriteLine("**BIENVENIDO AL PROGRAMA DE RUTA***");
            Console.WriteLine("¿DESEA CONOCER LAS RUTA? Si/No" );
            knwo = Console.ReadLine();
            if (knwo.Equals("Si"))
            {
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
                    Console.WriteLine("01- Principal Coca Cola");
                    Console.WriteLine("02- Sede Sur Coca Cola");
                    Console.WriteLine("03- Sede terminal \b Coca Cola \b0");
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
                        graph = getNodosRuta01(result);

                    }
                    else if (origin.Contains("02"))
                    {
                        Console.WriteLine($"Su opcion es: {origin}");
                        Nodos nodeValledupar = new Nodos() { City = "02- Sede Sur" };
                        Console.WriteLine("------------------------------------------------------------------------");
                        result = nodeValledupar;
                        Console.WriteLine("Sus rutas de reparto son:");
                        Console.WriteLine("01- Centro comercial - Mayales");
                        Console.WriteLine("02- Tienda mayorista ppp");
                        Console.WriteLine("03- Tienda mayorista la esperanza");
                        Console.WriteLine("04- Puntos frio los gallos");
                        Console.WriteLine("05- Ibiza bar");
                        Console.WriteLine("------------------------------------------------------------------------");
                        //var repairt = Console.ReadLine();
                        graph = GetNodosRuta02(result);
                    }
                    else if (origin.Contains("03"))
                    {
                        Console.WriteLine($"Su opcion es: {origin}");
                        Nodos nodeValledupar = new Nodos() { City = "02- Sede Sur" };
                        Console.WriteLine("------------------------------------------------------------------------");
                        result = nodeValledupar;
                        Console.WriteLine("Sus rutas de reparto son:");
                        Console.WriteLine("01- Centro comercial - Mayales");
                        Console.WriteLine("02- Tienda mayorista 12 de octubre");
                        Console.WriteLine("03- Tienda mayorista Panama");
                        Console.WriteLine("04- Tienda Montacarga");
                        Console.WriteLine("05- Tienda mayoritas san fernando");
                        Console.WriteLine("06- Tienda Montacarga");
                        Console.WriteLine("------------------------------------------------------------------------");
                        graph = GetNodosRuta03(nodeValledupar);

                    }

                }
                if (origin.Contains("01"))
                {
                    var service = new Service(graph, 3, result);
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("Lista de producto");
                    Console.WriteLine("01- Bebidas Carbonatada");
                    Console.WriteLine("02- Bebidas no carbonatada");
                    var product = Console.ReadLine();
                    service.Run();
                    Console.WriteLine("Sus rutas son: ");
                    Console.WriteLine(service.GetAllRoutes);
                    var priceProduct = GetPriceProduct(product, 10000);
                    var precioEnvio = 30000;
                    var totalPrice = precioEnvio * (priceProduct / 2);
                    Console.WriteLine($"El costo total del envio es ${totalPrice} ");
                }
                else if (origin.Contains("02"))
                {
                    var service = new Service(graph, 5, result);
                    service.Run();
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("Lista de producto");
                    Console.WriteLine("01- Bebidas Carbonatada");
                    Console.WriteLine("02- Bebidas no carbonatada");
                    var product = Console.ReadLine();
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("Sus rutas son: ");
                    Console.WriteLine(service.GetAllRoutes);
                    var priceProduct = GetPriceProduct(product, 17000);
                    var precioEnvio = 16000;
                    var totalPrice = precioEnvio * (priceProduct / 2);
                    Console.WriteLine($"El costo tota del envio es ${totalPrice} ");
                }
                else if (origin.Contains("3"))
                {
                    var service = new Service(graph, 7, result);
                    service.Run();
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("Lista de producto");
                    Console.WriteLine("01- Bebidas Carbonatada");
                    Console.WriteLine("02- Bebidas no carbonatada");
                    var product = Console.ReadLine();
                    Console.WriteLine("Sus rutas son: ");
                    Console.WriteLine(service.GetAllRoutes);
                    var priceProduct = GetPriceProduct(product, 170000);
                    var precioEnvio = 13300;
                    var totalPrice = precioEnvio * (priceProduct / 2);
                    Console.WriteLine($"El costo total  el envio es ${totalPrice} ");
                }
                else
                {
                    Console.WriteLine("Gracias!!!");
                }

            }
        }



        static List<Nodos> getNodosRuta01(Nodos nodeValledupar)
        {
            Nodos nodeCentro = new Nodos() { City = "Centro comercial - Mayales" };
            Nodos nodeDoce = new Nodos() { City = "Tienda mayorista ppp" };

            nodeValledupar.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 150 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 50 });

            nodeCentro.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 40 });
            nodeCentro.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 130 });

            nodeDoce.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 10 });
            nodeDoce.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 1 });
           var  graph = new List<Nodos>
           {
               nodeValledupar,nodeCentro,nodeDoce
           };
           
            var result = graph;
            return result;
        }
        static List<Nodos> GetNodosRuta02(Nodos nodeValledupar)
        {

            Nodos nodeCentro = new Nodos() { City = "Centro comercial - Mayales" };
            Nodos nodeDoce = new Nodos() { City = "Tienda mayorista ppp" };
            Nodos nodeMEsperanza = new Nodos() { City = "Tienda mayorista la esperanza" };
            Nodos nodePuntoFriog = new Nodos() { City = "Puntos frio los gallo" };
            Nodos nodeIbiza = new Nodos() { City = "Ibiza bar" };
            Console.WriteLine("------------------------------------------------------------------------");
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 150 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 50 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeMEsperanza, Distance = 150 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodePuntoFriog, Distance = 50 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeIbiza, Distance = 150 });

            nodeMEsperanza.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 40 });
            nodeMEsperanza.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 130 });
            nodeMEsperanza.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 50 });
            nodeMEsperanza.Ways.Add(new Way() { Nodo = nodePuntoFriog, Distance = 40 });
            nodeMEsperanza.Ways.Add(new Way() { Nodo = nodeIbiza, Distance = 34 });

            nodeCentro.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 40 });
            nodeCentro.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 130 });
            nodeCentro.Ways.Add(new Way() { Nodo = nodeMEsperanza, Distance = 50 });
            nodeCentro.Ways.Add(new Way() { Nodo = nodePuntoFriog, Distance = 40 });
            nodeCentro.Ways.Add(new Way() { Nodo = nodeIbiza, Distance = 34 });

            nodeDoce.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 16 });
            nodeDoce.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 34 });
            nodeDoce.Ways.Add(new Way() { Nodo = nodeMEsperanza, Distance = 33 });
            nodeDoce.Ways.Add(new Way() { Nodo = nodePuntoFriog, Distance = 29 });
            nodeDoce.Ways.Add(new Way() { Nodo = nodeIbiza, Distance = 53 });

            nodeIbiza.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 45 });
            nodeIbiza.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 33 });
            nodeIbiza.Ways.Add(new Way() { Nodo = nodeMEsperanza, Distance = 12 });
            nodeIbiza.Ways.Add(new Way() { Nodo = nodePuntoFriog, Distance = 54 });
            nodeIbiza.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 65 });

            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 23 });
            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 54 });
            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeMEsperanza, Distance = 23 });
            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 56 });
            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeIbiza, Distance = 105 });

            var graph = new List<Nodos>
            {
                nodeValledupar,nodeCentro,nodeDoce,nodeMEsperanza,nodePuntoFriog,nodeIbiza
            };
            return graph;
        }
        static List<Nodos> GetNodosRuta03(Nodos nodeValledupar)
        {
            Nodos nodeCentro = new Nodos() { City = "Centro comercial - Mayales" };
            Nodos nodeDoce = new Nodos() { City = "Tienda mayorista 12 de octubre" };
            Nodos nodeMEsperanza = new Nodos() { City = "Tienda mayorista Panama" };
            Nodos nodePuntoFriog = new Nodos() { City = "Tienda Montacarga" };
            Nodos nodeIbiza = new Nodos() { City = "Tienda mayoritas san fernando" };
            Nodos nodeMontacraga= new Nodos() { City = "Tienda Montacarga 02" };

            Console.WriteLine("------------------------------------------------------------------------");
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 150 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 50 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeMEsperanza, Distance = 150 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodePuntoFriog, Distance = 50 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeIbiza, Distance = 150 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeMontacraga, Distance = 150 });

            nodeMEsperanza.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 40 });
            nodeMEsperanza.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 130 });
            nodeMEsperanza.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 50 });
            nodeMEsperanza.Ways.Add(new Way() { Nodo = nodePuntoFriog, Distance = 40 });
            nodeMEsperanza.Ways.Add(new Way() { Nodo = nodeIbiza, Distance = 34 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeMontacraga, Distance = 150 });

            nodeCentro.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 40 });
            nodeCentro.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 130 });
            nodeCentro.Ways.Add(new Way() { Nodo = nodeMEsperanza, Distance = 50 });
            nodeCentro.Ways.Add(new Way() { Nodo = nodePuntoFriog, Distance = 40 });
            nodeCentro.Ways.Add(new Way() { Nodo = nodeIbiza, Distance = 34 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeMontacraga, Distance = 150 });


            nodeDoce.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 16 });
            nodeDoce.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 34 });
            nodeDoce.Ways.Add(new Way() { Nodo = nodeMEsperanza, Distance = 33 });
            nodeDoce.Ways.Add(new Way() { Nodo = nodePuntoFriog, Distance = 29 });
            nodeDoce.Ways.Add(new Way() { Nodo = nodeIbiza, Distance = 53 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeMontacraga, Distance = 150 });


            nodeIbiza.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 45 });
            nodeIbiza.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 33 });
            nodeIbiza.Ways.Add(new Way() { Nodo = nodeMEsperanza, Distance = 12 });
            nodeIbiza.Ways.Add(new Way() { Nodo = nodePuntoFriog, Distance = 54 });
            nodeIbiza.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 65 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeMontacraga, Distance = 150 });


            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 23 });
            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 54 });
            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeMEsperanza, Distance = 23 });
            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 56 });
            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeIbiza, Distance = 105 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeMontacraga, Distance = 150 });

            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 23 });
            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 54 });
            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeMEsperanza, Distance = 23 });
            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 56 });
            nodePuntoFriog.Ways.Add(new Way() { Nodo = nodeIbiza, Distance = 105 });
            nodeValledupar.Ways.Add(new Way() { Nodo = nodeMontacraga, Distance = 150 });

            nodeMontacraga.Ways.Add(new Way() { Nodo = nodeCentro, Distance = 150 });
            nodeMontacraga.Ways.Add(new Way() { Nodo = nodeDoce, Distance = 50 });
            nodeMontacraga.Ways.Add(new Way() { Nodo = nodeMEsperanza, Distance = 150 });
            nodeMontacraga.Ways.Add(new Way() { Nodo = nodePuntoFriog, Distance = 50 });
            nodeMontacraga.Ways.Add(new Way() { Nodo = nodeIbiza, Distance = 150 });
            nodeMontacraga.Ways.Add(new Way() { Nodo = nodeValledupar, Distance = 150 });



            var graph = new List<Nodos>
            {
                nodeValledupar,nodeCentro,nodeDoce,nodeMEsperanza,nodePuntoFriog,nodeIbiza,
            };
            return graph;
        }

       static double GetPriceProduct(string tipoProducto,double precio)
        {
            if (tipoProducto.Equals("01"))
            {
                Console.WriteLine($"El precio de producto es ${precio*5}");
                return precio;
            }
            else if (tipoProducto.Equals("02"))
            {
                Console.WriteLine($"El precio de producto es ${precio}");
                return precio;
            }
            return precio;
        }

    }
    
}
