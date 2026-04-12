using GUIA_UNIDAD_LL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA_UNIDAD_LL.Repositorio
{
    public class VentaRepository : IVentaRepository
    {
        public async Task<List<Venta>> ObtenerVentasAsync()

        {

            await Task.Delay(2000);



            return new List<Venta>

         {

             new Venta { Id = 1, Producto = "Laptop", Categoria = "Tecnología", Cantidad = 2, PrecioUnitario = 550m, Fecha = DateTime.Now.AddDays(-1) },

             new Venta { Id = 2, Producto = "Mouse", Categoria = "Tecnología", Cantidad = 5, PrecioUnitario = 20m, Fecha = DateTime.Now.AddDays(-2) },

             new Venta { Id = 3, Producto = "Teclado", Categoria = "Tecnología", Cantidad = 3, PrecioUnitario = 35m, Fecha = DateTime.Now.AddDays(-3) },

             // Nuevos datos requeridos (Categoría Accesorios
                
             new Venta { Id = 4, Producto = "Silla", Categoria = "Oficina", Cantidad = 2, PrecioUnitario = 120m, Fecha = DateTime.Now.AddDays(-2) },

             new Venta { Id = 5, Producto = "Escritorio", Categoria = "Oficina", Cantidad = 1, PrecioUnitario = 250m, Fecha = DateTime.Now.AddDays(-4) },

             new Venta { Id = 6, Producto = "Monitor", Categoria = "Tecnología", Cantidad = 4, PrecioUnitario = 180m, Fecha = DateTime.Now.AddDays(-1) }

         };

        }



    }
}
