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
    public partial class MD : Form
    {
        public MD()
        {
            InitializeComponent();
        }

        private void MD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'balancesnuevos.EntradaDiario' Puede moverla o quitarla según sea necesario.
            this.EntradaDiarioTableAdapter.Fill(this.balancesnuevos.EntradaDiario,textBox1fecha.Text,textBox2fecha.Text);
          

            this.reportViewer1.RefreshReport();
        }
    }
}
