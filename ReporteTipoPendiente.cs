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
    public partial class ReporteTipoPendiente : Form
    {
        public ReporteTipoPendiente()
        {
            InitializeComponent();
        }

        private void ReporteTipoPendiente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'maxima.Credito' Puede moverla o quitarla según sea necesario.
            this.CreditoTableAdapter.foco(this.maxima.Credito,mmg1.Text,mmg2.Text,mmg3.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
