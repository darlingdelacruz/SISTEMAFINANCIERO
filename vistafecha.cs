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
    public partial class vistafecha : Form
    {
        public vistafecha()
        {
            InitializeComponent();
        }

        private void vistafecha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'EntradaPorfecha.EntradaDiario' Puede moverla o quitarla según sea necesario.
            this.EntradaDiarioTableAdapter.fechareportada(this.EntradaPorfecha.EntradaDiario,txtfechaf1.Text,txtfechaf2.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
