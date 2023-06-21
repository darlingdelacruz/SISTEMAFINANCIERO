using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESTAMOS2
{
    public partial class ReporteGanancias : Form
    {
        public ReporteGanancias()
        {
            InitializeComponent();
        }

        private void ReporteGanancias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TraerGanancias.Credito' Puede moverla o quitarla según sea necesario.
            this.CreditoTableAdapter.TraerPagadillo(this.TraerGanancias.Credito);

            this.reportViewer1.RefreshReport();
        }
    }
}
