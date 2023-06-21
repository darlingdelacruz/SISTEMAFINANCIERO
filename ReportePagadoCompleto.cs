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
    public partial class ReportePagadoCompleto : Form
    {
        public ReportePagadoCompleto()
        {
            InitializeComponent();
        }

        private void ReportePagadoCompleto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TraerPagados.Credito' table. You can move, or remove it, as needed.
            this.CreditoTableAdapter.TraerPagado(this.TraerPagados.Credito,txtfecha1.Text,txtfecha2.Text);
            // TODO: This line of code loads data into the 'TraerPagados.Credito' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'TraerPagados.Credito' table. You can move, or remove it, as needed.
          
          
            // TODO: esta línea de código carga datos en la tabla 'TraerPagados.Credito' Puede moverla o quitarla según sea necesario.
            this.reportViewer1.RefreshReport();
        }

       
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
