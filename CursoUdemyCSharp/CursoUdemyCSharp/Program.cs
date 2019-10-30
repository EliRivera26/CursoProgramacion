using System;
using System.Text;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main()
        {
            Object[] parametros = { "Eli", 26, true };
            new Program().metodo(parametros);
            Console.ReadLine();
        }
        private void metodo(object[] parametros)
        {
            String nombre = (string)parametros[0];
            int edad = (int)parametros[1];
            bool valor = (bool)parametros[2];
        }

    }
}