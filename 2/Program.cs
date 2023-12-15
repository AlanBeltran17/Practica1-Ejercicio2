using _2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        
        static void Main(string[] args)
        {

        List<int> numeros = new List<int>();
        int n;

        Console.Write("¿Cuántos numeros quieres Añadir?:  ");
        if (int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Añada {0} numeros", n);
            for (int i = 0; i < n; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("¡NO ES UN ENTERO!, por favor ingrese un número ENTERO");
                    i--;
                }
            }

            listas lista = new listas();

            //Listas
            List<int> MultiplosDe2 = lista.MultiplosDeDos(numeros);
            List<int> Primos = lista.Primos(numeros);
            List<int> MultiplosDe5 = lista.MultiplosDeCinco(numeros);
            List<int> Perfectos = lista.Perfectos(numeros);
            Console.WriteLine();
            Console.Write("Lista 1:   ");
            lista.MostrarLista(MultiplosDe2);
            Console.Write("Lista 2:   ");
            lista.MostrarLista(Primos);
            Console.Write("Lista 3:   ");
            lista.MostrarLista(MultiplosDe5);
            Console.Write("Lista 4:   ");
            lista.MostrarLista(Perfectos);

        }
        else
        {
            Console.WriteLine("No es un número válido para la cantidad de números a ingresar.");
        }



        Console.ReadKey();
        }
    }
