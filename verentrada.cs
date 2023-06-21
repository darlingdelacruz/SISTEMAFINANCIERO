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
    public partial class verentrada : Form
    {
        public verentrada()
        {
            InitializeComponent();
        }

        private void verentrada_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'entradadatos.EntradaDiario' Puede moverla o quitarla según sea necesario.
            this.EntradaDiarioTableAdapter.Fill(this.entradadatos.EntradaDiario,textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
