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
    public partial class CATALOGO_DE_CUENTA : Form
    {
        conexion c = new conexion();
        public CATALOGO_DE_CUENTA()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            c.buscarcuenta(dataGridView1, textBox1.Text);
        }
    }
}
