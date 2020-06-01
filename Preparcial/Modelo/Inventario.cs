using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparcial.Modelo
{
    public class Inventario
    {
       public string IdArt { get; }
       public string Producto { get; }
       public string Descripcion { get; }
       public string Precio { get; }
       public string Stock { get; }

        public Inventario(string idArt, string producto, string descripcion, string precio, string stock)
        {
            IdArt = idArt;
            Producto = producto;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
        }
    }
}
