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
    public partial class ReportePorTipos : Form
    {
        public ReportePorTipos()
        {
            InitializeComponent();
        }

        private void ReportePorTipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mamaguevo.Credito' Puede moverla o quitarla según sea necesario.
            this.CreditoTableAdapter.Fill(this.mamaguevo.Credito,textBox1.Text, textBox2.Text, txttipor.Text);
            

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
