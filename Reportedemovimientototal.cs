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
    public partial class Reportedemovimientototal : Form
    {
        conexion c = new conexion();
        public Reportedemovimientototal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reportedemovimientos rporte = new Reportedemovimientos();
            rporte.tebo4.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            rporte.tebo5.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            c.reportefecha1(textBox1.Text, textBox2.Text);
            rporte.Show();
        }
    }
}
