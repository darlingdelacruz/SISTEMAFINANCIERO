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
    public partial class InteresPagado : Form
    {
        public InteresPagado()
        {
            InitializeComponent();
        }

        private void InteresPagado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'InteresesPagados.Credito' Puede moverla o quitarla según sea necesario.
            this.CreditoTableAdapter.Fill(this.InteresesPagados.Credito,txtfecha1.Text, txtfecha2.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
