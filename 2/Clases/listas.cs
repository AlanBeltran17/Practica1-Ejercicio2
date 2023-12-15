using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Clases
{
    internal class listas
    {
        
        public List<int> MultiplosDeDos(List<int> lista)
        {
            List<int> multiplos2 = new List<int>();

            foreach (int i in lista)
            {
                if (i % 2 == 0)
                    if (!multiplos2.Contains(i))  multiplos2.Add(i); 
            }
            multiplos2.Sort();
            return multiplos2;
        }

        internal List<int> MultiplosDeCinco(List<int> lista)
        {
            List<int> multiplos5 = new List<int>();

            foreach (int i in lista)
            {
                if (i % 5 == 0)
                    if (!multiplos5.Contains(i)) multiplos5.Add(i);
            }
            multiplos5.Sort();
            return multiplos5;
        }

        internal List<int> Perfectos(List<int> lista)
        {
            List<int> perfectos = new List<int>();

            foreach (int i in lista)
            {
                if (EsPerfecto(i))
                    if (!perfectos.Contains(i))  perfectos.Add(i);
            }
            perfectos.Sort();
            return perfectos;
        }

        public bool EsPerfecto(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    sum += i;
            }

            if (sum == num) return true;
            return false;
        }

        internal List<int> Primos(List<int> lista)
        {
            List<int> primos = new List<int>();

            foreach (int i in lista)
            {
                if (EsPrimo(i, i-1))
                    if (!primos.Contains(i))  primos.Add(i);
            }
            primos.Sort();
            return primos;
        }

        public bool EsPrimo(int num, int i)
        {
            if (i == 1) return true;
            else if (num == 1 || num % i == 0) return false;
            else return EsPrimo(num, i - 1);
        }

        //Mostrar Lista
        public void MostrarLista(List<int> lista)
        {
            foreach (int i in lista)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
