using GUIA_UNIDAD_LL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA_UNIDAD_LL.Servicio
{
    public class VentaService

    {

        public async Task<string> ProcesarVentasAsync(List<Venta> ventas)

        {

            return await Task.Run(() =>

            {

                StringBuilder sb = new StringBuilder();
               
                decimal totalDinero = ventas.AsParallel().Sum(v => v.Total);

                // NUEVOS REQUERIMIENTOS DE LA IMAGEN
                int totalProductos = ventas.AsParallel().Sum(v => v.Cantidad); // Cantidad total

                Venta ventaMayor = ventas.AsParallel()
                    .OrderByDescending(v => v.Total)
                    .FirstOrDefault(); // Obtiene el objeto con mayor venta [cite: 130-132]

                sb.AppendLine("===== REPORTE ACTUALIZADO =====");
                sb.AppendLine($"Total vendido: {totalDinero:C}");
                sb.AppendLine($"Cantidad total de productos: {totalProductos}"); // Requerimiento 1

                if (ventaMayor != null)
                {
                    sb.AppendLine($"Venta más alta: {ventaMayor.Producto} ({ventaMayor.Total:C})");
                    sb.AppendLine($"Fecha de venta más alta: {ventaMayor.Fecha:dd/MM/yyyy HH:mm}"); // Requerimiento 2
                }
                
               
                return sb.ToString();
                    
            });
        }


    }
}

