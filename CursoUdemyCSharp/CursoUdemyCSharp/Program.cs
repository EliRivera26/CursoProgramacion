using System;
using System.Text;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main()
        {
            int data;
            new Program().metodo(out data);
            Console.WriteLine(data);
            Console.ReadLine();
        //    int edad = 26;
        //    int data = 57;
        //    new Program().metodo(edad);
        //    Console.ReadLine();
        //}
        //private void metodo(in int valor)
        //{
        //    Console.WriteLine(valor);
        }
        private void metodo(out int valor)
        {
            valor = 50 + 20;
        }

    }
}
