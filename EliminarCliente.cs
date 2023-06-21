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
    public partial class EliminarCliente : Form
    {
        conexion c = new conexion();
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                textBox1.Text = "";
                textBox5.Text = "";
                
                
                comboBox1.Items.Clear();
                c.llenarcombo(comboBox1, textBox4.Text);
            
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.llenarTextboxConsulta124(textBox4.Text, textBox5, textBox1,comboBox1.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" | comboBox1.Text == "" | textBox5.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Advertencia:");

            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Los datos introducidos son incorretos", "Advertencia");

            }
            else
            {
                c.eliminarcliente(textBox4.Text, comboBox1.Text);
                c.eliminarconentrada(textBox1.Text);
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";

                MessageBox.Show("Se ha eliminado al cliente", "Mensaje");



            }
        }

        private void EliminarCliente_MouseCaptureChanged(object sender, EventArgs e)
        {
       
        }

        private void EliminarCliente_Click(object sender, EventArgs e)
        {
      
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
