using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADs.clases
{
    class Pila
    {
        private Class1 Primero = new Class1();
        private Class1 Ultimo = new Class1();
        public Pila()
        {
            Primero = null;
            Ultimo = null;
        }
        public void insertarNodo()
        {
            Class1 Nuevo = new Class1();
            Console.Write("\n Ingrese Dato del nuevo nodo \n");
            Nuevo.Dato = int.Parse(Console.ReadLine());
            
            Nuevo.Siguiente = Primero;
            Primero = Nuevo;

            Console.WriteLine("\n Nodo Ingresado\n\n");

            

        }
        public void BuscarNodo()
        {
            Class1 Actual = new Class1();
            Actual = Primero;
            bool Encontrado = false;
            
            Console.Write("Ingrese Dato Buscado: ");
            int nodobuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado!=true)
                {
                  if(Actual.Dato==nodobuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato ( {0} ) Encontrado\n", nodobuscado);
                        Encontrado = true;

                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("Nodo no Encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n La pila se encuentra vacia\n\n");
            }
        }
        public void ModificarNodo()
        {
            Class1 Actual = new Class1();
            Actual = Primero;
            bool Encontrado = false;

            Console.Write("Ingrese Dato Buscado para modificar: ");
            int nodobuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodobuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato ( {0} ) Encontrado\n", nodobuscado);
                        Console.WriteLine("Ingrese el nuevo dato");
                        Actual.Dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nodo Modificado \n\n");
                        
                        Encontrado = true;

                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("Nodo no Encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n La pila se encuentra vacia\n\n");
            }
        }
        public void DesplegarPila()
        {
            Class1 Actual = new Class1();
            Actual = Primero;
            if (Primero != null)
            {
             while(Actual!=null)
                {
                    Console.WriteLine(" "+Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n La pila se encuentra vacia\n\n");
            }
        }
        public void EliminarNodo()
        {
            Class1 Actual = new Class1();
            Actual = Primero;
            Class1 Anterior = new Class1();
            Anterior = null;
            bool Encontrado = false;

            Console.Write("Ingrese Dato Buscado: ");
            int nodobuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodobuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato ( {0} ) Encontrado\n", nodobuscado);
                        if(Actual==Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                        Console.WriteLine("\n Nodo eliminado\n\n");
                        
                        Encontrado = true;

                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("Nodo no Encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n La pila se encuentra vacia\n\n");
            }
        }
        // COLA
        public void InsertarNodoCola()
        {
            Class1 nuevo = new Class1();
            Console.WriteLine("Ingrese el dato del nodo");
            nuevo.Dato = int.Parse(Console.ReadLine());
            if (Primero == null)
            {
                Primero = nuevo;
                Primero.Siguiente = null;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                Ultimo = nuevo;
            }

        }
        public void desplegarCola()
        {
            Class1 actual = new Class1();
            actual = Primero;
            if (Primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine(" " + actual.Dato);
                    actual = actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\nLa cola está vacía\n");
            }
        }
        public void buscarnodo()
        {
            Class1 actual = new Class1();
            actual = Primero;
            bool encontrado = false;
            Console.WriteLine("Ingrese el valor del nodo a buscar");
            int nodoencontrado = int.Parse(Console.ReadLine());
            if (Primero != null && encontrado != true)
            {
                while (actual != null)
                {
                    if (actual.Dato == nodoencontrado)
                    {
                        Console.WriteLine("\nEl nodo con el valor {0}, encontrado\n ", nodoencontrado);
                        encontrado = true;
                    }
                    actual = actual.Siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("\nNodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\nLa cola está vacía\n");
            }
        }
        public void modificarnodo()
        {
            Class1 actual = new Class1();
            actual = Primero;
            bool encontrado = false;
            Console.WriteLine("Ingrese el valor del nodo a modificar");
            int nodoencontrado = int.Parse(Console.ReadLine());
            if (Primero != null && encontrado != true)
            {
                while (actual != null)
                {
                    if (actual.Dato == nodoencontrado)
                    {
                        Console.WriteLine("\nEl nodo con el valor {0}, encontrado \n", nodoencontrado);
                        Console.WriteLine("\nIngrese el nuevo dato del nodo\n");
                        actual.Dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nEl nodo fue modificado\n");
                        encontrado = true;
                    }
                    actual = actual.Siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("\nNodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\nLa cola está vacía\n");
            }
        }
        public void eliminarcola()
        {
            Class1 actual = new Class1();
            actual = Primero;
            Class1 anterior = new Class1();
            anterior = null;
            bool encontrado = false;
            Console.WriteLine("Ingrese el valor del nodo a buscar para eliminar");
            int nodoencontrado = int.Parse(Console.ReadLine());
            if (Primero != null && encontrado != true)
            {
                while (actual != null)
                {
                    if (actual.Dato == nodoencontrado)
                    {
                        Console.WriteLine("\nEl nodo con el valor {0}, encontrado\n ", nodoencontrado);

                        if (actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if (actual == Ultimo)
                        {
                            anterior.Siguiente = null;
                            Ultimo = anterior;
                        }
                        else
                        {
                            anterior.Siguiente = actual.Siguiente;
                        }
                        Console.WriteLine("Nodo eliminado");
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.Siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("\nNodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\nLa cola está vacía\n");
            }

        }
    }

}
