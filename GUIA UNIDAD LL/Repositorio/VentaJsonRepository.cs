using GUIA_UNIDAD_LL.Entidades;
using GUIA_UNIDAD_LL.Repositorio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 
using System.Threading.Tasks;

public class VentaJsonRepository : IVentaRepository
{
    private readonly string _path = "Ventas.json";

    public async Task<List<Venta>> ObtenerVentasAsync()
    {
        try
        {
            if (!File.Exists(_path)) return new List<Venta>();

            // se usa FileStream para una lectura eficiente
            using (FileStream stream = File.OpenRead(_path))
            {
                
                return await JsonSerializer.DeserializeAsync<List<Venta>>(stream);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al leer el JSON: " + ex.Message);
        }
    }
}