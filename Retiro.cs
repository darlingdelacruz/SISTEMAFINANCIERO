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
    public partial class Retiro : Form
    {
        Solonumero S = new Solonumero();
        conexion c = new conexion();

        public Retiro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" | nombre.Text == "" | numero.Text == "" | textBox2.Text == "" | textBox3.Text == "" | comboBox3.Text == "")
            {


                MessageBox.Show("Llene todos los campos.", "Mensaje");

            }
            else
            {try
            {
                double mierda = Convert.ToDouble(textBox6.Text);
                c.insertarcuenta1(comboBox3.Text, textBox2.Text, textBox7.Text, textBox8.Text, textBox6.Text, textBox5.Text, textBox4.Text);
                //c.UPDATeemonto(textBox7.Text, comboBox3.Text);
               c.insertarentradaCREDITO(textBox8.Text, textBox4.Text, textBox5.Text, nombre.Text, numero.Text, textBox6.Text, cero.Text, numerop.Text, nombrep.Text, origen.Text);
               c.insertarentradaCREDITO(textBox8.Text, textBox4.Text, textBox5.Text, textBox2.Text, comboBox3.Text, cero.Text, textBox6.Text, nop.Text, np.Text, origena.Text);
                MessageBox.Show("Retiro realizado con exito.", "Mensaje");

                comboBox3.Text = "";
                textBox2.Text = "";
                textBox3.Text = "0.00";
                textBox5.Text = "";
                textBox6.Text = ".00";
                textBox7.Text = "";
                 numero.Text = "";
                 nombre.Text = "";
                nombrep.Text = "";
                numerop.Text = "";
                origen.Text = "";
                origena.Text = "";
                np.Text = "";
                nop.Text = "";
                c.selectnumeroentrada(textBox8);
                double nocuenta = Convert.ToDouble(textBox8.Text);
                nocuenta++;
                textBox8.Text = nocuenta.ToString();
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
                
            
            }

        }
        }

     

        private void Retiro_Load(object sender, EventArgs e)
        {
             c.llenaritems(comboBox3);
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox4.Text = DateTime.Now.ToString("yyyy/MM/dd");
            c.selectnumeroentrada(textBox8);
            if (textBox8.Text =="")
            {

                textBox8.Text = "0";
            }
            double nocuenta = Convert.ToDouble(textBox8.Text);
            nocuenta++;
            textBox8.Text = nocuenta.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text == "")
                {

                    textBox6.Text = ".00";

                }
              

                else
                {
                    double monto1 = Convert.ToDouble(textBox6.Text);
                    double monto2 = Convert.ToDouble(textBox3.Text);

                    if (monto2 < monto1)
                    {

                        MessageBox.Show("Esta cuenta no dispone de ese monto.", "ADVERTENCIA");
                        textBox7.Text = textBox3.Text;


                    }
                    else 
                    
                    {

                        double total = 0;
                        total = monto2 - monto1;
                        textBox7.Text = total.ToString();
                    }
               
              
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Has introducido datos erroneos", "ADVERTENCIA!");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.selectbancosolo(comboBox3.Text, textBox2);
            c.selectcatalogoentrada12(comboBox3.Text, np, nop, origena);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.selectbanco1(numero.Text,nombre);
            c.selectcatalogoentrada12(numero.Text, nombrep, numerop, origen);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero_TextChanged(object sender, EventArgs e)
        {
            c.selectcatalogow(numero.Text,nombre,nombrep,numerop,origen);
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
            nombre.Text = "";
            nombrep.Text = "";
            numerop.Text = "";
            origen.Text = "";
            origena.Text = "";
            np.Text = "";
            nop.Text = "";
        }
    }
}
