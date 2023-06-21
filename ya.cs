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
    public partial class ya : Form
    {
        public ya()
        {
            InitializeComponent();
        }

        private void ya_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ya1.EntradaDiario' Puede moverla o quitarla según sea necesario.
            this.EntradaDiarioTableAdapter.bien(this.ya1.EntradaDiario,tebo3.Text,tebo1.Text,tebo2.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
