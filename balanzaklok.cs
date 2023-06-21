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
    public partial class balanzaklok : Form
    {
        public balanzaklok()
        {
            InitializeComponent();
        }

        private void balanzaklok_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'balanzanuevaera.EntradaDiario' Puede moverla o quitarla según sea necesario.
            this.EntradaDiarioTableAdapter.tevase(this.balanzanuevaera.EntradaDiario,balanza1.Text,balanza2.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
