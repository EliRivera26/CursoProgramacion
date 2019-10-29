using System;
using System.Text;

namespace CursoUdemyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modificar y Crear métodos

            var data = new Program();
            //data.metodoPrivado();
            Console.WriteLine(data.metodoPrivado());
            Console.ReadLine();


        }
        private string metodoPrivado()
        {
            return $"Eli Rivera {26}";
        }
        /*public void metodoPublico()
        {
            Console.WriteLine("Eli");
            Console.ReadLine();
        }*/
    }
}
