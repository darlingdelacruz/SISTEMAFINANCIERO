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
    public partial class reporteInteresesPagadoIndividual : Form
    {
        conexion c = new conexion();

        public reporteInteresesPagadoIndividual()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Este Cliente No Existe", "Error");
              
            }

            else 
            
            {
                InteresesPagadoIndividual rporte = new InteresesPagadoIndividual();
                rporte.txt3.Text = textBox3.Text;
                rporte.txt4.Text = comboBox1.Text;
                rporte.txtfecha1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                rporte.txtfecha2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
                textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
                c.reportefecha(textBox1.Text, textBox2.Text);
                rporte.Show();
            }
        }

        private void reporteInteresesPagadoIndividual_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "";
            comboBox1.Items.Clear();
            c.traerNombre(textBox3.Text,textBox4,comboBox1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
