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
    public partial class Reportedemovimientos : Form
    {
        public Reportedemovimientos()
        {
            InitializeComponent();
        }

        private void Reportedemovimientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Movimientocompleto.movimiento' Puede moverla o quitarla según sea necesario.
            this.movimientoTableAdapter.traerto(this.Movimientocompleto.movimiento,tebo4.Text,tebo5.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
