using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemyCSharp
{
    public class Menu
    {
        private string s;
        public Menu(string s)
        {
            this.s = s;
        }
        protected virtual void getProducto()
        {
            Console.WriteLine(s);
        }
        //public void getProducto()
        //{
        //    Console.WriteLine("Ya casi es mu cumple :)");
        //}
    }
}
