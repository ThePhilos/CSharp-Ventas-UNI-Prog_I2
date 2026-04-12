using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA_UNIDAD_LL.Entidades
{
    public class Venta
    {
        public int Id { get; set; }

        public string Producto { get; set; }

        public string Categoria { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public DateTime Fecha { get; set; }



        public decimal Total

        {

            get { return Cantidad * PrecioUnitario; }
        }
    }
}