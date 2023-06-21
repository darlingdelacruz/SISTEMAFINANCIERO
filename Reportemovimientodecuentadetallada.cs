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
    public partial class Reportemovimientodecuentadetallada : Form
    {
        public Reportemovimientodecuentadetallada()
        {
            InitializeComponent();
        }

        private void Reportemovimientodecuentadetallada_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TABLAMOVIMIENTOS.movimiento' Puede moverla o quitarla según sea necesario.
            this.movimientoTableAdapter.traermovimientos(this.TABLAMOVIMIENTOS.movimiento,tebo1.Text,tebo2.Text,tebo3.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
