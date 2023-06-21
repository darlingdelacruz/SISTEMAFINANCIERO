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
    public partial class CreacionCuentas : Form
    {
        Solonumero s = new Solonumero();
        conexion c = new conexion();
        public CreacionCuentas()
        {
            InitializeComponent();
        }

        private void CreacionCuentas_Load(object sender, EventArgs e)
        {
            textBox5.Text = DateTime.Now.ToString("yyyy/MM/dd");
            //textBox4.Text = DateTime.Now.ToString("yyyy/MM/dd");
            button1.Enabled = false;
            button2.Enabled = false;
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
            textBox3.Enabled = true;
         

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | textBox5.Text == "")
                {

                    {
                        MessageBox.Show("No debe completar todos los campos vacios.", "ADVERTENCIA!");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        comboBox1.Text = "";
                        comboBox2.Text = "";

                    }

                }


                else
                {
                    if (c.cuenta(textBox1.Text) == 0 | c.CATALOGO(textBox1.Text) == 0)
                    {
                        double mierda = Convert.ToDouble(textBox3.Text);
                        c.insertarcuenta(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text);
                        //yo no se utiliza na el textbox3 pero lo puse para no borrar campo en bd
                        c.insertarcatalogo(textBox1.Text,textBox2.Text,comboBox2.Text,textBox6.Text,textBox5.Text,textBox3.Text,comboBox1.Text);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        MessageBox.Show("Se ha insertado correctamente.", "Mensaje!");
                    }
                    else
                    {
                        MessageBox.Show("Esta cuenta ya existe.", "ADVERTENCIA!");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        comboBox1.Text = "";
                        comboBox2.Text = "";

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
            c.selectcuenta(textBox1.Text, textBox2, textBox3,textBox4);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | textBox4.Text == ""|textBox6.Text==""|textBox7.Text=="")
                {
                    MessageBox.Show("Los datos introducidos son incorrectos", "ADVERTENCIA!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else
                {
                    c.UPDATECUENTA(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text);
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox6.Text = comboBox2.Text;
            c.selectcuentapadre(comboBox2.Text, textBox6, textBox7);
        }
    }
}
