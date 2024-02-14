using System;
using ProductoAppBWA.Models;

namespace ProductoAppBWA.Utils
{
	public class Util
	{
		public static List<Producto> ListaProductos = new List<Producto>
		{
            new Producto{
                IdProducto=1,
                Nombre="Producto 1",
                Descripcion="Descripcion 1",
                Cantidad=1,
                UrlImage=null
            },

            new Producto{
                IdProducto=2,
                Nombre = "Producto 2",
                Descripcion="Descripcion 2",
                Cantidad=2,
                UrlImage=null
            }

        };
	}
}

