using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Controls;

namespace PRESTAMOS2
{
    public partial class CrearCredito : Form
    {

        DateTime FECHA = new DateTime();
        conexion c = new conexion();


        public CrearCredito()
        {
            /*  DatePicker time = new DatePicker();
           try
           {
               time.DisplayDateStart = new DateTime(2020, 1, 1);
               time.DisplayDateEnd = new DateTime(2020, 12, 31);
               time.SelectedDate = new DateTime(2020, 1, 12);

               time.BlackoutDates.Add(
                   new CalendarDateRange(new DateTime(2020, 1, 1), new DateTime(2020, 1, 12)));
           }
           catch (Exception e){ }
         //time.strar*/
            InitializeComponent();
            textBox23.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void CrearCredito_Load(object sender, EventArgs e)
        {


        }


        private void iconPictureBox2_Click_1(object sender, EventArgs e)
        {

            try
            {


                if (textBox1.Text == "" | textBox2.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textMonto.Text == "" | textTasa.Text == "" | textTiempo.Text == "" | comboBox1.Text == "" | comboBox3.Text == "" | textBox6.Text == "" | textBox7.Text == "" | textBox8.Text == "" | textBox9.Text == "" | comboBox4.Text == "" | textCuota.Text == "" | comboBox4.Text == "" | lblinteres_mensual.Text == "" | textBox24.Text == "" | textBox24.Text == "")
                {


                    MessageBox.Show("Debe llenar todos los campos correctamente.", "AVISO");
                    //iconPictureBox1.Enabled = false;

                }
                else
                {


                    c.selectnumeroentrada(textBox20);
                    double elbachatu = Convert.ToDouble(textBox20.Text);
                    elbachatu++;
                    textBox20.Text = elbachatu.ToString();
                    c.insertar(dtgDesglose, textBox20.Text);
                    // c.UPDATeemonto(textBox9.Text,comboBox3.Text);
                    c.insertarcuenta1(comboBox3.Text, textBox6.Text, textBox7.Text, textMonto.Text, textBox11.Text, textBox10.Text, textBox8.Text);
                    /*Para la cuenta de banco*/
                    c.insertarentradaCREDITO(textBox20.Text, textBox23.Text, textBox10.Text, textBox6.Text, comboBox3.Text, textBox21.Text, textMonto.Text, textBox13.Text, textBox14.Text, textBox15.Text);
                    /*Para para el credito cuenta por cobrar*/
                    c.insertarentradaCREDITO(textBox20.Text, textBox23.Text, textBox10.Text, textBox16.Text, textBox22.Text, textMonto.Text, textBox21.Text, textBox17.Text, textBox18.Text, textBox19.Text);
                    Recibo FREPORTE = new Recibo();
                    FREPORTE.textBox1.Text = textBox1.Text;
                    FREPORTE.textBox2.Text = textBox3.Text;
                    FREPORTE.Show();
                    dtgDesglose.Rows.Clear();
                    textMonto.Text = "";
                    textTasa.Text = "";
                    textTiempo.Text = "";
                    lblinteres_mensual.Text = "";
                    textCuota.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox3.Text = "1";
                    textBox12.Text = "";
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox10.Text = "";
                   iconPictureBox1.Enabled = true;
                   iconPictureBox2.Enabled = false;


                }



            }

            catch (Exception ex)
            {
                MessageBox.Show("Has introduccido datos incorrectos.", "ADVERTENCIA!");
            }



        }
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = Convert.ToString(textBox1.Text);
                double debito = Convert.ToDouble(textBox24.Text);
                double BALANCECUENTA = Convert.ToDouble(textBox7.Text);
                double strMonto = Convert.ToDouble(this.textMonto.Text);
                double totalcuenta = 0;
                double total2020 = 0;
                total2020 = BALANCECUENTA - debito;

                textBox9.Text = total2020.ToString();


                if (textBox1.Text == ""| textBox2.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textMonto.Text == "" | textTasa.Text == "" | textTiempo.Text == "" | comboBox1.Text == "" | comboBox3.Text == "" | textBox6.Text == "" | textBox7.Text == "" | textBox8.Text == "" | comboBox4.Text == "" | textBox20.Text == "")
                {


                    MessageBox.Show("Debe llenar todos los campos correctamente.", "AVISO");


                }
                else if (cedula.Length < 13) {
                    MessageBox.Show("Cedula incorrecta.", "AVISO");
                }
                else if (strMonto > total2020)
                {



                    MessageBox.Show("Esta cuenta no tiene esta cantidad disponible.", "ADVERTENCIA!");

                }


                else
                {

                    iconPictureBox2.Enabled = true;
                    iconPictureBox1.Enabled = false;


                    string op = comboBox1.Text;

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

                    textBox10.Text = "Prestamo realizado a: " + textBox2.Text;


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

                                dtgDesglose.Rows.Add(textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, I.ToString(), FECHA.AddMonths(I + 0).ToString("yyyy/MM/dd"), SALDOINICIAL, CUOTA, Resultado, Estado.ToString(), comboBox1.Text, SALDOFINAL, FECHA.AddMonths(I - 999).ToString("yyyy/MM/dd"), textBox3.Text, mora, comboBox3.Text, textBox6.Text, comboBox4.Text, Interemensual);
                                comboBox1.BackColor = Color.White;
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
                                dtgDesglose.Rows.Add(textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, I.ToString(), FECHA.AddDays(I * 15).ToString("yyyy/MM/dd"), SALDOINICIAL, CUOTA, Resultado, Estado.ToString(), comboBox1.Text, SALDOFINAL, FECHA.AddMonths(I - 999).ToString("yyyy/MM/dd"), textBox3.Text, mora, comboBox3.Text, textBox6.Text, comboBox4.Text, Interemensual);
                                comboBox1.BackColor = Color.White;
                                //double total2021 = 0;











                                break;


                            case "":

                                comboBox1.BackColor = Color.Red;
                                break;



                        }
                    }

                }
            }





            catch (Exception ex)
            {
                MessageBox.Show("Has introduccido datos incorrectos.", "ADVERTENCIA!");
            }


        }



        private void button3_Click(object sender, EventArgs e)
        {


            dtgDesglose.Rows.Clear();
            // dataGridView1.Rows.Clear();

            dtgDesglose.Visible = true;

           iconPictureBox1.Enabled = true;
            textBox3.Enabled = false;
            textMonto.Text = "";
            textTasa.Text = "";
            textTiempo.Text = "";
            lblinteres_mensual.Text = "";
            textCuota.Text = "";
            textBox2.Text = "";
            textBox3.Text = "1";
            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox10.Text = "";
            textBox24.Text = "0.00";
            textBox7.Text = "0.00";
            textBox9.Text = "0.00";
            textBox3.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgDesglose_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {


                MessageBox.Show("Verifique los datos", "Advertencia");

            }
            else
            {
                c.selectnumeroentrada(textBox20);
                Recibo FREPORTE = new Recibo();
                FREPORTE.textBox1.Text = textBox1.Text;
                FREPORTE.textBox2.Text = textBox3.Text;
                FREPORTE.Show();
            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Inicio FINICIO = new Inicio();
            FINICIO.txttipo.Text = txttipocredito.Text;
            FINICIO.Show();
            Hide();

        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Quiere salir de sistema?", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cALCULADORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora FCALCULADORA = new Calculadora();
            FCALCULADORA.calculadortext.Text = txttipocredito.Text;
            FCALCULADORA.Show();
            Hide();
        }

        private void CrearCredito_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void CrearCredito_Load_1(object sender, EventArgs e)
        {
            //c.selectcatalogoentrada123(textBox22, textBox16, textBox17, textBox18, textBox19);
            c.selectnumeroentrada(textBox20);
           iconPictureBox2.Enabled = false;
            double nocuenta = Convert.ToDouble(textBox20.Text);
            nocuenta++;
            textBox20.Text = nocuenta.ToString();

            textBox8.Text = DateTime.Now.ToString("yyyy/MM/dd");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;

            c.llenaritems(comboBox3);
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox10.Text = "";
            textBox3.Text = "1";
            textMonto.Text = "";
            textTasa.Text = "";
            textTiempo.Text = "";
            lblinteres_mensual.Text = "";
            textCuota.Text = "";
            textBox2.Text = "";
            textBox3.Text = "1";
            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox24.Text = "0.00";
            textBox7.Text = "0.00";
            textBox9.Text = "0.00";

        }

        private void time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Recibo FREPORTE = new Recibo();
            FREPORTE.textBox1.Text = textBox1.Text;
            FREPORTE.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {




        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.selectbanco(comboBox3.Text, textBox6, textBox7);
            c.selectcatalogoentrada12(comboBox3.Text, textBox13, textBox14, textBox15);
            c.solucion(comboBox3.Text, textBox7, textBox24);
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CrearCredito_FormClosed_1(object sender, FormClosedEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox3.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos correctamente.", "Mesanje");

            }
            else
            {


                c.selectwow(textBox3.Text, textBox1.Text, textBox2, textBox4, textBox5);



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textMonto.Text == "" | textTasa.Text == "" | textTiempo.Text == "" | comboBox1.Text == "" | comboBox3.Text == "" | textBox6.Text == "" | textBox7.Text == "" | textBox8.Text == "" | comboBox4.Text == "" | textCuota.Text == "" | comboBox4.Text == "" | lblinteres_mensual.Text == "")
            {


                MessageBox.Show("Debe llenar todos los campos correctamente.", "AVISO");
                //iconPictureBox1.Enabled = false;

            }
            else
            {

                c.eliminarcliente1(textBox1.Text, textBox2, textBox3.Text);
                // c.eliminarentrada(textBox20.Text);
                c.insertar(dtgDesglose, textBox20.Text);
                c.insertarentradaCREDITO(textBox20.Text, textBox23.Text, textBox10.Text, textBox12.Text, comboBox3.Text, textBox21.Text, textMonto.Text, textBox13.Text, textBox14.Text, textBox15.Text);
                /*Para para el credito cuenta por cobrar*/
                c.insertarentradaCREDITO2(textBox20.Text, textBox23.Text, textBox10.Text, textBox16.Text, textBox22.Text, textMonto.Text, textBox21.Text, textBox17.Text, textBox18.Text, textBox19.Text);
                // c.UPDATeemonto(textBox9.Text, comboBox3.Text);
                c.insertarcuenta1(comboBox3.Text, textBox6.Text, textBox7.Text, textMonto.Text, textBox11.Text, textBox10.Text, textBox8.Text);
                Recibo FREPORTE = new Recibo();
                FREPORTE.textBox1.Text = textBox1.Text;
                FREPORTE.textBox2.Text = textBox3.Text;
                FREPORTE.Show();
                dtgDesglose.Rows.Clear();
                textMonto.Text = "";
                textTasa.Text = "";
                textTiempo.Text = "";
                lblinteres_mensual.Text = "";
                textCuota.Text = "";
                double elbachatu = Convert.ToDouble(textBox20.Text);
                elbachatu++;
                textBox20.Text = elbachatu.ToString();



                textBox3.Enabled = false;

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //try
            //{
            //    if (textBox3.Text == "0")
            //    {
            //        textBox3.Text = "1";

            //    }
            //    else
            //    {
            textBox3.Text = "1";
            c.selectreenganche(textBox1.Text, textBox3);

            //double noreenganche = Convert.ToDouble(textBox3.Text);
            //noreenganche++;
            //        textBox3.Text = noreenganche.ToString();
            //    }
            //}
            //catch(Exception ex){
            //}

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CrearCredito_Click(object sender, EventArgs e)
        {
            c.selectnumeroentrada(textBox20);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click_1(object sender, EventArgs e)
        {
           

    }

        private void IconPictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                double debito = Convert.ToDouble(textBox24.Text);
                double BALANCECUENTA = Convert.ToDouble(textBox7.Text);
                double strMonto = Convert.ToDouble(this.textMonto.Text);
                double totalcuenta = 0;
                double total2020 = 0;
                total2020 = BALANCECUENTA - debito;

                textBox9.Text = total2020.ToString();


                if (textBox1.Text == "" | textBox2.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textMonto.Text == "" | textTasa.Text == "" | textTiempo.Text == "" | comboBox1.Text == "" | comboBox3.Text == "" | textBox6.Text == "" | textBox7.Text == "" | textBox8.Text == "" | comboBox4.Text == "" | textBox20.Text == "")
                {


                    MessageBox.Show("Debe llenar todos los campos correctamente.", "AVISO");


                }
                else if (strMonto > total2020)
                {



                    MessageBox.Show("Esta cuenta no tiene esta cantidad disponible.", "ADVERTENCIA!");

                }


                else
                {

                   iconPictureBox2.Enabled = true;
                   iconPictureBox1.Enabled = false;


                    string op = comboBox1.Text;

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

                    textBox10.Text = "Prestamo realizado a: " + textBox2.Text;


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

                                dtgDesglose.Rows.Add(textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, I.ToString(), FECHA.AddMonths(I + 0).ToString("yyyy/MM/dd"), SALDOINICIAL, CUOTA, Resultado, Estado.ToString(), comboBox1.Text, SALDOFINAL, FECHA.AddMonths(I - 999).ToString("yyyy/MM/dd"), textBox3.Text, mora, comboBox3.Text, textBox6.Text, comboBox4.Text, Interemensual);
                                comboBox1.BackColor = Color.White;
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
                                dtgDesglose.Rows.Add(textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, I.ToString(), FECHA.AddDays(I * 15).ToString("yyyy/MM/dd"), SALDOINICIAL, CUOTA, Resultado, Estado.ToString(), comboBox1.Text, SALDOFINAL, FECHA.AddMonths(I - 999).ToString("yyyy/MM/dd"), textBox3.Text, mora, comboBox3.Text, textBox6.Text, comboBox4.Text, Interemensual);
                                comboBox1.BackColor = Color.White;
                                //double total2021 = 0;











                                break;


                            case "":

                                comboBox1.BackColor = Color.Red;
                                break;



                        }
                    }

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


                if (textBox1.Text == "" | textBox2.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textMonto.Text == "" | textTasa.Text == "" | textTiempo.Text == "" | comboBox1.Text == "" | comboBox3.Text == "" | textBox6.Text == "" | textBox7.Text == "" | textBox8.Text == "" | textBox9.Text == "" | comboBox4.Text == "" | textCuota.Text == "" | comboBox4.Text == "" | lblinteres_mensual.Text == "" | textBox24.Text == "" | textBox24.Text == "")
                {


                    MessageBox.Show("Debe llenar todos los campos correctamente.", "AVISO");
                    //iconPictureBox1.Enabled = false;

                }
                else
                {


                    c.selectnumeroentrada(textBox20);
                    double elbachatu = Convert.ToDouble(textBox20.Text);
                    elbachatu++;
                    textBox20.Text = elbachatu.ToString();
                    c.insertar(dtgDesglose, textBox20.Text);
                    // c.UPDATeemonto(textBox9.Text,comboBox3.Text);
                    c.insertarcuenta1(comboBox3.Text, textBox6.Text, textBox7.Text, textMonto.Text, textBox11.Text, textBox10.Text, textBox8.Text);
                    /*Para la cuenta de banco*/
                    c.insertarentradaCREDITO(textBox20.Text, textBox23.Text, textBox10.Text, textBox6.Text, comboBox3.Text, textBox21.Text, textMonto.Text, textBox13.Text, textBox14.Text, textBox15.Text);
                    /*Para para el credito cuenta por cobrar*/
                    c.insertarentradaCREDITO(textBox20.Text, textBox23.Text, textBox10.Text, textBox16.Text, textBox22.Text, textMonto.Text, textBox21.Text, textBox17.Text, textBox18.Text, textBox19.Text);
                    Recibo FREPORTE = new Recibo();
                    FREPORTE.textBox1.Text = textBox1.Text;
                    FREPORTE.textBox2.Text = textBox3.Text;
                    FREPORTE.Show();
                    dtgDesglose.Rows.Clear();
                    textMonto.Text = "";
                    textTasa.Text = "";
                    textTiempo.Text = "";
                    lblinteres_mensual.Text = "";
                    textCuota.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox3.Text = "1";
                    textBox12.Text = "";
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox10.Text = "";
                    iconPictureBox1.Enabled = true;
                   iconPictureBox2.Enabled = false;


                }



            }

            catch (Exception ex)
            {
                MessageBox.Show("Has introduccido datos incorrectos.", "ADVERTENCIA!");
            }

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

            dtgDesglose.Rows.Clear();
            // dataGridView1.Rows.Clear();

            dtgDesglose.Visible = true;

            iconPictureBox1.Enabled = true;
            textBox3.Enabled = false;
            textMonto.Text = "";
            textTasa.Text = "";
            textTiempo.Text = "";
            lblinteres_mensual.Text = "";
            textCuota.Text = "";
            textBox2.Text = "";
            textBox3.Text = "1";
            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox10.Text = "";
            textBox24.Text = "0.00";
            textBox7.Text = "0.00";
            textBox9.Text = "0.00";
            textBox3.Enabled = false;
        }
    }

}
    

   
    

