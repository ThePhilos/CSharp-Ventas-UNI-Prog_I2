using GUIA_UNIDAD_LL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA_UNIDAD_LL.Repositorio
{
    internal interface IVentaRepository
    {
        Task<List<Venta>> ObtenerVentasAsync();
    }
}
