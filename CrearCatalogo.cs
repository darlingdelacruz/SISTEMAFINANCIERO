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
    public partial class CrearCatalogo : Form
    {
        Solonumero s = new Solonumero();
        conexion c = new conexion();
        public CrearCatalogo()
        {
            InitializeComponent();
            textBox5.Text = DateTime.Now.ToString("yyyy/MM/dd");
            button1.Enabled = false;
            button2.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            
        }

        private void CrearCatalogo_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            c.llenaritems2(comboBox2);
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox6.Enabled = false;
            button4.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox4.Enabled = false;
            textBox6.Enabled = true;
            button4.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | textBox4.Text == "")
                {
                    MessageBox.Show("Los datos introducidos son incorrectos", "ADVERTENCIA!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else
                {
                    c.UpdateCatalogo(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,comboBox1.Text);
                   c.UpdateCatalogoconentrada(textBox1.Text, textBox3.Text, textBox4.Text, comboBox1.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    MessageBox.Show("Se ha actualizado la cuenta.", "MENSAJE");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos introducidos son incorrectos", "ADVERTENCIA!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            comboBox2.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" | textBox2.Text == "")
                {

                    {
                        MessageBox.Show("No debe completar todos los campos vacios.", "ADVERTENCIA!");


                    }

                }


                else
                {
                    if (c.CATALOGO(textBox1.Text) == 0)
                    {
                      
                        c.insertarcatalogo(textBox1.Text, textBox2.Text,textBox4.Text,textBox3.Text, textBox5.Text, textBox7.Text,comboBox1.Text);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        MessageBox.Show("Se ha insertado correctamente.", "Mensaje!");
                    }
                    else
                    {
                        MessageBox.Show("Esta cuenta ya existe.", "ADVERTENCIA!");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Los datos introducidos son incorrectos", "ADVERTENCIA!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.selectcatalogo(textBox6.Text,textBox1, textBox2, textBox3, textBox4,comboBox1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox2.Text;
            c.selectcuentapadre(comboBox2.Text, textBox3,textBox4);
        }
    }
}
