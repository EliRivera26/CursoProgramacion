using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemyCSharp
{
    public class Menu : Principal
    {
        private string s;
        public Menu(string s)
        {
            this.s = s;
        }
        public override void getProducto()
        {
            Console.WriteLine(s);
        }
        //public void getProducto()
        //{
        //    Console.WriteLine("Ya casi es mu cumple :)");
        //}
    }
}
