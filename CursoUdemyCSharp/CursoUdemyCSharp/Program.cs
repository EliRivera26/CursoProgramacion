using System;

namespace CursoUdemyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var (a, b, opcion) = (3, 5, "+");
            var result = opcion switch
            {
                "+" => a + b ,
                "-" => a - b,
                "*" => a * b
            };*/
            var valor = true;
            var count = 1;
            while (valor)
            {
                if (count == 6)
                {
                    valor = false;
                }
                count++;
                Console.Write("Ejecucion {0}", count);
            }


            Console.ReadLine();
        }
    }
}
