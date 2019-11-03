using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemyCSharp
{
    class Program
    {
        static void Main()
        {
            //var data = new Estudiante();
            //data.Nombre = "Eli";
            List<Object> lista = new List<Object>();
            lista.Add("Eli");
            lista.Add(32);
            lista.Add(true);
            //lista.Remove(32);
            //lista.ForEach(item => Console.WriteLine(item));
            lista.Insert(2, "Andy");
            //lista.Clear();
            lista.Reverse();
            Console.WriteLine(lista.Exists(e => e.Equals("Eli")));
            foreach(var item in lista)
            {
                Console.WriteLine(item);
            }
            //for(int i = 0; i < lista.Count; i++)
            //{
            //    Console.WriteLine(lista[i]);
            //}

            //int j = 0;
            //for(; ; )
            //{
            //    if (j < lista.Count)
            //    {
            //        Console.WriteLine(lista[j]);
            //        j++;
            //    }
            //    else
            //        break;
            //}
           // Console.WriteLine(lista.Count);
            Console.ReadKey();

        }
    }
}
