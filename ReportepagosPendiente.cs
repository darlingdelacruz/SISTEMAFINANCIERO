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
    public partial class ReportepagosPendiente : Form
    {
        public ReportepagosPendiente()
        {
            InitializeComponent();
        }

        private void ReportepagosPendiente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TraerPendiente.Credito' Puede moverla o quitarla según sea necesario.
            this.CreditoTableAdapter.TraerPendiente(this.TraerPendiente.Credito, vamos.Text, hacerlo.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
