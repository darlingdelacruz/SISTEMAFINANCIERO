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
    public partial class Recibo : Form
    {
        public Recibo()
        {
            InitializeComponent();
        }

        private void ReporteCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Cliente.Credito' Puede moverla o quitarla según sea necesario.
            this.CreditoTableAdapter.Fill(this.Cliente.Credito, Convert.ToString(textBox1.Text),Convert.ToInt32(textBox2.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
