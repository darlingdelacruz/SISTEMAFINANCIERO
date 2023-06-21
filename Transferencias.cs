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
    public partial class Transferencias : Form
    {
        conexion c = new conexion();
        public Transferencias()
        {
            InitializeComponent();
        }

        private void Transferencias_Load(object sender, EventArgs e)
        {
        
            c.llenaritems(comboBox1);
            c.llenaritems(comboBox2);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox11.Text = DateTime.Now.ToString("yyyy/MM/dd");
            c.selectnumeroentrada(entrada);
            double nocuenta = Convert.ToDouble(entrada.Text);
            nocuenta++;
          entrada.Text = nocuenta.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.selectbanco(comboBox1.Text, textBox1, textBox2);
            c.selectcatalogoentrada12(comboBox1.Text, np, nop, origena);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.selectbanco(comboBox2.Text, textBox3, textBox4);
            c.selectcatalogoentrada12(comboBox2.Text, nombrep, numerop, origen);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "") 
            {

                textBox5.Text = "00";
            
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {

                textBox6.Text = "00";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox9.Text = "Transferencia";
                double monto1 = Convert.ToDouble(textBox2.Text);
                double monto2 = Convert.ToDouble(textBox4.Text);
                double monto3 = Convert.ToDouble(textBox5.Text);
                double monto4 = Convert.ToDouble(textBox6.Text);
                double total1 = 0;
                double total2 = 0;
                double total3 = 0;

                if (monto3 > monto1 | monto4 > monto1 )
                {

                    MessageBox.Show("Esta cuenta no dispone de ese monto.", "ADVERTENCIA");


                }
                else if (textBox1.Text == "" | textBox3.Text == "" | comboBox1.Text == "" | comboBox2.Text == "") 
                {

                    MessageBox.Show("Llene todos los campos correctamente.", "ADVERTENCIA");
                
                }
                else
                {

                    total1 = (monto1 - monto3) - monto4;

                    textBox7.Text = total1.ToString();

                    total2 = monto2 + monto3;

                    textBox8.Text = total2.ToString();

                    total3 = monto3 + monto4;

                    textBox10.Text = total3.ToString();
                    c.insertarcuenta1(comboBox1.Text, textBox1.Text, textBox2.Text, textBox10.Text, textBox12.Text, textBox9.Text, textBox11.Text);
                    c.insertarcuenta1(comboBox2.Text, textBox3.Text, textBox4.Text, textBox12.Text, textBox5.Text, textBox9.Text, textBox11.Text);
                    //c.UPDATeemonto(textBox7.Text, comboBox1.Text);
                    //c.UPDATeemonto(textBox8.Text, comboBox2.Text);
                     c.insertarentradaCREDITO(entrada.Text,textBox11.Text,textBox9.Text,textBox1.Text,comboBox1.Text,textBox12.Text,textBox10.Text,nombrep.Text,numerop.Text,origen.Text);
                     c.insertarentradaCREDITO(entrada.Text,textBox11.Text,textBox9.Text,textBox3.Text,comboBox2.Text,textBox10.Text,textBox12.Text,np.Text,nop.Text,origena.Text);

                    double nocuenta = Convert.ToDouble(entrada.Text);
                    nocuenta++;
                   entrada.Text = nocuenta.ToString();

                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "0.00";
                    textBox3.Text = "";
                    textBox4.Text = ".00";
                    textBox5.Text = "00";
                    textBox6.Text = "00";
                    numerop.Text = "";
                    nombrep.Text = "";
                    origen.Text = "";
                    origena.Text = "";
                    np.Text = "";
                    nop.Text = "";
                    MessageBox.Show("Tranferencia realizada con exito.", "Mensaje");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Los datos introducidos son incorrectos", "ADVERTENCIA!");
                comboBox1.Text = "";
                comboBox2.Text = "";
                textBox1.Text = "";
                textBox2.Text = "0.00";
                textBox3.Text = "";
                textBox4.Text = ".00";
                textBox5.Text = "00";
                textBox6.Text = "00";
            }
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "0.00";
            textBox3.Text = "";
            textBox4.Text = ".00";
            textBox5.Text = "00";
            textBox6.Text = "00";
            numerop.Text = "";
            nombrep.Text = "";
            origen.Text = "";
            origena.Text = "";
            np.Text = "";
            nop.Text = "";
        }
    }
}
