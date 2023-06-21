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
    public partial class EditarCliente : Form
    {

        conexion c = new conexion();
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            c.llenarTextboxConsultaeditar(textBox2.Text, comboBox7.Text, textBox11, textBox12, textBox8, textBox13, textBox1, textBox14,textBox10);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.selectbancosolo(comboBox8.Text,textBox1);
            textBox13.Text = comboBox8.Text;

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox14.Text = comboBox6.Text;
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox8.DropDownStyle = ComboBoxStyle.DropDownList;
            c.llenaritems(comboBox8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "" | textBox10.Text == "" | textBox11.Text == "" | textBox12.Text == "" | textBox13.Text == "" | textBox14.Text == "")
            {


                MessageBox.Show("Complete todos los campos correctamente", "Mensaje");
              
            }
            else {
                c.updatecliente(textBox10.Text, textBox2.Text,comboBox7.Text, textBox11.Text, textBox12.Text, textBox8.Text, textBox13.Text, textBox1.Text, textBox14.Text);
                textBox1.Text = "";
                textBox8.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                comboBox6.Text = "";
                comboBox7.Items.Clear();
                comboBox8.Text = "";

                MessageBox.Show("Se ha editado el cliente", "Mensaje");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            comboBox6.Text = "";
            comboBox7.Items.Clear();
            comboBox8.Text = "";

            c.llenarcombo(comboBox7, textBox2.Text);
        }
    }
}
