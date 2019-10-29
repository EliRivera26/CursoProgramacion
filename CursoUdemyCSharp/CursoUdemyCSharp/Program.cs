using System;

namespace CursoUdemyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manipular información de cadenas dede texto.

            //Una subcadena es cualquier secuencia de caracteres que está contenida en una cadena.
            var curso = "Curso de C# desde cero";
            var name = "Curso de C# desde cero y a empezar";
            //Console.WriteLine("Cadena: {0}", curso.Substring(9, 11));
            var sub = curso.Remove(5, 11);                                                          //Elimina parte de la cadena
            //Console.WriteLine("Cadena: {0}", sub);
            //var data = curso.IndexOf("desde");                                                   //Cuenta el número de caracteres que se encuentran antes de llegar al caracter indicado (unicamente utilizando comillas simples se ingresa un caracter, mientras que con comillas dobles se puede ingresar una palabra completa)
            //Console.WriteLine("Cadena: {0}", data);
            //var data = curso.Equals(name);                                                          //Compara el tamaño de la cadena name y curso, manda true o false
            //Console.WriteLine("Cadena: {0}", data);
            
            //El foreach itera la cedan de texto
            foreach (var item in curso)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            
        }
    }
}
