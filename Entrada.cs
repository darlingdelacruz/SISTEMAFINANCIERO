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
    public partial class Entrada : Form
    {
        Solonumero S = new Solonumero();
        conexion c = new conexion();
        public Entrada()
        {
            InitializeComponent();
            c.llenaritemsentrada(comboBox3);
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox4.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.selectcatalogoentrada(comboBox3.Text, textBox2, textBox3);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                double mierda = Convert.ToDouble(textBox6.Text);
                c.insertarcuenta1(comboBox3.Text, textBox2.Text, textBox7.Text, textBox8.Text, textBox6.Text, textBox5.Text, textBox4.Text);
                c.UPDATeemontocatalogo(textBox7.Text, comboBox3.Text);
                MessageBox.Show("Entrada realizada con exito.", "Mensaje");

                comboBox3.Text = "";
                textBox2.Text = "";
                textBox3.Text = "0.00";
                textBox5.Text = "";
                textBox6.Text = ".00";
                textBox7.Text = "";
                textBox8.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Los datos introducidos son incorrectos", "ADVERTENCIA!");
                comboBox3.Text = "";
                textBox2.Text = "";
                textBox3.Text = "0.00";
                textBox5.Text = "";
                textBox6.Text = ".00";
                textBox7.Text = "";
                textBox8.Text = "";

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (textBox6.Text == "")
                {

                    textBox6.Text = ".00";

                }
                double monto1 = Convert.ToDouble(textBox6.Text);
                double monto2 = Convert.ToDouble(textBox3.Text);
                double total = 0;
                total = monto1 + monto2;
                textBox7.Text = total.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Has introducido datos erroneos", "ADVERTENCIA!");
            }
        }
    }
}
