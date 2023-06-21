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
    public partial class DEPOSITO : Form
    {
        Solonumero S = new Solonumero();
        conexion c = new conexion();
        public DEPOSITO()
        {
            InitializeComponent();
        }

       

        private void DEPOSITO_Load(object sender, EventArgs e)
        {
            c.llenaritems(comboBox3);
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox4.Text = DateTime.Now.ToString("yyyy/MM/dd");
            c.selectnumeroentrada(textBox1);
            if (textBox1.Text == "")
            {

                textBox1.Text = "0";
            }
            double nocuenta = Convert.ToDouble(textBox1.Text);
            nocuenta++;
            textBox1.Text = nocuenta.ToString();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" | nombre.Text == "" | numero.Text == "" | textBox2.Text == "" | textBox3.Text == "" | comboBox3.Text == "")
            {


                MessageBox.Show("Llene todos los campos.", "Mensaje");

            }
            else
            {
                try
                {
                    double mierda = Convert.ToDouble(textBox6.Text);
                    c.insertarcuenta1(comboBox3.Text, textBox2.Text, textBox7.Text, cero.Text, textBox6.Text, textBox5.Text, textBox4.Text);
                  //  c.UPDATeemonto(textBox7.Text, comboBox3.Text);
                    c.insertarentradaCREDITO(textBox1.Text, textBox4.Text, textBox5.Text, nombre.Text, numero.Text, cero.Text, textBox6.Text, numerop.Text, nombrep.Text, origen.Text);
                    c.insertarentradaCREDITO(textBox1.Text, textBox4.Text, textBox5.Text, textBox2.Text, comboBox3.Text, textBox6.Text, cero.Text, nop.Text, np.Text, origena.Text);
                    MessageBox.Show("Deposito realizado con exito.", "Mensaje");

                    comboBox3.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "0.00";
                    textBox5.Text = "";
                    textBox6.Text = ".00";
                    textBox7.Text = "";
                    numero.Text = "";
                    nombrep.Text = "";
                    numerop.Text = "";
                    origen.Text = "";
                    origena.Text = "";
                    np.Text = "";
                    nop.Text = "";
                    c.selectnumeroentrada(textBox1);
                    double nocuenta = Convert.ToDouble(textBox1.Text);
                    nocuenta++;
                    textBox1.Text = nocuenta.ToString();
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
                    cero.Text = "";

                }
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.selectbancosolo(comboBox3.Text, textBox2);
            c.selectcatalogoentrada12(comboBox3.Text,np,nop,origena);
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            textBox2.Text = "";
            textBox3.Text = "0.00";
            textBox5.Text = "";
            textBox6.Text = ".00";
            textBox7.Text = "";
            numero.Text = "";
            nombrep.Text = "";
            numerop.Text = "";
            origen.Text = "";
            origena.Text = "";
            np.Text = "";
            nop.Text = "";
        }
    }
}
