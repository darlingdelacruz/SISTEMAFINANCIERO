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
    public partial class ACCESOPAGAR : Form
    {
        conexion c = new conexion();
        public ACCESOPAGAR()
        {
            InitializeComponent();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
           
                
            try
            {
              /*  double valor1 = Convert.ToDouble(textBox8.Text);
                double valor2 = Convert.ToDouble(textBox3.Text);
                double valor3 = Convert.ToDouble(textBox2.Text);
                double valor4 = Convert.ToDouble(textBox6.Text);
                string valor0 = Convert.ToString(textBox16.Text);
              
                double valor5 = 0;

                if (valor0 == "QUINCENAL")
                {
                    valor5 = (valor2 - valor3 + 1) * (valor1) + (valor4*2);
                    textBox12.Text = valor5.ToString();

                }
                else {
                    valor5 = (valor2 - valor3 + 1) * (valor1) + valor4;
                    textBox12.Text = valor5.ToString();
                }
               


                double valor6 = Convert.ToDouble(textBox11.Text);
                double valor7 = Convert.ToDouble(textBox12.Text);
                double valor8 = 0;
                valor8 = valor6 + valor7;
                textBox13.Text = valor8.ToString();
               
               * 
               * */
              
                string nombre = textBox5.Text;
                textBox14.Text = "Pago de saldo de cuenta realizado por: " + nombre;

                if (textBox26.Text != "" | textBox24.Text != "" | textBox5.Text != "" | comboBox1.Text != "" | textBox18.Text != "" | textBox16.Text != "")
                {
                   string cedula = Convert.ToString(textBox4.Text);
                    int reenganche = Convert.ToInt32(comboBox1.Text);
                    c.selectnumeroentrada(textBox20);
                    int nocuentap = Convert.ToInt32(textBox20.Text);
                    nocuentap++;
                    textBox20.Text = nocuentap.ToString();

                  c.PAGARTODO(textBox4.Text, comboBox1.Text, textBox2.Text, textBox3.Text,textBox1.Text);


                    //c.insertarfechatotal(textBox1.Text, textBox4.Text);
                    //c.UPDATeemonto(textBox13.Text, textBox9.Text);
                   // c.insertarcuenta1(textBox9.Text, textBox10.Text, textBox13.Text, textBox15.Text, textBox12.Text, textBox14.Text, textBox1.Text);
                    c.insertarentradaCREDITO(textBox20.Text, textBox1.Text, textBox14.Text, textBox10.Text, textBox9.Text, textBox26.Text, textBox8.Text, txt2.Text, txt3.Text, txt4.Text);
                    //antes estaban sin el 2
                    c.insertarentradaCREDITO2(textBox20.Text, textBox1.Text, textBox14.Text, textBox23.Text, textBox22.Text, textBox8.Text, textBox26.Text, textBox21.Text, textBox25.Text, textBox29.Text);
                    MessageBox.Show("Se ha Saldado la esta cuenta.", "Mensaje");
                    textBox4.Text = "";
                    textBox5.Text = "";
                    iconPictureBox2.Enabled = false;
                    iconPictureBox3.Enabled = true;
                    textBox6.Text = "";
                    textBox8.Text = "";
                    textBox7.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox16.Text = "";
                    textBox26.Text = "";
                    textBox18.Text = "";
                    textBox24.Text = "";
                    Carta1 Carta1 = new Carta1();
                    Carta1.textBox1.Text = cedula;
                    Carta1.textBox2.Text = Convert.ToString(reenganche);
                    Carta1.Show();
                }
                else
                {

                    MessageBox.Show("Debes llenar todos los campos.", "Mensaje");

                }
              
                
                
            }



            
            catch (Exception ex)
            {
                MessageBox.Show("Debes llenar todos los campos correctamente.", "Mensaje");
            }
           

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            iconPictureBox2.Enabled = false;
            c.llenarcombo(comboBox1, textBox4.Text);
            textBox5.Text = "";
            textBox26.Text ="";
            textBox27.Text ="";
            textBox18.Text ="";
            textBox16.Text ="";
             textBox2.Text ="";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {




                //c.llenarTextboxConsulta1(textBox4.Text,textBox5);



            }
            catch (Exception ex) { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ACCESOPAGAR_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox1.Text = DateTime.Now.ToString("yyyy/MM/dd");
            iconPictureBox2.Enabled = false;
            iconPictureBox1.Enabled = true;
            c.selectnumeroentrada(textBox20);
            int nocuenta = Convert.ToInt32(textBox20.Text);
            nocuenta++;
            textBox20.Text = nocuenta.ToString();
        }

        private void ACCESOPAGAR_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

               

                textBox26.Text = "";
                iconPictureBox2.Enabled = false;
                c.llenarTextboxConsulta1(textBox4.Text, comboBox1.Text, textBox5, textBox2, textBox9, textBox10, textBox7,textBox16,textBox18,textBox24,textBox27);
                c.llenarTextboxbobo(textBox4.Text, comboBox1.Text,textBox28);
               // c.llenarTextboxConsulta12(textBox4.Text, comboBox1.Text, textBox5, textBox3,textBox6);
                c.selectbanco(textBox9.Text, textBox10, textBox11);
                double periodo = Convert.ToDouble(textBox2.Text);
                periodo++;
                textBox2.Text = Convert.ToString(periodo);
            


            }
            catch (Exception ex) 
            {
                MessageBox.Show("Debe llenar los campos correctamente", "ADVERTENCIA");
            }
           
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

            try
            {
                c.selectcatalogoentrada12(textBox9.Text, txt2, txt3, txt4);


                if (textBox4.Text == "" | textBox5.Text == "" | textBox1.Text == "")
                {
                    MessageBox.Show("Debe llenar los campos correctamente", "ADVERTENCIA");
                    iconPictureBox2.Enabled = false;
                }

                else if (textBox27.Text == "ESPECIAL" && textBox16.Text == "MENSUAL")
                {

                    iconPictureBox2.Enabled = true;
                    double valor1 = Convert.ToDouble(textBox28.Text);
                    double valor2 = Convert.ToDouble(textBox24.Text);
                    double total = 0;

                    total = valor1 + valor2;


                    textBox26.Text = total.ToString();

                }


                else if (textBox16.Text == "QUINCENAL" && textBox27.Text == "ESPECIAL")
                {

                    iconPictureBox2.Enabled = true;
                    double valor1 = Convert.ToDouble(textBox28.Text);
                    double valor2 = Convert.ToDouble(textBox24.Text);
                    double total = 0;

                    total = valor1 + (valor2 * 2);


                    textBox26.Text = total.ToString();

                }
                else if (textBox16.Text == "QUINCENAL")
                {

                    iconPictureBox2.Enabled = true;
                    double valor1 = Convert.ToDouble(textBox18.Text);
                    double valor2 = Convert.ToDouble(textBox24.Text);
                    double total = 0;

                    total = valor1 + (valor2 * 2);


                    textBox26.Text = total.ToString();

                }
                else if (textBox16.Text == "MENSUAL")
                {

                    iconPictureBox2.Enabled = true;
                    double valor1 = Convert.ToDouble(textBox18.Text);
                    double valor2 = Convert.ToDouble(textBox24.Text);
                    double total = 0;

                    total = valor1 + valor2;


                    textBox26.Text = total.ToString();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Debe llenar los campos correctamente", "ADVERTENCIA");
            }

        





    }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {


            try
            {
                c.selectcatalogoentrada12(textBox9.Text, txt2, txt3, txt4);


                if (textBox4.Text == "" | textBox5.Text == "" | textBox1.Text == "")
                {
                    MessageBox.Show("Debe llenar los campos correctamente", "ADVERTENCIA");
                    iconPictureBox2.Enabled = false;
                }

                else if (textBox27.Text == "ESPECIAL" && textBox16.Text == "MENSUAL")
                {

                    iconPictureBox2.Enabled = true;
                    double valor1 = Convert.ToDouble(textBox28.Text);
                    double valor2 = Convert.ToDouble(textBox24.Text);
                    double total = 0;

                    total = valor1 + valor2;


                    textBox26.Text = total.ToString();

                }


                else if (textBox16.Text == "QUINCENAL" && textBox27.Text == "ESPECIAL")
                {

                    iconPictureBox2.Enabled = true;
                    double valor1 = Convert.ToDouble(textBox28.Text);
                    double valor2 = Convert.ToDouble(textBox24.Text);
                    double total = 0;

                    total = valor1 + (valor2 * 2);


                    textBox26.Text = total.ToString();

                }
                else if (textBox16.Text == "QUINCENAL")
                {

                    iconPictureBox2.Enabled = true;
                    double valor1 = Convert.ToDouble(textBox18.Text);
                    double valor2 = Convert.ToDouble(textBox24.Text);
                    double total = 0;

                    total = valor1 + (valor2 * 2);


                    textBox26.Text = total.ToString();

                }
                else if (textBox16.Text == "MENSUAL")
                {

                    iconPictureBox2.Enabled = true;
                    double valor1 = Convert.ToDouble(textBox18.Text);
                    double valor2 = Convert.ToDouble(textBox24.Text);
                    double total = 0;

                    total = valor1 + valor2;


                    textBox26.Text = total.ToString();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Debe llenar los campos correctamente", "ADVERTENCIA");
            }

        }

       /* private void iconPictureBox2_Click(object sender, EventArgs e)
        {


            try
            {
                  double valor1 = Convert.ToDouble(textBox8.Text);
                  double valor2 = Convert.ToDouble(textBox3.Text);
                  double valor3 = Convert.ToDouble(textBox2.Text);
                  double valor4 = Convert.ToDouble(textBox6.Text);
                  string valor0 = Convert.ToString(textBox16.Text);

                  double valor5 = 0;

                  if (valor0 == "QUINCENAL")
                  {
                      valor5 = (valor2 - valor3 + 1) * (valor1) + (valor4*2);
                      textBox12.Text = valor5.ToString();

                  }
                  else {
                      valor5 = (valor2 - valor3 + 1) * (valor1) + valor4;
                      textBox12.Text = valor5.ToString();
                  }



                  double valor6 = Convert.ToDouble(textBox11.Text);
                  double valor7 = Convert.ToDouble(textBox12.Text);
                  double valor8 = 0;
                  valor8 = valor6 + valor7;
                  textBox13.Text = valor8.ToString();

                

                string nombre = textBox5.Text;
                textBox14.Text = "Pago de saldo de cuenta realizado por: " + nombre;

                if (textBox26.Text != "" | textBox24.Text != "" | textBox5.Text != "" | comboBox1.Text != "" | textBox18.Text != "" | textBox16.Text != "")
                {
                    string cedula = Convert.ToString(textBox4.Text);
                    int reenganche = Convert.ToInt32(comboBox1.Text);
                    c.selectnumeroentrada(textBox20);
                    int nocuentap = Convert.ToInt32(textBox20.Text);
                    nocuentap++;
                    textBox20.Text = nocuentap.ToString();

                    c.PAGARTODO(textBox4.Text, comboBox1.Text, textBox2.Text, textBox3.Text);
                    //c.insertarfechatotal(textBox1.Text, textBox4.Text);
                    //c.UPDATeemonto(textBox13.Text, textBox9.Text);
                    // c.insertarcuenta1(textBox9.Text, textBox10.Text, textBox13.Text, textBox15.Text, textBox12.Text, textBox14.Text, textBox1.Text);
                    c.insertarentradaCREDITO(textBox20.Text, textBox1.Text, textBox14.Text, textBox10.Text, textBox9.Text, textBox26.Text, textBox8.Text, txt2.Text, txt3.Text, txt4.Text);
                    //antes estaban sin el 2
                    c.insertarentradaCREDITO2(textBox20.Text, textBox1.Text, textBox14.Text, textBox23.Text, textBox22.Text, textBox8.Text, textBox26.Text, textBox21.Text, textBox25.Text, textBox29.Text);
                    MessageBox.Show("Se ha Saldado la esta cuenta.", "Mensaje");
                    textBox4.Text = "";
                    textBox5.Text = "";
                    iconPictureBox2.Enabled = false;
                    iconPictureBox3.Enabled = true;
                    textBox6.Text = "";
                    textBox8.Text = "";
                    textBox7.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox16.Text = "";
                    textBox26.Text = "";
                    textBox18.Text = "";
                    textBox24.Text = "";
                    Carta1 Carta1 = new Carta1();
                    Carta1.textBox1.Text = cedula;
                    Carta1.textBox2.Text = Convert.ToString(reenganche);
                    Carta1.Show();
                }
                else
                {

                    MessageBox.Show("Debes llenar todos los campos.", "Mensaje");

                }



            }




            catch (Exception ex)
            {

            }


        }
    */

      


    }
}