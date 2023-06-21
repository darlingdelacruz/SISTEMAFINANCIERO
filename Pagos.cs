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
    public partial class Pagos : Form
    {

        conexion c = new conexion();
        public Pagos()
        {
            InitializeComponent();
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            iconPictureBox1.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox4.Text = DateTime.Now.ToString("yyyy/MM/dd");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            panel5.Enabled = false;
            c.selectnumeroentrada(textBox20);
            double nocuenta = Convert.ToDouble(textBox20.Text);
            nocuenta++;
            textBox20.Text = nocuenta.ToString();
            textBox2.Text = "";
           


            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox14.Text = "";


            if (txttipopago.Text == "ADMINISTRADOR")
            {
                // button1.Enabled = true;

                iconPictureBox5.Enabled = true;
            }
            else if (textBox14.Text == "ESPECIAL")
            {

                panel5.Enabled = true;

            }
            else
            {
                button1.Enabled = false;
                iconPictureBox5.Enabled = false;

            }

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            c.llenarcombo(comboBox1, textBox1.Text);

        }





        private void cREARCREDITOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCredito FCREDITOS = new CrearCredito();
            FCREDITOS.txttipocredito.Text = txttipopago.Text;
            FCREDITOS.Show();
            Hide();
        }

        private void rEPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FREPORTE = new Reporte_General();
            FREPORTE.Show();

        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio FINICIO = new Inicio();
            FINICIO.txttipo.Text = txttipopago.Text;
            FINICIO.Show();
            Hide();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Application.Exit();

        }

        private void cALCULADORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora FCALCULADORA = new Calculadora();
            FCALCULADORA.calculadortext.Text = txttipopago.Text;
            FCALCULADORA.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form FPAGARTODOS = new ACCESOPAGAR();
            FPAGARTODOS.Show();

        }







        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            textBox4.Text = "";
            textBox4.Text = DateTime.Now.ToString("yyyy/MM/dd");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" | textBox5.Text == "")
                {


                    MessageBox.Show("Llene todos los campos.", "Advertencia!");

                }
                else
                {
                    button1.Enabled = true;
                    button3.Enabled = true;
                    c.selectcatalogoentrada12(textBox5.Text, textBox27, textBox28, textBox29);
                    c.buscar(dataGridView1, textBox1.Text, comboBox1.Text);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Llene todos los campos", "ADVERTENCIA.");
            }

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {


            string nombre = textBox2.Text;
            string periodico = comboBox2.Text;
            textBox10.Text = "Pago de la cuota No. " + periodico + " realizado por: " + nombre;

            if (textBox1.Text == "" | textBox2.Text == "" | comboBox2.Text == "" | textBox5.Text == "" | textBox7.Text == "" | comboBox1.Text == "")
            {
                MessageBox.Show("Llene todos los campos.", "ADVERTENCIA");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox2.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                dataGridView1.Rows.Clear();

            }
            else
            {
                c.selectnumeroentrada(textBox20);
                double nocuenta1 = Convert.ToDouble(textBox20.Text);
                nocuenta1++;
                textBox20.Text = nocuenta1.ToString();
                c.PAGO(textBox1.Text, comboBox2.Text, comboBox1.Text);
                c.insertarfecha(textBox4.Text, textBox1.Text, comboBox2.Text, comboBox1.Text);
                c.updatemora(textBox1.Text, comboBox2.Text, textBox6.Text, comboBox1.Text);
                c.insertarentradaCREDITO(textBox20.Text, textBox4.Text, textBox10.Text, textBox23.Text, textBox22.Text, textBox24.Text, textBox11.Text, textBox21.Text, textBox25.Text, textBox19.Text);
                c.insertarentradaCREDITO(textBox20.Text, textBox4.Text, textBox10.Text, textBox7.Text, textBox5.Text, textBox11.Text, textBox24.Text, textBox27.Text, textBox28.Text, textBox29.Text);
               // c.insertarcuenta1(textBox5.Text, textBox7.Text, textBox9.Text, textBox13.Text, textBox11.Text, textBox10.Text, textBox4.Text);
                //c.UPDATeemonto(textBox9.Text, textBox5.Text);
                Recibo FREPORTE = new Recibo();
                FREPORTE.textBox1.Text = textBox1.Text;
                FREPORTE.textBox2.Text = comboBox1.Text;
                FREPORTE.Show();
                Pagos PAGU = new Pagos();
                PAGU.textBox1.Text = textBox1.Text;
                PAGU.txttipopago.Text = txttipopago.Text;
                PAGU.textBox4.Text = textBox4.Text;
                PAGU.comboBox1.Text = comboBox1.Text;
                //dataGridView1.Rows.Clear();
                PAGU.Show();
                Hide();
                MessageBox.Show("PAGO REALIZADO.", "Mensaje");
                c.selectnumeroentrada(textBox20);
                double nocuentaP = Convert.ToDouble(textBox20.Text);
                nocuentaP++;
                textBox20.Text = nocuentaP.ToString();
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox2.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox6.Text = "";
                textBox18.Text = "";
                textBox26.Text = "";
                textBox27.Text = "";
                textBox28.Text = "";
                textBox29.Text = "";
                comboBox1.Text = "";

            }




        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            c.selectnumeroentrada(textBox20);
            double nocuenta = Convert.ToDouble(textBox20.Text);
            nocuenta++;
            textBox20.Text = nocuenta.ToString();
            Recibo FREPORTE = new Recibo();
            FREPORTE.textBox1.Text = textBox1.Text;
            FREPORTE.textBox2.Text = comboBox1.Text;

            FREPORTE.Show();
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            c.selectnumeroentrada(textBox20);
            double nocuenta = Convert.ToDouble(textBox20.Text);
            nocuenta++;
            textBox20.Text = nocuenta.ToString();
            Form FPAGARTODOS = new ACCESOPAGAR();
            FPAGARTODOS.Show();
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox6.Text = "";
            textBox18.Text = "";
            comboBox1.Text = "";


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // dataGridView1.Rows.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox6.Text = "";
            textBox18.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";

            comboBox1.Text = "";




        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {


            string nombre = textBox2.Text;
            textBox10.Text = "Pago exento de mora realizado por: " + nombre;
            if (textBox1.Text == "" | textBox2.Text == "" | comboBox2.Text == "" | textBox4.Text == "" | comboBox1.Text == "" | textBox6.Text == "")
            {
                MessageBox.Show("Llene todos los campos.", "ADVERTENCIA");



            }
            else
            {
                c.selectnumeroentrada(textBox20);
                double nocuenta12 = Convert.ToDouble(textBox20.Text);
                nocuenta12++;
                textBox20.Text = nocuenta12.ToString();
                double monto1 = Convert.ToDouble(textBox8.Text);
                double monto2 = Convert.ToDouble(textBox11.Text);
                double monto3 = Convert.ToDouble(textBox6.Text);
                double total = 0;
                monto2 = monto2 - monto3;
                total = (monto1 + monto2);
                textBox12.Text = monto2.ToString();
                textBox11.Text = textBox12.Text;
                textBox9.Text = total.ToString();
                c.PAGO(textBox1.Text, comboBox2.Text, comboBox1.Text);
                c.insertarfecha(textBox4.Text, textBox1.Text, comboBox2.Text, comboBox1.Text);
                c.eliminarmora(textBox1.Text, comboBox2.Text, textBox6.Text, comboBox1.Text);
                c.insertarentradaCREDITO(textBox20.Text, textBox4.Text, textBox10.Text, textBox23.Text, textBox22.Text, textBox24.Text, textBox11.Text, textBox21.Text, textBox25.Text, textBox19.Text);
                c.insertarentradaCREDITO(textBox20.Text, textBox4.Text, textBox10.Text, textBox7.Text, textBox5.Text, textBox11.Text, textBox24.Text, textBox27.Text, textBox28.Text, textBox29.Text);
                // c.updatemora(textBox1.Text, comboBox2.Text, textBox6.Text, comboBox1.Text);
                Pagos PAGU = new Pagos();
                PAGU.textBox1.Text = textBox1.Text;
                PAGU.txttipopago.Text = txttipopago.Text;
                PAGU.textBox4.Text = textBox4.Text;
                PAGU.comboBox1.Text = comboBox1.Text;
                PAGU.Show();
                Hide();
                MessageBox.Show("PAGO REALIZADO.", "ADVERTENCIA");
              //  c.insertarcuenta1(textBox5.Text, textBox7.Text, textBox9.Text, textBox13.Text, textBox11.Text, textBox10.Text, textBox4.Text);
                textBox26.Text = "";
                textBox27.Text = "";
                textBox28.Text = "";
                textBox29.Text = "";
                comboBox1.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox2.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox6.Text = "";
                textBox18.Text = "";
                textBox26.Text = "";
                textBox27.Text = "";
                textBox28.Text = "";
                textBox29.Text = "";

                comboBox1.Text = "";
                // c.UPDATeemonto(textBox9.Text, textBox5.Text);

            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                //comboBox2.Items.Clear();
                c.traerPeriodo(textBox1.Text, comboBox1.Text, comboBox2);
                c.MUJERINFIEL(textBox1.Text, comboBox1.Text, textBox15, textBox17);
                
                double monto1aa = Convert.ToDouble(comboBox2.Text);
                double monto2aa = Convert.ToDouble(textBox15.Text);
                c.selectbanco(textBox5.Text, textBox7, textBox8);


                if (monto1aa == monto2aa && textBox14.Text == "ESPECIAL")
                {
                    button3.Enabled = true;
                    iconPictureBox1.Enabled = false;
                    panel5.Enabled = true;
                    panel4.Enabled = false;

                    c.MUJERINFIEL(textBox1.Text, comboBox1.Text, textBox15, textBox16);
                    c.hombreINFIEL(textBox1.Text, comboBox1.Text, textBox18);
                    textBox11.Text = textBox16.Text;
                    double monto1a = Convert.ToDouble(textBox6.Text);
                    double monto2a = Convert.ToDouble(textBox18.Text);
                    double monto3 = Convert.ToDouble(textBox16.Text);
                    double totala = 0;
                    totala = (monto1a + monto2a + monto3);
                    textBox11.Text = totala.ToString();

                }

                else if (textBox14.Text == "ESPECIAL")
                {
                    c.MUJERINFIEL(textBox1.Text, comboBox1.Text, textBox15, textBox16);
                    button3.Enabled = true;
                    iconPictureBox1.Enabled = false;
                    panel5.Enabled = true;
                    panel4.Enabled = false;
                    textBox11.Text = textBox16.Text;

                    double monto1a = Convert.ToDouble(textBox6.Text);
                    double monto2a = Convert.ToDouble(textBox11.Text);
                    double totala = 0;
                    totala = (monto1a + monto2a);
                    textBox11.Text = totala.ToString();



                }





                else
                {
                    c.MUJERINFIEL(textBox1.Text, comboBox1.Text, textBox15, textBox16);

                    button3.Enabled = false;
                    iconPictureBox1.Enabled = true;


                }


             


            }
            catch (Exception ex)
            {


               


            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //c.eliminarmora(textBox1.Text, comboBox2.Text, textBox6.Text, comboBox1.Text);
            try
            {


                double montologico = Convert.ToDouble(textBox15.Text);
                double montologico2 = Convert.ToDouble(comboBox2.Text);
                if (textBox1.Text == "" | textBox2.Text == "" | comboBox2.Text == "" | textBox5.Text == "" | textBox7.Text == "")
                {
                    MessageBox.Show("Llene todos los campos.", "ADVERTENCIA");


                }


                else if (montologico == montologico2 && textBox14.Text == "ESPECIAL")
                {
                    c.selectnumeroentrada(textBox20);
                    double nocuentap = Convert.ToDouble(textBox20.Text);
                    nocuentap++;
                    textBox20.Text = nocuentap.ToString();

                    string nombre = textBox2.Text;
                    string periodico = comboBox2.Text;
                    textBox10.Text = "Pago especial de la cuota final No." + periodico + "  realizado por:" + nombre;


                    c.superlogica(textBox1.Text, comboBox1.Text, comboBox2.Text, textBox11.Text);
                    c.PAGO(textBox1.Text, comboBox2.Text, comboBox1.Text);
                    c.insertarfecha(textBox4.Text, textBox1.Text, comboBox2.Text, comboBox1.Text);
                    c.insertarentradaCREDITO(textBox20.Text, textBox4.Text, textBox10.Text, textBox23.Text, textBox22.Text, textBox24.Text, textBox11.Text, textBox21.Text, textBox25.Text, textBox19.Text);
                    c.insertarentradaCREDITO(textBox20.Text, textBox4.Text, textBox10.Text, textBox7.Text, textBox5.Text, textBox11.Text, textBox24.Text, textBox27.Text, textBox28.Text, textBox29.Text);
                    //c.insertarcuenta1(textBox5.Text, textBox7.Text, textBox9.Text, textBox13.Text, textBox11.Text, textBox10.Text, textBox4.Text);
                    //c.UPDATeemonto(textBox9.Text, textBox5.Text);
                    Pagos PAGU = new Pagos();
                    PAGU.textBox1.Text = textBox1.Text;
                    PAGU.txttipopago.Text = txttipopago.Text;
                    PAGU.textBox4.Text = textBox4.Text;
                    PAGU.comboBox1.Text = comboBox1.Text;
                    PAGU.Show();
                    Hide();
                    MessageBox.Show("PAGO REALIZADO.", "MENSAJE");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox2.Text = "";
                    textBox5.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox6.Text = "";
                    textBox18.Text = "";
                    textBox26.Text = "";
                    textBox27.Text = "";
                    textBox28.Text = "";
                    textBox29.Text = "";

                    comboBox1.Text = "";



                }

                else
                {
                    c.selectnumeroentrada(textBox20);
                    double nocuentas = Convert.ToDouble(textBox20.Text);
                    nocuentas++;
                    textBox20.Text = nocuentas.ToString();

                    c.superlogica(textBox1.Text, comboBox1.Text, comboBox2.Text, textBox11.Text);


                    string nombre = textBox2.Text;
                    string periodico = comboBox2.Text;
                    textBox10.Text = "Pago especial de la cuota No." + periodico + "  realizado por:" + nombre;
                    c.superlogica(textBox1.Text, comboBox1.Text, comboBox2.Text, textBox11.Text);
                    c.PAGO(textBox1.Text, comboBox2.Text, comboBox1.Text);
                    c.insertarfecha(textBox4.Text, textBox1.Text, comboBox2.Text, comboBox1.Text);
                    // c.updatemora(textBox1.Text, comboBox2.Text, textBox6.Text, comboBox1.Text);

                   // c.insertarcuenta1(textBox5.Text, textBox7.Text, textBox9.Text, textBox13.Text, textBox11.Text, textBox10.Text, textBox4.Text);
                    // c.UPDATeemonto(textBox9.Text, textBox5.Text);
                    c.insertarentradaCREDITO(textBox20.Text, textBox4.Text, textBox10.Text, textBox23.Text, textBox22.Text, textBox24.Text, textBox11.Text, textBox21.Text, textBox25.Text, textBox19.Text);
                    c.insertarentradaCREDITO(textBox20.Text, textBox4.Text, textBox10.Text, textBox7.Text, textBox5.Text, textBox11.Text, textBox24.Text, textBox27.Text, textBox28.Text, textBox29.Text);
                    Pagos PAGU = new Pagos();
                    PAGU.textBox1.Text = textBox1.Text;
                    PAGU.txttipopago.Text = txttipopago.Text;
                    PAGU.textBox4.Text = textBox4.Text;
                    PAGU.comboBox1.Text = comboBox1.Text;
                    PAGU.Show();
                    Hide();
                    MessageBox.Show("PAGO REALIZADO.", "MENSAJE");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox2.Text = "";
                    textBox5.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox6.Text = "";
                    textBox18.Text = "";
                    textBox26.Text = "";
                    textBox27.Text = "";
                    textBox28.Text = "";
                    textBox29.Text = "";

                    comboBox1.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Llene todos los campos.", "ADVERTENCIA");


            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {
            Inicio FINICIO = new Inicio();
            FINICIO.txttipo.Text = txttipopago.Text;
            FINICIO.Show();
            Hide();
        }

        private void Pagos_FormClosed(object sender, FormClosedEventArgs e)
        {


            Application.Exit();




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | comboBox1.Text == "" | comboBox2.Text == "")
            {
                MessageBox.Show("Llene todos los campos.", "ADVERTENCIA");


            }
            else
            {
                c.pagarsinafectar(textBox1.Text, comboBox1.Text, comboBox2.Text);
                MessageBox.Show("Se ha pagado sin afectar.", "Mensaje!");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox2.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox6.Text = "";
                textBox18.Text = "";
                textBox26.Text = "";
                textBox27.Text = "";
                textBox28.Text = "";
                textBox29.Text = "";
                comboBox1.Text = "";
            }
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" | textBox5.Text == "")
                {


                    MessageBox.Show("Llene todos los campos.", "Advertencia!");

                }

           

                else
                {
                    iconPictureBox1.Enabled = true;
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    c.selectcatalogoentrada12(textBox5.Text, textBox27, textBox28, textBox29);
                    c.buscar(dataGridView1, textBox1.Text, comboBox1.Text);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Llene todos los campos", "ADVERTENCIA.");
            }
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox6.Text = "";
            textBox18.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";

            comboBox1.Text = "";

        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {

                {

                    MessageBox.Show("Llene todos los campos", "ADVERTENCIA.");
                }
            }
            c.selectnumeroentrada(textBox20);
            double nocuenta = Convert.ToDouble(textBox20.Text);
            nocuenta++;
            textBox20.Text = nocuenta.ToString();
            Recibo FREPORTE = new Recibo();
            FREPORTE.textBox1.Text = textBox1.Text;
            FREPORTE.textBox2.Text = comboBox1.Text;

            FREPORTE.Show();
        }

        private void iconiconPictureBox5_Click(object sender, EventArgs e)
        {
            c.selectnumeroentrada(textBox20);
            double nocuenta = Convert.ToDouble(textBox20.Text);
            nocuenta++;
            textBox20.Text = nocuenta.ToString();
            Form FPAGARTODOS = new ACCESOPAGAR();
            FPAGARTODOS.Show();
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox6.Text = "";
            textBox18.Text = "";
            comboBox1.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string nombre = textBox2.Text;
            textBox10.Text = "Pago de interes realizado por: " + nombre;
            if (textBox1.Text == "" | textBox2.Text == "" | comboBox2.Text == "" | textBox4.Text == "" | comboBox1.Text == "" | textBox6.Text == "")
            {
                MessageBox.Show("Llene todos los campos.", "ADVERTENCIA");



            }

            else if (textBox3.Text == "Interes/P"){
                MessageBox.Show("No se puedo pagar.", "Error");
            }


            else
            {
                c.selectnumeroentrada(textBox20);
                double nocuenta12 = Convert.ToDouble(textBox20.Text);
                nocuenta12++;
                textBox20.Text = nocuenta12.ToString();
                c.PAGOINTERES(textBox1.Text,comboBox2.Text,comboBox1.Text);
                c.insertarfecha(textBox4.Text, textBox1.Text, comboBox2.Text, comboBox1.Text);
               
                c.insertarentradaCREDITO(textBox20.Text, textBox4.Text, textBox10.Text, textBox23.Text, textBox22.Text, textBox16.Text, textBox30.Text, textBox21.Text, textBox25.Text, textBox19.Text);
                c.insertarentradaCREDITO(textBox20.Text, textBox4.Text, textBox10.Text, textBox7.Text, textBox5.Text, textBox30.Text, textBox16.Text, textBox27.Text, textBox28.Text, textBox29.Text);
                Recibo FREPORTE = new Recibo();
                FREPORTE.textBox1.Text = textBox1.Text;
                FREPORTE.textBox2.Text = comboBox1.Text;
                FREPORTE.Show();
                Pagos PAGU = new Pagos();
                PAGU.textBox1.Text = textBox1.Text;
                PAGU.txttipopago.Text = txttipopago.Text;
                PAGU.textBox4.Text = textBox4.Text;
                PAGU.comboBox1.Text = comboBox1.Text;
                PAGU.Show();
                Hide();
                MessageBox.Show("PAGO REALIZADO.", "ADVERTENCIA");
                //c.insertarcuenta1(textBox5.Text, textBox7.Text, textBox9.Text, textBox13.Text, textBox11.Text, textBox10.Text, textBox4.Text);
                textBox26.Text = "";
                textBox27.Text = "";
                textBox28.Text = "";
                textBox29.Text = "";
                comboBox1.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox2.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox6.Text = "";
                textBox18.Text = "";
                textBox26.Text = "";
                textBox27.Text = "";
                textBox28.Text = "";
                textBox29.Text = "";

                comboBox1.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //c.pagoInteres(textBox1.Text, comboBox1.Text, textBox3);


            try {
                c.duplicidad(textBox1.Text, comboBox1.Text, textBox2, comboBox2.Text, textBox6, textBox5, textBox7, textBox13, textBox14, textBox6, textBox30, textBox3);

                double mora = Convert.ToDouble(textBox6.Text);
                double interes = Convert.ToDouble(textBox30.Text);
                double cuota = Convert.ToDouble(textBox13.Text);

              
                double total = 0;

                total = mora + interes + cuota;

                textBox11.Text = total.ToString();
            
            
            }


            catch (Exception ex)
            {

                MessageBox.Show("Llene todos los campos", "ADVERTENCIA.");
            }

        }
    }
}

