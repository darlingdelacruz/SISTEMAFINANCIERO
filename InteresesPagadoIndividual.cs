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
    public partial class InteresesPagadoIndividual : Form
    {
        public InteresesPagadoIndividual()
        {
            InitializeComponent();
        }

        private void InteresesPagadoIndividual_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'InteresesIndividuales.Credito' Puede moverla o quitarla según sea necesario.
            this.CreditoTableAdapter.Fill(this.InteresesIndividuales.Credito,txtfecha1.Text,txtfecha2.Text,Convert.ToInt32(txt4.Text),txt3.Text);
            // TODO: esta línea de código carga datos en la tabla 'InteresesIndividuales.Credito' Puede moverla o quitarla según sea necesario.
           
            // TODO: esta línea de código carga datos en la tabla 'balanzanuevaera.EntradaDiario' Puede
            // TODO: esta línea de código carga datos en la tabla 'InteresesIndividuales.Credito' Puede moverla o quitarla según sea necesario.
           
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
