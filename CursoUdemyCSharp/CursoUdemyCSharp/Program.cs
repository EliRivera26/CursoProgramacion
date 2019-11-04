using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemyCSharp
{
    class Program : Menu
    {
        public Program(String s) : base(s)
        {

        }
        static void Main()
        {
            new Program("Ya casi es mi cumple").getProducto();
            Console.ReadKey();

        }
        //protected override void getProducto()
        //{
        //    Console.WriteLine("El 10 de enero");
        //}
    }
}
