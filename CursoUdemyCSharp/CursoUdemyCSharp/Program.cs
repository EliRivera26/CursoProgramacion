using System;
using System.Text;

namespace Curso_de_net_core
{
    class Program
    {
        readonly int valor;
        const int VALOR = 98;

        public Program()
        {
            valor = 10;
        }
        static void Main()
        {
            var data = new Program();

            Console.WriteLine($"{VALOR}");

            //Argumentos opcionales

            //    var data = new Program();
            //    data.metodo("C#");
            //}
            //private void metodo(String curso, String nombre = "Eli", int cantidad = 26)
            //{
            //    Console.WriteLine(curso);
        }
    }
}
