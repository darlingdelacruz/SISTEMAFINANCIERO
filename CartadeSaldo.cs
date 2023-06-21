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
    public partial class CartadeSaldo : Form
    {
        conexion c = new conexion();
        public CartadeSaldo()
        {
            InitializeComponent();
            
        }

        private void CartadeSaldo_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            c.llenarcombocarta(comboBox1, textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.cartaselect(textBox1.Text,comboBox1.Text,textBox2,textBox3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
                string cedula = Convert.ToString(textBox1.Text);
                int reenganche = Convert.ToInt32(comboBox1.Text);
                if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | comboBox1.Text == "")
                {

                    MessageBox.Show("Debe llenar todos los campos correctamente.", "AVISO");



                }
                string mensaje = textBox3.Text;

                if (mensaje == "Pendiente")
                {

                    MessageBox.Show("Este cliente tiene cuota pendiente en este prestamo.");

                }

                else
                {

                    Carta1 Carta1 = new Carta1();
                    Carta1.textBox1.Text = cedula;
                    Carta1.textBox2.Text = Convert.ToString(reenganche);
                    Carta1.Show();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";

                }
            }
           
        
    }
}
