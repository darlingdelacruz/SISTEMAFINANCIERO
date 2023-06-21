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
    public partial class ReportePagadosF : Form
    {
        conexion c = new conexion();
        public ReportePagadosF()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Pagado")
            {
                ReportePagadoCompleto rporte = new ReportePagadoCompleto();
                rporte.txtfecha1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                rporte.txtfecha2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
                textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
                c.reportefecha(textBox1.Text, textBox2.Text);
                rporte.Show();
            }
            else if (comboBox1.Text == "Pendiente")
            {

                ReportepagosPendiente rportep = new ReportepagosPendiente();
                rportep.vamos.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                rportep.hacerlo.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
                textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
                c.reportefecha(textBox1.Text, textBox2.Text);
                rportep.Show();
            }
            else {

                MessageBox.Show("Llene los campos correctamente","ADVERTENCIA!");
            }

        }

        private void ReportePagadosF_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
