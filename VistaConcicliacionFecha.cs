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
    public partial class VistaConcicliacionFecha : Form
    {
        conexion c = new conexion();
        public VistaConcicliacionFecha()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ViewConcilicion rporte = new ViewConcilicion();
            rporte.textBox3.Text = textBox3.Text;
            rporte.textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            rporte.textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            c.reportefecha(textBox1.Text, textBox2.Text);
            rporte.Show();
        }

        private void VistaConcicliacionFecha_Load(object sender, EventArgs e)
        {

        }
    }
}
