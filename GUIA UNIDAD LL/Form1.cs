using GUIA_UNIDAD_LL.Entidades;
using GUIA_UNIDAD_LL.Repositorio;
using GUIA_UNIDAD_LL.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIA_UNIDAD_LL
{
    public partial class Form1 : Form

    {
       
        private readonly IVentaRepository _ventaRepository;
        private readonly VentaService _ventaService;
        private List<Venta> _ventas;
         public Form1()

        {
            _ventaRepository = new VentaRepository();
             _ventaService = new VentaService();
            _ventaRepository = new VentaJsonRepository();
            InitializeComponent();

        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                   
                    _ventas = await _ventaRepository.ObtenerVentasAsync();
                    dgvVentas.DataSource = null;
                    dgvVentas.DataSource = _ventas;

                    lblEstado.Text = "Datos cargados correctamente";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar: " + ex.Message);
                }
        }   }

        private async void btnProcesar_Click(object sender, EventArgs e)
        {
            if (_ventas == null || _ventas.Count == 0)

            {
                MessageBox.Show("Primero debe cargar las ventas.");
                return;

            }
            try

            {
               lblEstado.Text = "Procesando información...";
                progressBar1.Style = ProgressBarStyle.Marquee;
                btnProcesar.Enabled = false;
                string reporte = await _ventaService.ProcesarVentasAsync(_ventas);

                txtResultado.Text = reporte;

                lblEstado.Text = "Procesamiento finalizado.";

            }

               catch (Exception ex)

            {
                MessageBox.Show("Ocurrió un error al procesar las ventas: " + ex.Message);

            }

            finally

            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                btnProcesar.Enabled = true;
            }

        }
         private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = null;
            txtResultado.Clear();
            lblEstado.Text = "Sin datos";
            _ventas.Clear();

        }
    }
}


