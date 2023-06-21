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
    public partial class ReporteTipos2 : Form
    {
        conexion c = new conexion();
        public ReporteTipos2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" | comboBox2.Text == "")
            {

                MessageBox.Show("Llene los campos correctamente", "ADVERTENCIA!");

            }

           else  if (comboBox2.Text == "Pagado")
            {
                ReportePorTipos FREPORTE = new ReportePorTipos();
                FREPORTE.txttipor.Text = comboBox1.Text;
                FREPORTE.textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                FREPORTE.textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
                textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
                c.reportefecha(textBox1.Text, textBox2.Text);
                c.reportetipo(comboBox1.Text);
                FREPORTE.Show();
            }
            else if (comboBox2.Text == "Pendiente")
            {
                ReporteTipoPendiente FREPORTEe = new ReporteTipoPendiente();
                FREPORTEe.mmg3.Text = comboBox1.Text;
                FREPORTEe.mmg1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                FREPORTEe.mmg2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
                textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
                c.reportefecha(textBox1.Text, textBox2.Text);
                c.reportetipo(comboBox1.Text);
                FREPORTEe.Show();
            }
        


           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ReporteTipos2_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
