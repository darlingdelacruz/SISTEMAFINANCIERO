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
    public partial class ViewConcilicion : Form
    {
        public ViewConcilicion()
        {
            InitializeComponent();
        }

        private void ViewConcilicion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ConciliacionCliente.Credito' Puede moverla o quitarla según sea necesario.
            this.CreditoTableAdapter.Fill(this.ConciliacionCliente.Credito,textBox1.Text,textBox2.Text,textBox3.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
