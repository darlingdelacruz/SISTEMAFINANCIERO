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
    public partial class Reporte_General : Form
    {
        conexion c = new conexion();
        public Reporte_General()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" | comboBox1.Text == "" | textBox5.Text == "") 
            {

                MessageBox.Show("Debe de llenar todos los campos.", "ADVERTENCIA!");
            
            
            }
            else
            {

            Recibo FREPORTE = new Recibo();
            FREPORTE.textBox1.Text = textBox4.Text;
            FREPORTE.textBox2.Text = comboBox1.Text;
            FREPORTE.Show();
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            c.llenarTextboxConsulta123(textBox4.Text, textBox5, comboBox1);
        }
        

        private void Reporte_General_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
