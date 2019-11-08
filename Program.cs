using System;
using TADs.clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TADs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pila P = new Pila();
            int opt = 0;
            do
            {
                Console.WriteLine("|1.-Pila |");
                Console.WriteLine("|2.-Cola |");
                Console.WriteLine("|3.-SALIR |");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {

                    case 1:

                        do
                        {
                            Console.WriteLine("   |1.-Insertar          |");
                            Console.WriteLine("   |2.-Buscar            |");
                            Console.WriteLine("   |3.-Modificar         |");
                            Console.WriteLine("   |4.-Eliminar          |");
                            Console.WriteLine("   |5.-Desplegar         |");
                            Console.WriteLine("   |6.-Salir             |");
                            opt = int.Parse(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    Console.WriteLine("\n\n Insrte nodo en la pila \n");
                                    P.insertarNodo();
                                    break;
                                case 2:
                                    Console.WriteLine("\n\n Buscar nodo en la Pila \n");
                                    P.BuscarNodo();
                                    break;
                                case 3:
                                    Console.WriteLine("\n\n Modificar nodo en la Pila\n");
                                    P.ModificarNodo();
                                    break;
                                case 4:
                                    Console.WriteLine("\n\n Eliminar nodo en la Pila\n");
                                    P.EliminarNodo();
                                    break;
                                case 5:
                                    Console.WriteLine("\n\n Desplegar nodos de la pila\n");
                                    P.DesplegarPila();
                                    break;


                            }
                        } while (opt != 6);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("   |1.-Insertar          |");
                            Console.WriteLine("   |2.-Buscar            |");
                            Console.WriteLine("   |3.-Modificar         |");
                            Console.WriteLine("   |4.-Eliminar          |");
                            Console.WriteLine("   |5.-Desplegar         |");
                            Console.WriteLine("   |6.-Salir             |");
                            opt = int.Parse(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    Console.WriteLine("\n\n Insrte nodo en la Cola \n");
                                    P.InsertarNodoCola();
                                    break;
                                case 2:
                                    Console.WriteLine("\n\n Buscar nodo en la Cola \n");
                                    P.buscarnodo();
                                    break;
                                case 3:
                                    Console.WriteLine("\n\n Modificar nodo en la Cola\n");
                                    P.modificarnodo();
                                    break;
                                case 4:
                                    Console.WriteLine("\n\n Eliminar nodo en la Cola\n");
                                    P.eliminarcola();
                                    break;
                                case 5:
                                    Console.WriteLine("\n\n Desplegar nodos de la Cola\n");
                                    P.desplegarCola();
                                    break;


                            }
                        } while (opt != 6);
                        break;
                }
            } while (opt != 3);
        }

    }
}
