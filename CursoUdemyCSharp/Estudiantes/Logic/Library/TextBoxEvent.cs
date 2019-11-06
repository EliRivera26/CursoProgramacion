using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //Condición que solo nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            //Condición que permite no dar salto de linea cuando se orpime enter
            else if(e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
        }
    }
}
