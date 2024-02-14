using System;
using ProductoAppBWA.Models;

namespace ProductoAppBWA.Service
{
	public interface IAPIService
	{
        public Task<List<Producto>> GetProductos();
        public Task<Producto> GetProducto(int id);
        public Task<Producto> PostProducto(Producto producto);
        public Task<Producto> PutProducto(int IdProducto, Producto producto);
        public Task<Boolean> DeleteProducto(int IdProducto);
    }
}

