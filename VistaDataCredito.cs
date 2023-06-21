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
    public partial class VistaDataCredito : Form
    {
        public VistaDataCredito()
        {
            InitializeComponent();
        }

        private void VistaDataCredito_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataCredito.Credito' Puede moverla o quitarla según sea necesario.
            this.CreditoTableAdapter.Fill(this.DataCredito.Credito);

            this.reportViewer1.RefreshReport();
        }
    }
}
