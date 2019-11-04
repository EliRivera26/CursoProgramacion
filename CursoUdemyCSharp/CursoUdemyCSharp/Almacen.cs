using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_de_net_core
{
    public abstract class Almacen
    {
        public abstract List<Producto> getProducto(string producto);
        public abstract void addProducto(Producto producto);
    }
}
