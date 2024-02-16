using System.Collections;
using System.Numerics;

namespace ProductoAppBWA.Models
{
    public class Carrito
    {
        public IDictionary<Producto, Int32> ListaProductos { get; set; }
        public double total { get; set; }
    }
}
