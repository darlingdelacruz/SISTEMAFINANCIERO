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
    public partial class Abono : Form
    {
        conexion c = new conexion();
         DateTime FECHA = new DateTime();
        public Abono()
        {
            InitializeComponent();
            textBox23.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void Abono_Load(object sender, EventArgs e)
        {
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
           iconPictureBox2.Enabled = false;
            //c.selectcatalogoentrada123(textBox22, textBox16, textBox17, textBox18, textBox19);
            c.selectnumeroentrada(textBox20);
            double nocuenta = Convert.ToDouble(textBox20.Text);
            nocuenta++;
            textBox20.Text = nocuenta.ToString();
            
            textBox8.Text = DateTime.Now.ToString("yyyy/MM/dd");
         

           
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            c.llenarcombo(comboBox2, textBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.selectcatalogoentrada12(comboBox2.Text, textBox13, textBox14, textBox15);
            c.llenarTextboxConsultaabono(textBox1.Text,comboBox2.Text,textBox2,textBox26,textBox6,textBox27,textBox3,textBox28,textBox4,textBox5,textBox11,textBox24,textBox29);
            c.llenarPeriododesc(textBox1.Text,comboBox2.Text,textBox9);
            c.llenarTextboxbobo(textBox1.Text,comboBox2.Text,textBox7);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            
            

            {
                int periodo1 = Convert.ToInt32(textBox11.Text);
                int periodo2 = Convert.ToInt32(textBox9.Text);
                double valor1 = Convert.ToDouble(textBox3.Text);
                double valor2 = Convert.ToDouble(textBox25.Text);
                double valor3 = Convert.ToDouble(textBox7.Text);
                double valor4 = Convert.ToDouble(textBox24.Text);
                double valor5 = Convert.ToDouble(textBox29.Text);

                if (periodo1 != periodo2)
                {
                 
                    if (textBox25.Text == "" | textBox3.Text == "" | textBox7.Text == "")
                    {


                        MessageBox.Show("Debe de llenar el abono y el saldo pendiente.", "ADVERTENCIA!");

                    }

                    else if (valor1 < valor2 & textBox28.Text == "NORMAL"  )
                    {
                        MessageBox.Show("El abono es mayor al saldo pendiente.", "ADVERTENCIA!");
                    }

                  /*  else if (valor4 < valor2 & textBox28.Text == "NORMAL")
                             {
                        MessageBox.Show("El abono es mayor al saldo pendiente.", "ADVERTENCIA!");
                            }*/

                    else if (valor3 < valor2 & textBox28.Text == "ESPECIAL")
                    {
                        MessageBox.Show("El abono es mayor al saldo pendiente.", "ADVERTENCIA!");
                    }
                  /*  else if (valor4 < valor2 & textBox28.Text == "ESPECIAL")
                    {
                        MessageBox.Show("El abono es mayor al saldo pendiente.", "ADVERTENCIA!");
                    }*/


                    else if (textBox28.Text == "NORMAL" & periodo1 != periodo2)
                    {
                        double total = valor1 - valor2;


                        textMonto.Text = total.ToString();
                       iconPictureBox2.Enabled = true;

                    }
                    else if (textBox28.Text == "ESPECIAL" & periodo1 != periodo2)
                    {

                        double total = valor3 - valor2;


                        textMonto.Text = total.ToString();
                       iconPictureBox2.Enabled = true;

                    }
                }

                else if (periodo1 == periodo2 & textBox28.Text == "NORMAL")
                {
                    double total = valor4 - valor2;


                    textMonto.Text = total.ToString();
                   iconPictureBox2.Enabled = true;

                }
                else if (periodo1 == periodo2  & textBox28.Text == "ESPECIAL")
                {

                    double total = (valor3 + valor5) - valor2;


                    textMonto.Text = total.ToString();
                   iconPictureBox2.Enabled = true;

                }

            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has introduccido datos incorrectos.", "ADVERTENCIA!");
            }

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {


             try
                {
             
   

            double strMonto = Convert.ToDouble(this.textMonto.Text);
           


            if (textBox1.Text == "" | textBox2.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textMonto.Text == "" | textTasa.Text == "" | textTiempo.Text == "" | textBox27.Text == "" | textBox26.Text == "" | textBox6.Text == "" |  textBox8.Text == "" | textBox28.Text == "" | textBox20.Text == "")
            {
          

                MessageBox.Show("Debe llenar todos los campos correctamente.", "AVISO");
            
    
            }
            else if (strMonto < 0)
                {

                    MessageBox.Show("Debe de llenar el abono y el saldo pendiente.", "ADVERTENCIA!"); 
                }
            
            else
            {
                c.eliminarcliente(textBox1.Text,comboBox2.Text);
                c.selectnumeroentrada(textBox20);
                   double elbachatu = Convert.ToDouble(textBox20.Text);
                        elbachatu++;
                        textBox20.Text = elbachatu.ToString();
                      
                
               iconPictureBox2.Enabled = false;
               
               
                    string op = textBox27.Text;
                  
                    Int32 MESES = Convert.ToInt32(this.textTiempo.Text);
                    double Interemensual = Convert.ToDouble(this.textTasa.Text);

                    Interemensual = Interemensual / 100;


                    double Resultado = strMonto * Interemensual;



                    this.lblinteres_mensual.Text = Interemensual.ToString();

             
                    int INTERES = 0;
                    //int TINTERES = 0;
                    double CAPITAL = 0;
                    //double TAMORTIZADO = 0;
                    double TCUOTA = 0;
                    double SALDOINICIAL = strMonto;
                    double ACUMULADO = 0;
                    double SALDOFINAL = 0;
                    string Estado = "Pendiente";
                    double mora = 0.00;

                    textBox10.Text = "Abono realizado por: "+textBox2.Text+ " al prestamo No: "+comboBox2.Text;
                    
                       
                    for (int I = 1; I < MESES + 1; I = I + 1)
                    {
                        double CUOTA = Convert.ToDouble(strMonto / MESES);
                        this.textCuota.Text = SALDOFINAL.ToString();
                        //TINTERES += INTERES; // ACUMULA LOS INTERES
                        SALDOINICIAL += Convert.ToInt32(CAPITAL);// LE RESTA EL CAPITAL 

                        CAPITAL = Convert.ToDouble((INTERES - CUOTA));//DIFERENCIA LA CUOTA DE LOS INTERES DEL MES
                        //TAMORTIZADO += CAPITAL; //ACUMULA TODA LA CUOTA
                        SALDOFINAL = Convert.ToDouble(CUOTA + Resultado);

                        //TCUOTA += CUOTA;
                        DateTime FFecha;
                        FFecha = Convert.ToDateTime(this.time.Value.ToString());
                        //time.Text = FECHA.ToString("mm/dd/yyyy");
                        FECHA = DateTime.Parse(FFecha.ToString());
                        FECHA.AddMonths(I - 1).ToShortDateString();//'(I-1) PARA QUE EMPIECE A CONTAR EN EL MISMO M
                        double promesa = 0;
                        
                        
                        dtgDesglose.Visible = true;
                        c.selectnumeroentrada(textBox20);
                        double elbachatu1 = Convert.ToDouble(textBox20.Text);
                        elbachatu1++;
                        textBox20.Text = elbachatu1.ToString();
                        switch (op)
                        {


                            case "MENSUAL":
                               
                                this.textCuota.Text = SALDOFINAL.ToString();

                                dtgDesglose.Rows.Add(textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, I.ToString(), FECHA.AddMonths(I + 0).ToString("yyyy/MM/dd"), SALDOINICIAL, CUOTA, Resultado, Estado.ToString(), textBox27.Text, SALDOFINAL, FECHA.AddMonths(I - 999).ToString("yyyy/MM/dd"), comboBox2.Text, mora, textBox26.Text, textBox6.Text, textBox28.Text, Interemensual);
                                
                                break;
                            case "QUINCENAL":
                             
                               /* foreach (DataGridViewRow row in dtgDesglose.Rows)
                                {

                                    total2020 += Convert.ToDouble(row.Cells["FechaPago"].Value);
                                   // FECHA.ToString("yyyy/MM/15");

                                }*/
                               // FECHA.AddDays(I *15).ToShortDateString();
                              
                                   
                                    this.textCuota.Text = SALDOFINAL.ToString();
                                    //FECHA = FECHA.ToString("yyyy/MM/15");
                                    dtgDesglose.Rows.Add(textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, I.ToString(), FECHA.AddDays(I * 15).ToString("yyyy/MM/dd"), SALDOINICIAL, CUOTA, Resultado, Estado.ToString(), textBox27.Text, SALDOFINAL, FECHA.AddMonths(I - 999).ToString("yyyy/MM/dd"), comboBox2.Text, mora, textBox26.Text, textBox6.Text, textBox28.Text, textBox20.Text, Interemensual);
                              
                                    //double total2021 = 0;
                                 
                                
                               break;


                            case "":
                           
                               
                                break;



                        }
                    }

                    if (textBox1.Text == "" | textBox2.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textMonto.Text == "" | textTasa.Text == "" | textTiempo.Text == "" | textBox27.Text == "" | textBox26.Text == "" | textBox6.Text == ""  | textBox8.Text == "" |  textBox28.Text == "" | textCuota.Text == "" | textBox28.Text == "" | lblinteres_mensual.Text == "" )
                    {
                       

                        MessageBox.Show("Debe llenar todos los campos correctamente.", "AVISO");
                        // Button2.Enabled = false;

                    }
                    else
                    {
                        
                      
            
                        c.insertar(dtgDesglose,textBox20.Text);
                        // c.UPDATeemonto(textBox9.Text,textBox26.Text);
                        //c.insertarcuenta1(textBox26.Text, textBox6.Text, textBox7.Text, textMonto.Text, textBox11.Text, textBox10.Text, textBox8.Text);
                        /*Para la cuenta de banco*/
                        c.insertarentradaCREDITO(textBox20.Text, textBox23.Text, textBox10.Text, textBox6.Text, textBox26.Text, textBox25.Text,textBox21.Text , textBox12.Text, textBox13.Text, textBox14.Text);
                        /*Para para el credito cuenta por cobrar*/
                        c.insertarentradaCREDITO(textBox20.Text, textBox23.Text, textBox10.Text, textBox16.Text, textBox22.Text, textBox21.Text, textBox25.Text, textBox17.Text, textBox18.Text, textBox19.Text);
                        MessageBox.Show("Se ha insertado correctamente.", "Mensaje!");
                        Recibo FREPORTE = new Recibo();
                        FREPORTE.textBox1.Text = textBox1.Text;
                        FREPORTE.textBox2.Text = comboBox2.Text;
                        FREPORTE.Show();
                        dtgDesglose.Rows.Clear();
                        textBox1.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox2.Text = "";
                        textBox25.Text = "";
                        textBox26.Text = "";
                        textBox27.Text = "";
                        textBox28.Text = "";
                        textMonto.Text = "";
                        textTasa.Text = "";
                        textTiempo.Text = "";
                        lblinteres_mensual.Text = "";
                        textCuota.Text = "";
                        textBox12.Text = "";
                        textBox13.Text = "";
                        textBox14.Text = "";
                        textBox15.Text = "";
                        textBox10.Text = "";
                       
                     



                    }



            }
            }
               catch (Exception ex)
                {
                    MessageBox.Show("Has introduccido datos incorrectos.", "ADVERTENCIA!");
                }

            
           
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textMonto.Text = "";
            textTasa.Text = "";
            textTiempo.Text = "";
            lblinteres_mensual.Text = "";
            textCuota.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox10.Text = "";
            dtgDesglose.Rows.Clear();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            try



            {
                c.selectcatalogoentrada12(textBox26.Text,textBox12,textBox13,textBox14);
                int periodo1 = Convert.ToInt32(textBox11.Text);
                int periodo2 = Convert.ToInt32(textBox9.Text);
                double valor1 = Convert.ToDouble(textBox3.Text);
                double valor2 = Convert.ToDouble(textBox25.Text);
                double valor3 = Convert.ToDouble(textBox7.Text);
                double valor4 = Convert.ToDouble(textBox24.Text);
                double valor5 = Convert.ToDouble(textBox29.Text);

                if (periodo1 != periodo2)
                {

                    if (textBox25.Text == "" | textBox3.Text == "" | textBox7.Text == "")
                    {


                        MessageBox.Show("Debe de llenar el abono y el saldo pendiente.", "ADVERTENCIA!");

                    }

                    else if (valor1 < valor2 & textBox28.Text == "NORMAL")
                    {
                        MessageBox.Show("El abono es mayor al saldo pendiente.", "ADVERTENCIA!");
                    }

                    /*  else if (valor4 < valor2 & textBox28.Text == "NORMAL")
                               {
                          MessageBox.Show("El abono es mayor al saldo pendiente.", "ADVERTENCIA!");
                              }*/

                    else if (valor3 < valor2 & textBox28.Text == "ESPECIAL")
                    {
                        MessageBox.Show("El abono es mayor al saldo pendiente.", "ADVERTENCIA!");
                    }
                    /*  else if (valor4 < valor2 & textBox28.Text == "ESPECIAL")
                      {
                          MessageBox.Show("El abono es mayor al saldo pendiente.", "ADVERTENCIA!");
                      }*/


                    else if (textBox28.Text == "NORMAL" & periodo1 != periodo2)
                    {
                        double total = valor1 - valor2;


                        textMonto.Text = total.ToString();
                       iconPictureBox2.Enabled = true;

                    }
                    else if (textBox28.Text == "ESPECIAL" & periodo1 != periodo2)
                    {

                        double total = valor3 - valor2;


                        textMonto.Text = total.ToString();
                       iconPictureBox2.Enabled = true;

                    }
                }

                else if (periodo1 == periodo2 & textBox28.Text == "NORMAL")
                {
                    double total = valor4 - valor2;


                    textMonto.Text = total.ToString();
                   iconPictureBox2.Enabled = true;

                }
                else if (periodo1 == periodo2 & textBox28.Text == "ESPECIAL")
                {

                    double total = (valor3 + valor5) - valor2;


                    textMonto.Text = total.ToString();
                   iconPictureBox2.Enabled = true;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Has introduccido datos incorrectos.", "ADVERTENCIA!");
            }
        }

        
        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textMonto.Text = "";
            textTasa.Text = "";
            textTiempo.Text = "";
            lblinteres_mensual.Text = "";
            textCuota.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox10.Text = "";
            dtgDesglose.Rows.Clear();
        }
    }
    }


