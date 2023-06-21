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
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Loyal.CatalogoCuenta' Puede moverla o quitarla según sea necesario.
            this.CatalogoCuentaTableAdapter.Fill(this.Loyal.CatalogoCuenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
